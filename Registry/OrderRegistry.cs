using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registry
{
    public class OrderRegistry
    {
        private readonly Dictionary<string, IOrder> _orders = new Dictionary<string, IOrder>();
        public void Register(string key, IOrder order)
        {
            _orders.Add(key, order);
        }

        public bool ContainsKey(string key) => _orders.ContainsKey(key);

        public IOrder this[string key]
        {
            get
            {
                if (!_orders.ContainsKey(key))
                    throw new ArgumentException($"{key} is not registered");
                return _orders[key];
            }
        }
    }
}
