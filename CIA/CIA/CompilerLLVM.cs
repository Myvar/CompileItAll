using CIA.Internals.Compiler.AST.Base;
using Eto.Parse.Grammars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIA
{
    public class CompilerLLVM : ICompiler
    {
        private string ScanCode(string code, string Pattern)
        {
            var grammar = new EbnfGrammar(EbnfStyle.WhitespaceSeparator).Build(Pattern , "Code parser");

            return "";
        }
        private List<IAst> ParceScaned(string Tokens)
        {
            return new List<IAst>();
        }

        private void GenCode(List<IAst> ast, string path)
        {

        }
    }
}
