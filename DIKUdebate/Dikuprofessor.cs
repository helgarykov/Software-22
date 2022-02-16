namespace DIKUDebate;

public class DIKUProfessor : DIKUPerson
{
    public DIKUProfessor(string name) : base(name)
    {
        this.maxIntellect = 10000;
        this.intellect = 10000;
        this.strengthOfArgument = 10000;
        this.counterArgument = 10000;
        this.criticalArgument = 10000;
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
