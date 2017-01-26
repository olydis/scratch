using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitGraphicalTestRunner
{
    class RunInfo
    {
        public string Id { get; set; }
        public Exception Error { get; set; }

        public override string ToString()
        {
            return Error == null
                ? $"{Id}"
                : $"{Id} ({Error.Message})";
        }
    }
}
