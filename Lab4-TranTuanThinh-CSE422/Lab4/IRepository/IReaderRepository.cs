namespace Lab4.IModel
{
    public interface IReaderRepository
    {
        void AddReader(IReader reader);
        IReader GetReaderById(int readerId);
    }
}
