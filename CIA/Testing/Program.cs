using CIA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public static class Program
    {

        public static void Main()
        {
            var cp = new CompilerCLI();
            string code = @"

public static void main(args)
{
using System;
let b = {quot}wow{quot};

}";

            cp.Compile(code.Replace("{quot}", "\""), "test.exe", Properties.Resources.CSharpPattern);
        }

    }
}
