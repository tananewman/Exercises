using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOverFlow.FunctionA();
        }
    }

    public static class StackOverFlow
    {
        public static void FunctionA()
        {
            FunctionB();
        }

        public static void FunctionB()
        {
            FunctionA();
        }
    }
}
