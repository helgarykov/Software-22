namespace DIKUDebate;

public class DIKUStudent : DIKUPerson
{
    public DIKUStudent(string name) : base(name)
    {
        this.intellect = 30;
        this.maxIntellect = 10;
        this.strengthOfArgument = 3;
        this.semester = 1;
        this.counterArgument = 10;
        this.criticalArgument = 10;
    }

    public override void GetExperience()
    {
        semester++;
    }
}

