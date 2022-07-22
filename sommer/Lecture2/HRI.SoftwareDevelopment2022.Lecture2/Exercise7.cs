namespace HRI.SoftwareDevelopment2022.Lecture2;

public class Exercise7
{
    public static void DetermineWhetherNumberIsPalindrome()
    {
        var revs="";  
        Console.WriteLine(" Enter number");  
        var s = Console.ReadLine();  
            
        //String Reverse 
        for (int i = s!.Length-1; i >=0; i--)  
        {  
            revs += s[i].ToString();  
        }  
            
        // Checking whether string is palindrome or not  
        if (revs == s) 
        {  
            Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);  
        }  
        else  
        {  
            Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);  
        }  
        Console.ReadKey(); 
    }
}