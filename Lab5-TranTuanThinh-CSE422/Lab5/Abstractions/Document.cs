namespace Lab5.Abstractions
{
    internal abstract class Document
    {
        public string Title { get; set; }
        public abstract void DisplayInfo();
    }
}
