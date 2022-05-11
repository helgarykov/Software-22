
namespace Collatz
{
    namespace System.Collections.Generic
    {
        public static class Program
        {
            public static void Main(string[] args)
            {
                int result = BasicFunctions.Collatz(0, 20, 20);
                Console.WriteLine($"Collatz result: {result}.");
                int result2 = BasicFunctions.CollatzRec(1, 1, 1);
                Console.WriteLine($"CollatzRec result: {result2}.");
            }
        }
    }
}



