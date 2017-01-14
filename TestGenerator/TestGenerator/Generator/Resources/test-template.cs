// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using /*<*/Dummy/*></clientNamespace>*/;

namespace /*<*/Dummy/*></clientNamespace>*/.Tests
{
    public class /*<*/BugDummy/*></className>*/
    {
        [Fact]
        public async Task Execute()
        {
            var serviceClient = /*<*/(dynamic)null/*></clientConstructorCall>*/;
            //<debug/>
        }
    }
}