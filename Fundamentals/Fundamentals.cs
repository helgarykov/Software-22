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
        Console.WriteLine();
        Console.WriteLine("Input string");
        Console.WriteLine();
        Console.WriteLine("Output The reversed string.");
        Console.WriteLine();
        Console.WriteLine("Example Input stressed :(");
        Console.WriteLine();
        Console.Write("The reversed output ");
    }
    public void ReverseString(string word)
    {
        if (word.Length <= 1)
        {
            Console.Write(word);
        }
        else
        {
            // Prints out the original string in a reversed order; starts with the last char and prints chars out one by one.
            Console.Write(word[word.Length-1]);
            // First round: Takes the char that corresponds to the one printed out above and cuts it off the original string.
            // Second round: Adds chars one by one, starting from index [1] and to [word.Length - 1] - the final result == the original string.
            ReverseString(word.Substring(0,(word.Length-1)));
        }
    }

}

