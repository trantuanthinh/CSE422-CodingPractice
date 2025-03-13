using Lab5.Abstractions;
using Lab5.Model;
using Lab5.Service;

namespace Lab5.Database
{
    internal class Database
    {
        private static Database _instance;
        private static readonly object _lock = new object();

        public List<Document> Documents { get; set; } = new List<Document>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Loan> Loans { get; set; } = new List<Loan>();

        private Database()
        {

        }

        public static Database Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Database();
                    }
                    return _instance;
                }
            }
        }
    }
}