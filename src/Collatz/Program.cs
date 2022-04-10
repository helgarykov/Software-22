
namespace Collatz
{
    namespace System.Collections.Generic
    {
        public static class Program
        {
            public static void Main(string[] args)
            {  
               
                var integer = new BasicFunctions();
                Console.WriteLine(integer.Collatz(9, 20, 50));
                
            }
        }
    }
}



