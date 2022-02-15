namespace DIKUDebate;

public class DIKUPerson
{
    private protected Random random = new Random();
    private DIKUPerson name { get; set; }
    private protected int maxIntellect { get; set; }
    private protected int intellect { get; set; }
    private protected int strengthOfArgument{ get; set; }
    private protected int semester { get; set; }
    private protected int counterArgument { get; set; }
    private protected int criticalArgument { get; set; }
    private Preparation preparation { get; set; }

    public DIKUPerson(string name)
    {
        this.name = name;
    }
    //Prints objects as a string.
    public override string ToString()
    {
        return string.Format(name + " " + preparation + " " + semester + " " + intellect);
    }

    public virtual bool hasLost()
    {
        if (intellect <= 0) return true;
        return false;
    }

    public virtual bool beDrained(int amount)
    {
        if (counterArgument > random.Next(0, 100))
        {
            intellect += amount;
            Console.WriteLine("I successfully counted the argument and increased ny intellect by the given points.");
            return false;
        }
        intellect -= amount;
        Console.WriteLine("I failed to counter the argument and decreased ny intellect by the given points.");
        return true;
    }

    public void Argue(DIKUPerson opponent)
    {
        if (criticalArgument > random.Next(0, 100))
        {
            strengthOfArgument *= 2;
        }
        Console.WriteLine("DIKUPerson 1 performs an attack action on other DIKUPerson.");
        Console.WriteLine($"DIKUPerson {name} strikes an argument at DIKUPerson {this.name} for 5 points of draining." );
        opponent.beDrained(5);
    }
}