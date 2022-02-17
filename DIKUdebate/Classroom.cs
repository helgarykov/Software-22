namespace DIKUDebate;

public class Classroom
{
    public DikuPerson? Discuss(DikuPerson person1, DikuPerson person2)
    {
        Console.WriteLine("Debate til drained!");
        int round = 1;
        DikuPerson current = person1;
        DikuPerson inactive = person2;
        // Argue until someone is too drained
        // of Intellect to keep on.
        while (!person1.HasLost() && !person2.HasLost())
        {
            Console.WriteLine($"Round: {round}.");
            current.Argue(inactive);
            // Switching them , such that the
            // inactive student is current and can argue back!
            (current, inactive) = (inactive, current);
            round++;
        }

        if (!person1.HasLost())
        {
            var winner = person1;
            winner.GetExperience();
            Console.WriteLine($"The winner is {winner}.");
            Console.WriteLine();
        }

        if (!person2.HasLost())
        {
            var winner = person2;
            winner.GetExperience();
            Console.WriteLine($"The winner is {winner}.");
            Console.WriteLine();
        }

        if (person1 != null) return person1;
        return person2;
    }
}