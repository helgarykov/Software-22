namespace HRI.SoftwareDevelopment2022.Lecture2;

public static class Exercise6
{
    public static void GetVector(int naturalNumberOne, int naturalNumberTwo, decimal decimalNumber)
    {
        if (naturalNumberTwo <= 100)
        {
            if (decimalNumber > naturalNumberOne && decimalNumber < naturalNumberTwo || decimalNumber > 100)
            {
                for (var i = naturalNumberOne; i <= naturalNumberTwo; i++)
                {
                    Console.WriteLine(i);

                }
            }
            else
            { 
                Console.WriteLine("Enter a decimal number that is within the bounds of the two natural numbers.");
            }
        }
        else
        {
            for (var i = naturalNumberOne; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        } 
    } 
}