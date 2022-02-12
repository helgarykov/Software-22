using System;
namespace Fundamentals;

public class Fundamentals
{
    public void CountBackwards()
    {
        Console.WriteLine("Input: None");
        Console.WriteLine();
        Console.Write("PrintOutput: ");
        for (int i = 10; i > 0; --i)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine(" Finished!");
        Console.WriteLine();
        Console.WriteLine("Returns: Nothing. The return type is void.");
    }
}
    
