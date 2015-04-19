using CIA.Internals.Compiler.AST.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIA.Internals.Compiler.AST
{
    public class Statment : IAst
    {
        public string Token { get; set; }
    }

    #region Statments

    public class VarSetExpressionStatment : Statment
    {
        public string Name { get; set; }
        public string SetOP { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }

        public VarSetExpressionStatment()
        {
            Token = "VarSetExpressionStatment";
        }
    }

    public class UsingStatment : Statment
    {
        public string Name { get; set; }


        public UsingStatment()
        {
            Token = "UsingStatment";
        }
    }
    public class CallStatment : Statment
    {
        public string Path { get; set; }
        public List<string> Permas { get; set; }

        public CallStatment()
        {
            Token = "CallStatment";
            Permas = new List<string>();
        }
    }
    #endregion
}
