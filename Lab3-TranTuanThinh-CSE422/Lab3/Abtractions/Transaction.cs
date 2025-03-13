using Lab3.Objects;
using System.Threading.Channels;

namespace Lab3.Abtractions
{
    internal abstract class Transaction
    {
        public string TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public Member Member { get; set; }

        public abstract void Execute();
    }
}
