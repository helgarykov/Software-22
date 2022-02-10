using Microsoft.VisualBasic;

namespace DIKULecture;

public class Person : Lecture
{
    private protected string name;
    private string occupation;
    private int age;

    public Person(string name, string occupation, int age, bool information)
    {
        this.name = name;
        this.occupation = occupation;
        this.age = age;
        this.information = information;
    }
}

public class Student : Person
{
    private bool isInLecture = false;
    private Lecture lecture;

    public void Join(Lecture lecture)
    {
        if (isInLecture == false)
        {
            this.lecture = lecture;
            isInLecture = true;
        }
        else
        {
            this.lecture = null;
            isInLecture = false;
        }
    }
    public void Listen(Lecture lecture, bool information)
    {
        if (isInLecture == false)
        {
            this.lecture = lecture;
            this.information = true;
            Console.WriteLine($"This student is currently listening to {this.lecture}.");
        }
        else
        {
            this.lecture = null;
            this.information = false;
            Console.WriteLine($"The student is not listening to {this.lecture}.");
        }
    }
}

public class Speaker : Person
{
    private bool isInLecture = false;
    private Lecture lecture;

    public void Broadcast(Lecture lecture, bool information)
    {
        if (isInLecture == false)
        {
            this.lecture = lecture;
            this.information = true;
            Console.WriteLine($"Speaker is speaking at: {this.lecture}.");
        }
        else
        {
            this.lecture = null;
            this.information = false;
            Console.WriteLine($"Speaker is not speaking at: {this.lecture}.");
        }
    }

    public void Speak(string name, Lecture lecture, bool information)
    {
        if (isInLecture == false)
        {
            this.lecture = lecture;
            this.name = name;
            Console.WriteLine($"Speaker begins a {this.lecture} called {this.name}");
        }
    }
}