namespace DIKULecture;

public class Lecture : ChatRoom
{
    private int numOfStudentsOnline = 0;
    private bool information;

    public bool Information
    {
        get { return information; }
        set { information = value; }
    }

    public int NumOfStudents { get; }

    public Lecture(string? name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name + "\n" + " The current number of students: " + string.Format(numOfStudentsOnline.ToString());
    }
}