using Microsoft.VisualBasic;

namespace DIKULecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture lecture = new Lecture("DMA");
            Console.WriteLine(lecture);

            Student a = new Student("Ove", "student", 18);
            Student c = new Student("Tove", "student", 22);
            Student d = new Student("Marie", "student", 30);
            Speaker b = new Speaker("Boris", "teacher", 45);
            a.Join(lecture, "DMA", "Ove");
            c.Join(lecture, "DMA", "Tove");
            d.Join(lecture, "DMA", "Marie");

            b.Broadcast(lecture);
            b.Speak(true);
            b.Rename(lecture, "PoP", "Boris");

            a.Listen();
            c.Listen();
            d.Listen();
            



        }
    }
}






