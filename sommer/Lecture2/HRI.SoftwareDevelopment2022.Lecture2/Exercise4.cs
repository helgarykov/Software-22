namespace HRI.SoftwareDevelopment2022.Lecture2;

public class Exercise4
{
    /// <summary>
    /// Returns all possible 5-digit numbers the sum of which is larger than 18.
    /// </summary>
    /// <param name="numbers"> A List of ints.</param>
    /// <param name="target">The sum </param>
    /// <param name="partial"> The list of 5 digits</param>
    public static void GetSum(List<int> numbers, int target, List<int> partial)
    {
        SumUpRecursive(numbers, target, partial);
    }

    private static void SumUpRecursive(List<int> numbers, int target, List<int> partial)
    {
        var sum = 0;
        foreach (var number in partial) sum += number; //var sum = partial.Sum();
        
        if (sum > target && partial.Count == 5)
        {
            Console.WriteLine("Sum(" + string.Join(",", partial.ToArray()) + ")>" + target);
        }

        for (var i = 0; i < numbers.Count; i++)
        {
            List<int> remaining = new List<int>();
            var number = numbers[i];
            
            for (var j = i + 1; j < numbers.Count; j++)
            {
                remaining.Add(numbers[j]);
            }

            List<int> partialRec = new List<int>(partial);
            partialRec.Add(number);
            SumUpRecursive(remaining, target, partialRec);
        }
    }
    
}
     