using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ChiliDomain.DbObjects;

namespace NoweChili.Models
{ 


    public class OrderModel
    {
        [XmlElement("Transport")]
        public TransportDbObject Transport { get; set; }
        [XmlElement("DataZamówienia")]
        public DateTime OrderTime { get; set; }
        [XmlElement("Użytkownik")]
        public LoggedUser User { get; set; }
        [XmlElement("Pudełka")]
        public List<BoxDbObject> Boxes { get; set; }
        [XmlElement("Produkty")]
        public List<ProductDbObject> ProductList { get; set; }
        [XmlElement("Uwagi")]
        public string Comments { get; set; }

        [XmlElement("Suma")]
        public  decimal Total { get; set; } = 0;

        public OrderModel()
        {           
        }
        public OrderModel( TransportDbObject _transport, DateTime _orderTime, LoggedUser _user, List<ProductDbObject> _productList, List<BoxDbObject> _boxList, decimal _total)
        {
            Transport = _transport;
            OrderTime = _orderTime;
            User = _user;
            ProductList = _productList;
            Total = _total;
        }



        //Srednio to działa :D

        //public string ViewList()
        //{
        //    string c = null;
        //    foreach (var variable in ProductList)
        //    {
        //        c = variable.ProductName;

        //    }
        //    return c;
        //}
        //public override string ToString()
        //{
        //    return OrderTime.Date + " " + ViewList() + " " + Total;
        //}
    }
}
