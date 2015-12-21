using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiliDomain.DbObjects;

namespace NoweChili.Models
{
    public class OrderModel
    {
        public TransportDbObject Transport { get; set; }
        public DateTime OrderTime { get; set; }
        public UserDbObject User { get; set; }
        public List<ProductDbObject> ProductList { get; set; }
        public static decimal Total { get; set; } = 0;

        public OrderModel( TransportDbObject _transport, DateTime _orderTime, UserDbObject _user, List<ProductDbObject> _productList, decimal _total)
        {
            Transport = _transport;
            OrderTime = _orderTime;
            User = _user;
            ProductList = _productList;
            Total = _total;


        }

        
    }
}
