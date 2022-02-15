namespace DIKUClassroom;

public class DIKUprofessor : DIKUperson
{
    public DIKUprofessor(string name) : base(name)
    {
        this.maxIntellect = 10000;
        this.intellect = 10000;
        this.strengthOfArgument = 10000;
        this.counterArgument = 10000;
        this.criticalArgument = 10000;
    }
}
