using CIA.Internals.Compiler.AST.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIA
{
    internal abstract class ICompiler
    {
        public void Compile(string Code, string OutPutFile, string Pattern)
        {
            GenCode(ParceScaned(ScanCode(Code, Pattern)), OutPutFile);
        }

        private string ScanCode(string code, string Pattern);// build a little string with tokens
        private List<IAst> ParceScaned(string Tokens);// Convert tokens to ast
        private void GenCode(List<IAst> ast, string path);// Convert ast to executble
    }
}
