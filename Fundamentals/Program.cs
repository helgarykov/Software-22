namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Fundamentals countBackwords = new Fundamentals();

            countBackwords.CountBackwards();

            Fundamentals reversed = new Fundamentals();
            string str = "stressed :(";
            reversed.ReverseString(str);
        }
    }
}


