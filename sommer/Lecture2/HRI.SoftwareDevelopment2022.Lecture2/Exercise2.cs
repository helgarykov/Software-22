namespace HRI.SoftwareDevelopment2022.Lecture2;

public class Exercise2
{
    /// <summary>
    /// Write a program and ask the user to enter 5 numbers.
    /// If a number has been previously entered, display an
    /// error message and ask the user to re-try. Once the user
    /// successfully enters 5 unique numbers, sort them and display
    /// the result on the console.
    /// </summary>
    public static void ReverseNumbers()
    {
        Console.WriteLine("Enter five unique numbers.");
        
        // var str = Convert.ToString(Console.ReadLine());
        // var numbers = str.ToArray();
        // int[] ints = Array.ConvertAll(numbers, c => (int) Char.GetNumericValue(c));
        
        var number1 = Convert.ToInt32(Console.ReadLine());
        var number2 = Convert.ToInt32(Console.ReadLine());
        var number3 = Convert.ToInt32(Console.ReadLine());
        var number4 = Convert.ToInt32(Console.ReadLine());
        var number5 = Convert.ToInt32(Console.ReadLine());
        
        var numbers = new[] {number1, number2, number3, number4, number5};
        Array.Sort(numbers);
        
        for (var i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] != numbers[i + 1]) continue; // "continue" skips the body of the loop if the condition is true
            Console.WriteLine("Your line of numbers contains duplicates. Retry!");
            return;
        }
        Console.WriteLine("Your numbers have been sorted and are " + string.Join(",", numbers));
    }
}