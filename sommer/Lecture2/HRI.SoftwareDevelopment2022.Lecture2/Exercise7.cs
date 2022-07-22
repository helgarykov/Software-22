namespace HRI.SoftwareDevelopment2022.Lecture2;

public class Exercise7
{
    public static void DetermineWhetherNumberIsPalindrome()
    {
        Console.WriteLine("Enter number");  
        var number = Console.ReadLine();  
        var reverseNumber = ""; 
        
        //String Reverse 
        for (var i = number!.Length - 1; i >= 0; i--)  
        {  
            reverseNumber += number[i].ToString();  
        }  
            
        // Checking whether string is palindrome or not  
        if (reverseNumber == number) 
        {  
            Console.WriteLine("Number is Palindrome \n " +
                              "Entered number was {0} and reverse number is {1}", number, reverseNumber);  
        }  
        else  
        {  
            Console.WriteLine("Number is not Palindrome \n " +
                              "Entered number was {0} and reverse number is {1}", number, reverseNumber);  
        }
    }
}