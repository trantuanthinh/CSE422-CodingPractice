using Lab5.Abstractions;

namespace Lab5.Model
{
    internal class Magazine : Document
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine: {Title}");
        }
    }
}
