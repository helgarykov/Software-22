using System;
namespace DIKUDebate;

public class Program
{
    public static void Main(string[] args)
    {
        DIKUPerson person = new("Laust");
        Console.WriteLine("The person is " + person);
        DIKUStudent uffe = new DIKUStudent("Uffe");
        Console.WriteLine("The person is " + uffe);
        DIKUStudent marianne = new DIKUStudent("Marianne");
        DIKUStudent sonja = new DIKUStudent("Sonja");
        
        
        DIKUProfessor boris = new DIKUProfessor("Boris");
        Console.WriteLine("The professor is " + boris);
        DIKUPerson opponent = new DIKUPerson("Liva");
        uffe.hasLost();
        boris.hasLost();
        uffe.beDrained(100);
        boris.beDrained(10);
        
       // boris.Argue(uffe);
        //marianne.Argue(uffe);
        marianne.Argue(sonja);
        //boris.GetExperience();
        //uffe.GetExperience();
        

    }

}

