using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input != "x" && input != "exit")
            {
                Console.WriteLine("enter your base and then your exponent");
                var mString = Console.ReadLine();
                var nString = Console.ReadLine();

                int m, n;
                while ((int.TryParse(mString, out m) || int.TryParse(nString, out n) == true))
                {
                    Console.WriteLine("Please re-enter your stuff but not like a moron this time: ");
                    mString = Console.ReadLine();
                    nString = Console.ReadLine();
                } 

                Console.WriteLine("Answer is " + MathStuff.Power(m, n));
                Console.WriteLine("Type 'x' or 'exit' to exit or basically anthing else to go again");
                input = Console.ReadLine();
            }
        }
    }

    public static class MathStuff
    {
        public static int Power(int m, int n)
        {
            int p = 1;

            if (n == 0)
            {
                return 1;
            }

            else
            {
                for (int i = 0; i < n; i++)
                {
                    p = p * m;
                }
                return p;
            }
        }
    }    
}
