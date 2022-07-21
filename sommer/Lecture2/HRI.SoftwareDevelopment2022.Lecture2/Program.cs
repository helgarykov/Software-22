namespace HRI.SoftwareDevelopment2022.Lecture2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Exercise 1: Call to GetReversedName()
            // var reversedName = new Exercise1();
            // Exercise1.GetReversedName();
            // Console.WriteLine(reversedName);
            
            //Exercise 2
            // var reversedNumbers = new Exercise2();
            // Exercise2.ReverseNumbers();
            // Console.WriteLine(reversedNumbers);
            
            // Exercise 3
            var roots = new Exercise3();
            Exercise3.GetRoots(1.0, -3.0, -4.0);
            Exercise3.GetRoots(3.0, -18.0, 27.0);
            Exercise3.GetRoots(1.0, 6.0, 14.0);
            Exercise3.GetRoots(4.0, -12.0, 9.0);
            Console.WriteLine(roots);
            
            // Exercise 4
            var numbers = new List<int> { 0, 1, 2, 3,4, 5, 6, 7, 8, 9 };
            var partial = new List<int>();
            const int target = 18;
            Exercise4.GetSum(numbers, target, partial);
            
            // Exercise 5
            int[] myArray = {2, 76, 5, 45, 20, 15, 60, 100};
            Exercise5.ManipulateArray(myArray);
            Console.WriteLine(myArray);
        }
    }
}

