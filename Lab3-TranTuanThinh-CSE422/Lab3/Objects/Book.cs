using Lab3.Interfaces;

namespace Lab3.Objects
{
    internal class Book : IPrintable
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        private int _year;
        private int _copiesAvailable;
        public int Year
        {
            get => _year;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Year cannot be negative.");
                _year = value;
            }
        }
        public int CopiesAvailable
        {
            get => _copiesAvailable; set
            {
                if (value < 0)
                    throw new ArgumentException("CopiesAvailable cannot be less than 0.");
                _copiesAvailable = value;
            }
        }

        public Book() { }
        public Book(string isbn, string title, string author, int year, int copiesAvailable)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = year;
            CopiesAvailable = copiesAvailable;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Copies Available: {CopiesAvailable}");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Book Details:");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Copies Available: {CopiesAvailable}");
        }
    }
}
