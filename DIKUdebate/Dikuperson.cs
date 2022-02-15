using System.Runtime.InteropServices.ComTypes;

namespace DIKUClassroom;

public class DIKUperson
{
    private string name { get; }
    private protected int maxIntellect { get; set; }
    private protected int intellect { get; set; }
    private protected int strengthOfArgument{ get; set; }
    private protected int semester { get; set; }
    private protected int counterArgument { get; set; }
    private protected int criticalArgument { get; set; }
    private Preparation preparation { get; set; }

    public DIKUperson(string name)
    {
        this.name = name;
    }
    
    //Prints the objects as a string.
    public override string ToString()
    {
        return string.Format(name + " " + preparation + " " + semester + " " + intellect);
    }
}