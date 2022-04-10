
namespace Collatz
{
    namespace System.Collections.Generic
    {
        public static class Program
        {
            public static void Main(string[] args)
            {  
               
                var remainder = new BasicFunctions();
                Console.WriteLine(remainder.Collatz(2, 10, 11));
                Console.WriteLine();
                //Console.WriteLine(remainder.GCD(-99, 4345));


            }
        }
    }
}


/// Console.WriteLine("Hello, World!");
