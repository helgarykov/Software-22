namespace DIKUDebate;

public class DIKUPerson
{
    private protected Random random = new Random();
    private protected string name { get; set; }
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
            //Console.WriteLine("I successfully counted the argument and increased ny intellect by the given points.");
            return false;
        }
        intellect -= amount;
        //Console.WriteLine($"{name} failed to counter the argument and decreased the intellect by {amount} points.");
        return true;
    }

    public void Argue(DIKUPerson opponent)
    {
        Console.WriteLine($"DIKUPerson {name} strikes an argument at DIKUPerson {opponent.name} for {strengthOfArgument} points of draining." );
        if (criticalArgument > random.Next(0, 100))
        {
            strengthOfArgument *= 2;
            opponent.intellect -= strengthOfArgument;
            opponent.beDrained(strengthOfArgument);
        }
        opponent.GetExperience();
        Console.WriteLine($"{opponent.name} has won the argument over {name} and got experience.");
    }

    public virtual void GetExperience()
    {
        strengthOfArgument *= 2;
        if (preparation == Preparation.ReadingAll && preparation == Preparation.ReadingSome) maxIntellect *= 10;
        if (preparation == Preparation.ReadingNone) maxIntellect *= 20;
        if (preparation == Preparation.ReadingNone) counterArgument *= 3;
        if (preparation == Preparation.ReadingAll && preparation == Preparation.ReadingSome) counterArgument *= 6;
        if (preparation == Preparation.ReadingAll) criticalArgument *= 6;
        if (preparation == Preparation.ReadingNone && preparation == Preparation.ReadingSome) criticalArgument *= 3;
        intellect = maxIntellect;
    }
}