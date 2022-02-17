namespace DIKUDebate;

public static class Program
{
    public static void Main(string[] args)
    {
        DIKUStudent uffe = new DIKUStudent("Uffe", Preparation.ReadingSome);
        DIKUStudent marianne = new DIKUStudent("Marianne", Preparation.ReadingNone);
        DIKUStudent sonja = new DIKUStudent("Sonja", Preparation.ReadingAll);
        DIKUProfessor boris = new DIKUProfessor("Professor Boris", Preparation.ReadingAll);
        Classroom classroom = new Classroom();

        classroom.Discuss(uffe, marianne);
        classroom.Discuss(sonja, boris);
        classroom.Discuss(marianne, sonja);
    }

}

