using System;

namespace Semester_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Luna Library");
            Book dl = new Book("Deep Learning", "Yoshua Bengio", "1008");
            Book ml = new Book("Machine Learning", "Drew Conway", "1808");
            Game lol = new Game("LoL", "Rito", "9");
            Game hs = new Game("Hearthstone", "Blizzard", "9");
            library.AddResource(ml);
            library.AddResource(dl);
            library.AddResource(lol);
            library.AddResource(hs);
            ml.OnLoan = true;
            lol.OnLoan = true;
            Console.WriteLine(library.HasResource("Deep Learning"));
            Console.WriteLine(library.HasResource("LoL"));

        }
    }
}
