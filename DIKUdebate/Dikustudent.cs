namespace DIKUDebate;

public class DIKUStudent : DIKUPerson
{
    public DIKUStudent(string name) : base(name)
    {
        intellect = 30;
        maxIntellect = 30;
        strengthOfArgument = 3;
        semester = 1;
        counterArgument = 10;
        criticalArgument = 10;
    }
}

