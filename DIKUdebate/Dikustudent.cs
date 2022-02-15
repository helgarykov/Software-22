namespace DIKUClassroom;

public class DIKUstudent : DIKUperson
{
    public DIKUstudent(string name) : base(name)
    {
        this.intellect = 30;
        this.maxIntellect = 10;
        this.strengthOfArgument = 3;
        this.semester = 1;
        this.counterArgument = 10;
        this.criticalArgument = 10;
    }
}

