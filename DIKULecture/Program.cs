using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace DIKULecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsAtLecture = new List<Student>()
            {
               new Student("Ove", "student", 18),
               new Student("Tove", "student", 22),
               new Student("Marie", "student", 30),
               new Student("Carla", "student", 18),
               new Student("Emil", "student", 26),
               new Student("Waldemar", "student", 18),
            };
            
            Lecture lecture = new("DMA");
            Lecture lectureTwo = new("PoP");
            Console.WriteLine(lecture);

            Student a = new("Ove", "student", 18);
            Student c = new("Tove", "student", 22);
            Student d = new("Marie", "student", 30);
            Student e = new("Carla", "student", 18);
            Student f = new("Emil", "student", 26);
            Student g = new("Waldemar", "student", 18);
            
            Speaker b = new("Boris", "teacher", 45);
            
            a.Join(lecture, "DMA", "Ove", studentsAtLecture);
            c.Join(lecture, "DMA", "Tove", studentsAtLecture);
            d.Join(lecture, "DMA", "Marie", studentsAtLecture);
            e.Join(lecture, "DMA", "Carla", studentsAtLecture);
            f.Join(lecture, "DMA", "Emil", studentsAtLecture);
            g.Join(lecture, "DMA", "Waldemar", studentsAtLecture);
            
            b.Broadcast(lecture);
            b.Speak(true);
            b.Rename(lecture, "PoP", "Boris");

            a.Listen();
            c.Listen();
            d.Listen();
            e.Listen();
            f.Listen();
            g.Listen();
        }
    }
}






