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
            
            
            //Returns all possible 5-digit numbers the sum of which is larger than 18.
            Console.WriteLine(10.0/3.0);
            int sum;
            int number;
            int digit;

            for(int i =100;i<1000;i++){
                sum=0;
                number=i;
                //for loop disassembles number into digits
                //number:12345
                //digit:5
                //j:0
                //number:1234
                //digit:4
                //j:1
                //number:123
                //digit:3
                //j:2
                //...
                //number:0
                //j:5
                for(int j=0;j<3;j++){
                    // number: 12345 
                    digit=number%10;
                    //digit: 5 - ostacha vid dilennya na 10
                    //12340/10 == 1234
                    sum+=digit;
                    number/=10; 
                    //number: 1234 ( 12345/10 -> 1234 because both 12345 and 10 are integer)
                }
    

                if(sum>15){
                    Console.WriteLine(i);
                }
            }
        }
        
    }
}

