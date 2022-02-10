namespace DIKULecture;

public class Lecture : ChatRoom
{
    private int numOfStudentsOnline = 0;
    private protected bool information;

    public bool Information
    {
        get { return information; }
        set { information = value; }
    }

    public Lecture(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name + " the current number of students: " + string.Format(numOfStudentsOnline.ToString());
    }
}