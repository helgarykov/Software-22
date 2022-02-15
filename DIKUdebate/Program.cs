namespace DIKUClassroom;

public class Program
{
    public static void Main(string[] args)
    {
        DIKUperson person = new("Laust");
        Console.WriteLine("The person is " + person);
        DIKUstudent uffe = new DIKUstudent("Uffe");
        Console.WriteLine("The person is " + uffe);
        DIKUprofessor boris = new DIKUprofessor("Boris");
        Console.WriteLine("The professor is " + boris);
    }

}

