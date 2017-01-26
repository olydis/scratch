using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XUnitGraphicalTestRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                var folder = Path.GetDirectoryName(textBox1.Text);
                var ass = Assembly.LoadFile(Path.Combine(folder, args.Name.Split(',')[0] + ".dll"));
                return ass;
            };
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            var file = files.FirstOrDefault();
            if (file != null)
                textBox1.Text = file;
        }

        private CancellationTokenSource src = new CancellationTokenSource();

        private void button1_Click(object sender, EventArgs e)
        {
            RunUnsucc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            succ.Clear();
            RunUnsucc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            src.Cancel();
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var error = (listBox1.SelectedItem as RunInfo)?.Error;
            if (error != null)
                MessageBox.Show(error.ToString());
        }

        private async void RunUnsucc()
        {
            // appdomain and loading
            slave = AppDomain.CreateDomain("slave", AppDomain.CurrentDomain.Evidence, new AppDomainSetup { ShadowCopyFiles = "true", ShadowCopyDirectories = Path.GetDirectoryName(textBox1.Text) });
            // hack, appdomain thing doesn't work either... would need http://stackoverflow.com/questions/20230634/unload-assembly-from-app-domain
            //var tmpDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            //DirectoryCopy(Path.GetDirectoryName(textBox1.Text), tmpDir);
            //var tests = DiscoverTests(Path.Combine(tmpDir, Path.GetFileName(textBox1.Text))).ToArray();
            var tests = DiscoverTests(textBox1.Text).ToArray();


            failed.Clear();

            var fastSucc = new HashSet<string>(succ.Select(x => x.Id));
            tests = tests.Where(x => !fastSucc.Contains(GetId(x))).ToArray();
            var todo = tests.Length;

            int para = checkBox1.Checked ? (todo / 100 + 1) : (int)numericUpDown1.Value;

            src = new CancellationTokenSource();
            ThreadPool.SetMinThreads(para, para);
            await Task.Run(() => Parallel.ForEach(tests, new ParallelOptions { MaxDegreeOfParallelism = para, CancellationToken = src.Token }, test =>
            {
                var id = GetId(test);
                var testObj = Activator.CreateInstance(test.DeclaringType);
                try
                {
                    test.Invoke(testObj, null);
                    lock (this)
                        succ.Add(new RunInfo {Id = id});
                }
                catch (TargetInvocationException e)
                {
                    lock (this)
                        failed.Add(new RunInfo {Id = id, Error = e.InnerException});
                }
                
                Interlocked.Decrement(ref todo);
                Console.WriteLine($"{todo} ==> {succ.Count} + {failed.Count}");
            }));
            failed.Sort((a, b) => a.Id.CompareTo(b.Id));
            this.listBox1.DataSource = failed;

            // appdomain
            AppDomain.Unload(slave);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var commandBuffer = new StringBuilder();
            foreach (var failedTest in failed)
            {
                var testId = failedTest.Id.Split('.')[0].Replace("Test", "");
                commandBuffer.AppendLine($@"copy {testId}_s.txt ..\rawErr\{testId}_s.txt");
                commandBuffer.AppendLine($@"copy {testId}_c.txt ..\rawErr\{testId}_c.txt");
                commandBuffer.AppendLine($@"copy {testId}_m.xml ..\rawErr\{testId}_m.xml");
            }
            Clipboard.SetText(commandBuffer.ToString());
        }

        // data
        private List<RunInfo> succ = new List<RunInfo>();
        private List<RunInfo> failed = new List<RunInfo>();
        private AppDomain slave;

        // non UI
        string GetId(MethodInfo info)
            => info.DeclaringType?.FullName + "." + info.Name;

        IEnumerable<MethodInfo> DiscoverTests(string path)
            => slave.Load(new AssemblyName {CodeBase = path}).ExportedTypes.SelectMany(type => type.GetMethods().Where(m => m.GetCustomAttributes(false).Any(a => a.GetType().FullName == "Xunit.FactAttribute")));


        // helpers
        private static void DirectoryCopy(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destDirName))
                Directory.CreateDirectory(destDirName);
            
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
                file.CopyTo(Path.Combine(destDirName, file.Name), false);

            foreach (DirectoryInfo subdir in dirs)
                DirectoryCopy(subdir.FullName, Path.Combine(destDirName, subdir.Name));
        }
    }
}
