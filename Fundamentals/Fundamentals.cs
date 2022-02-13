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
        Console.Write("The reversed output ");
    }
    
    // Recursive function is a pure function and does not return anything
    // else than what is conditioned by the input.
    public void ReverseString(string word)
    {
        if (word.Length <= 1)
        {
            Console.Write(word);
        }
        else
        {
            // Prints out the original string in a reversed order;
            // starts with the last char and prints chars out one by one.
            Console.Write(word[word.Length - 1]);
            // First round: Takes the char that corresponds to the one printed out above
            // and cuts it off the original string.
            // Second round: Adds chars one by one, starting from index [1] and to
            // [word.Length - 1]. The final result == the original string.
            ReverseString(word.Substring(0,(word.Length - 1)));
        }
    }

}

