using Microsoft.VisualBasic;

namespace DIKULecture;

public class Person
{
    private protected string name;
    protected string occupation;
    private protected int age;

    public Person(string name, string occupation, int age)
    {
        this.name = name;
        this.occupation = occupation;
        this.age = age;
    }
}

public class Student : Person
{
    private bool isInLecture;
    private Lecture? lecture;
    //A student inherits the properties of its base class Person.
    public Student(string name, string occupation, int age) : base(name, occupation, age)
    {
    }
    //A student joins the lecture.
    public void Join(Lecture? lecture, string name, string nameStudent, List<Student> studentsAtLecture)
    {
        this.name = nameStudent;
        this.lecture = lecture;
        isInLecture = lecture is not null;
        if (lecture != null)
        {
            foreach (Student student in studentsAtLecture )
            {
                lecture.NumOfStudents++; // Updates the field numOfStudents
                isInLecture = true;
            }
        }
        Console.WriteLine($"Student {this.name} has joined {this.lecture}.");
        if (lecture != null) Console.WriteLine($"In all, {lecture.NumOfStudents} students have joined {this.lecture}.");
    }

    public void Listen()
    {
        if (isInLecture)
        {
            //A student gets information.
            bool informed = lecture != null && lecture.Information;
            Console.WriteLine($"It is {informed} that student {name} listens to the lecture.");
        }
        else
        {
            bool nonInformed = lecture is {Information: false};
            Console.WriteLine($"Student {name} received information is {nonInformed}.");
        }
    }
}

public class Speaker : Person
{
    private bool isInLecture;
    private Lecture? lecture;
    //A speaker inherits the properties of its base class Person.
    public Speaker(string name, string occupation, int age) : base(name, occupation, age)
    {
    }
    //The speaker joins the lecture.
    public void Broadcast(Lecture? lecture)
    {
        this.lecture = lecture;
        isInLecture = lecture is not null;
        Console.WriteLine($"Speaker {name} has joined {this.lecture}.");
    }
    public void Speak(bool information)
    {
        if (isInLecture)
        {
            // The speaker sets information.
            if (lecture != null)
            {
                lecture.Information = information;
                Console.WriteLine($"Speaker {name} says {information} at {lecture}.");
            }
        }
    }
    //The speaker changes the name of a lecture if isInLecture = true.
    public void Rename(Lecture? lecture, string? name, string nameSpeaker)
    {
        this.name = nameSpeaker;
        if (isInLecture)
        {
            if (lecture != null) lecture.Name = name;
            Console.WriteLine($"Speaker {this.name} has changed the name of the lecture to {name}.");
        }
    }
}