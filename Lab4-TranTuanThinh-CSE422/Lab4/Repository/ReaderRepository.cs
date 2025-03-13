using Lab4.IModel;

namespace Lab4.Model
{
    internal class ReaderRepository : IReaderRepository
    {
        private List<IReader> _readers = new List<IReader>();

        public void AddReader(IReader reader)
        {
            _readers.Add(reader);
        }

        public IReader GetReaderById(int readerId)
        {
            return _readers.FirstOrDefault(r => r.ReaderId == readerId);
        }
    }
}
