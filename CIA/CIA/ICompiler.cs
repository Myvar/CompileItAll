using CIA.Internals.Compiler.AST.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIA
{
    public abstract class ICompiler
    {
        public void Compile(string Code, string OutPutFile, string Pattern)
        {
            GenCode(ParceScaned(ScanCode(Code, Pattern)), OutPutFile);
        }

        public abstract List<KeyValuePair<string, string>> ScanCode(string code, string Pattern);// build a little string with tokens
        public abstract List<IAst> ParceScaned(List<KeyValuePair<string, string>> Tokens);// Convert tokens to ast
        public abstract void GenCode(List<IAst> ast, string path);// Convert ast to executble
    }
}
