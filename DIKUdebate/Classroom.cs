namespace DIKUDebate
{

    namespace System.Collections.Generic
    {
        public class Classroom
        {
            public DikuPerson Discuss(DikuPerson person1, DikuPerson person2)
            {
                Console.WriteLine("Debate til drained!");
                var round = 1;
                var current = person1;
                var inactive = person2;
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
                    person1.GetExperience();
                    Console.WriteLine($"The winner is {person1}.");
                    Console.WriteLine();
                    return person1;
                }
                person2.GetExperience();
                Console.WriteLine($"The winner is {person2}.");
                Console.WriteLine();
                return person2;
            }
            public DikuPerson? RunDebate(List<DikuPerson> debateParticipants)
            {
                var round = 1;
                Console.WriteLine($"Final Debate.");
                List<DikuPerson> winners = new List<DikuPerson>();
                while (debateParticipants.Count > 1)
                {
                    var p1 = debateParticipants[0];
                    var p2 = debateParticipants[1];
                    winners.Add(Discuss(p1, p2));
                    debateParticipants.Remove(p1);
                    debateParticipants.Remove(p2);

                    if (debateParticipants.Count == 1 && winners.Count > 0)
                    {
                        winners.Add((debateParticipants[0]));
                        round++;
                        return RunDebate(winners);
                    }
                    if (debateParticipants.Count == 0 && winners.Count > 1)
                    {
                        return RunDebate(winners);
                    }
                }
                return winners[0];
            }
        }
    }
}