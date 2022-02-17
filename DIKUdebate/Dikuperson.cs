using System;
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
        return string.Format(name + " " + preparation + " " + intellect);
    }

    public virtual bool hasLost()
    {
        if (intellect <= 0) return true;
        return false;
    }

    public virtual bool beDrained(int amount)
    {
        if (!(counterArgument > random.Next(0, 100)))
        {
            intellect -= amount;
            return true;
        }
        Console.WriteLine($"{name} succeeded to counter the argument.");
        return false;
    }

    public void Argue(DIKUPerson opponent)
    {
        Console.WriteLine($"DIKUPerson {name} strikes an argument at DIKUPerson {opponent.name} for {strengthOfArgument} points of draining.");
        if (criticalArgument > random.Next(0, 100))
        {
            strengthOfArgument += 2;
            opponent.intellect -= strengthOfArgument;
            opponent.beDrained(strengthOfArgument);
            Console.WriteLine($"DIKUPerson {opponent.name} lost the argument for {strengthOfArgument} points of draining.");
            return;
        }
        opponent.intellect -= strengthOfArgument;
        opponent.GetExperience();
        Console.WriteLine();
        Console.WriteLine($"{opponent.name} managed to counter the argument.");
    }

    public virtual void GetExperience()
    {
        semester++;
        strengthOfArgument += 2;
        if (preparation is Preparation.ReadingAll or Preparation.ReadingSome) maxIntellect += 10;
        if (preparation == Preparation.ReadingNone) maxIntellect += 20;
        if (preparation == Preparation.ReadingNone) counterArgument += 3;
        if (preparation is Preparation.ReadingAll or Preparation.ReadingSome) counterArgument += 6;
        if (preparation == Preparation.ReadingAll) criticalArgument += 6;
        if (preparation is Preparation.ReadingNone or Preparation.ReadingSome) criticalArgument += 3;
        intellect = maxIntellect;
    }
}