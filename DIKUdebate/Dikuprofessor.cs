namespace DIKUDebate;

public class DIKUProfessor : DIKUPerson
{
    public DIKUProfessor(string name) : base(name)
    {
        maxIntellect = 10000;
        intellect = 10000;
        strengthOfArgument = 10000;
        counterArgument = 10000;
        criticalArgument = 10000;
    }

    public override bool hasLost()
    {
        Console.WriteLine("I can not lose!");
        return false;
    }
    public override bool beDrained(int amount)
    {
        if (counterArgument < random.Next(0, 100))
        {
            intellect /= amount;
            Console.WriteLine($"Professor {name} couldn't counter the argument and have been drastically drained of intellect.");
            return true;
        }
        Console.WriteLine("I am the professor and will always win an argument.");
        return false;
    }

    public override void GetExperience()
    {
        Console.WriteLine($"Professor {name} have finished his degree, he cannot be greater.");
    }
}
