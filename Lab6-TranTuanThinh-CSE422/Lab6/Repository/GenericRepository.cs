public class GenericBaseController<T> where T : new()
{
    private readonly SqlConnection _connection;

    public GenericBaseController(SqlConnection connection)
    {
        _connection = connection;
    }

    public List<T> GetAll(string tableName, Func<SqlDataReader, T> mapFunction)
    {
        var resultList = new List<T>();
        var command = new SqlCommand($"SELECT * FROM {tableName}", _connection);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            resultList.Add(mapFunction(reader));
        }
        return resultList;
    }
}
