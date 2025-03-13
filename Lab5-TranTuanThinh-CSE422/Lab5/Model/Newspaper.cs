using Lab5.Abstractions;

namespace Lab5.Model
{
    internal class Newspaper : Document
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Newspaper: {Title}");
        }
    }
}
