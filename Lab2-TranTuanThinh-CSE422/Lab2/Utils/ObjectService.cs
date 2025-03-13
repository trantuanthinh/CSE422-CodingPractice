namespace Lab2.Utils
{
    public class ObjectService<T> where T : class
    {
        public static bool CheckUniqueId(int id, List<T> list)
        {
            if (list == null) return false;
            foreach (var item in list)
            {
                var itemIdProp = typeof(T).GetProperty("Id");
                if (itemIdProp != null)
                {
                    var itemId = (int)itemIdProp.GetValue(item);
                    if (itemId == id) return false;
                }
            }
            return true;
        }
    }
}
