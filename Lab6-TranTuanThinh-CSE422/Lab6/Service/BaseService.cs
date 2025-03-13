using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Service
{
    internal class BaseService
    {
        private Dictionary<int, string> _cache = new Dictionary<int, string>();

        public string GetItem(int id)
        {
            if (_cache.ContainsKey(id))
            {
                Console.WriteLine("Fetching from cache...");
                return _cache[id];
            }

            string item = $"Item {id}";
            _cache[id] = item;
            Console.WriteLine("Fetching from cache...");
            return item;
        }
    }
}
