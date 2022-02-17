namespace DIKUDebate;

public DIKUPerson Discussion ( DIKUPerson person1 , DIKUPerson person2)
{
    Console.WriteLine("Debate til drained!");
    int round = 1;
    DIKUPerson current = person1;
    DIKUPerson inactive = person2;
    // Argue until someone is too drained
    // of Intellect to keep on.
    while (!person1.hasLost() && !person2.hasLost())
    {
        Console.WriteLine($"Round: {round}.");
        current.Argue(inactive);
        // Switching them , such that the
        // inactive student is current and can argue back!
        (current, inactive) = (inactive, current);
        round++;
    }
    if (!person1.hasLost())
    {
        var winner = person1;
        winner.GetExperience();
        Console.WriteLine($"The winner is {winner}.");
    }
    if (!person2.hasLost())
    {
        var winner = person2;
        winner.GetExperience();
        Console.WriteLine($"The winner is {winner}.");
    }

    return null;
}