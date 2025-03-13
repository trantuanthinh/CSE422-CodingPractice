using Lab5.Abstractions;

namespace Lab5.Model
{
    internal class Book : Document
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title}");
        }
    }
}
