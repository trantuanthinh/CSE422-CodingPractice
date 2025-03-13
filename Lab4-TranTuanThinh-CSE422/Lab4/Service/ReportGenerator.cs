using Lab4.IModel;

namespace Lab4.Model
{
    internal class ReportGenerator : IReportGenerator
    {
        private IReaderRepository _readerRepository;

        public ReportGenerator(IReaderRepository readerRepository)
        {
            _readerRepository = readerRepository;
        }

        public void GenerateReport(int readerId)
        {
            var reader = _readerRepository.GetReaderById(readerId);
            if (reader != null)
            {
                Console.WriteLine($"Report for Reader: {reader.Name}");
                Console.WriteLine("Books Borrowed:");
                foreach (var book in reader.BorrowedBooks)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author}");
                }
            }
            else
            {
                Console.WriteLine("Reader not found.");
            }
        }
    }
}
