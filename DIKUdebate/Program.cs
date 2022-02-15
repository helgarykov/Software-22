namespace DIKUDebate;

public class Program
{
    public static void Main(string[] args)
    {
        DIKUPerson person = new("Laust");
        Console.WriteLine("The person is " + person);
        DIKUStudent uffe = new DIKUStudent("Uffe");
        Console.WriteLine("The person is " + uffe);
        
        
        DIKUProfessor boris = new DIKUProfessor("Boris");
        Console.WriteLine("The professor is " + boris);
        DIKUPerson opponent = new DIKUPerson("Liva");
        uffe.hasLost();
        boris.hasLost();
        uffe.beDrained(5);
        boris.beDrained(100);
        
        uffe.Argue(boris);
        

    }

}

