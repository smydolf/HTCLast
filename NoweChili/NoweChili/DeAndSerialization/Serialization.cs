using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Xml.Linq;
using System.Xml.Serialization;
using NoweChili.Models;

namespace NoweChili.DeAndSerialization
{
    public class Serialization
    {
        public List<OrderModel> orderModetListTOSerialize { get; set; }
    


        public Serialization()
        {
            orderModetListTOSerialize = new List<OrderModel>();

        }

        public void OrderSerialization(OrderModel order)
        {


            // To się przyda do zapisywania całego obiektu listy po usunięciu jakiegoś elementu.

            //string path = @"C:\Orders\Orders.xml";
            //XmlSerializer oSerializer = new XmlSerializer(typeof(List<OrderModel>));
            //StreamWriter fileStream = new StreamWriter(path, true);

            //try
            //{
            //    oSerializer.Serialize(fileStream, orderModetListTOSerialize);
            //}
            //catch (Exception oException)
            //{
            //    Console.WriteLine("Aplikacja wygenerowała następujący wyjątek: " + oException.Message);
            //}
            //finally
            //{
            //    if (null != fileStream)
            //    {
            //        fileStream.Close();
            //    }
            //
            //}
      

            orderModetListTOSerialize.Add(order);
            if (!File.Exists(@"c:\Orders\Orders.xml"))
            {
                XDocument documentXML = new XDocument(
                    new XDeclaration("1.0", "utf-8", "no"),

                    new XElement("ArrayOfOrderModel",
                    new XElement("OrderModel",                   
                        from c in orderModetListTOSerialize
                        select new XElement("Transport",
                        new XElement("PrimaryKey", c.Transport.PrimaryKey),
                        new XElement("TransportName", c.Transport.TransportName),
                        new XElement("TransportPrice", c.Transport.TransportPrice)),
                         from c in orderModetListTOSerialize
                         from d in c.ProductList
                        select new XElement("Produkty",
                            new XElement("ProductName", d.ProductName),
                                new XElement("ProductCode", d.ProductCode),
                            new XElement("ProductSize", d.ProductSize),
                            new XElement("ProductPrice", d.ProductSize),
                            new XElement("PrimaryKey", d.PrimaryKey)),
                         from c in orderModetListTOSerialize
                            select new XElement("Użytkownik",
                            new XElement("loggedDbUserName", c.User.loggedDbUserName),
                            new XElement("LogedDateTime", c.User.LogedDateTime)),
                            new XElement("DataZamówienia", order.OrderTime),
                            new XElement("Suma", order.Total)
                            )));
                documentXML.Save(@"c:\Orders\Orders.xml");
            }
            else
            {
                XDocument loadFromDisk = XDocument.Load(@"c:\Orders\Orders.xml");
                 XElement root = loadFromDisk.Root;
                if (root != null)
                {
                    root.Add(new XElement("OrderModel",
                        from c in orderModetListTOSerialize
                        select new XElement("Transport",
                        new XElement("PrimaryKey", c.Transport.PrimaryKey),
                        new XElement("TransportName", c.Transport.TransportName),
                        new XElement("TransportPrice", c.Transport.TransportPrice)),
                         from c in orderModetListTOSerialize
                         from d in c.ProductList
                         select new XElement("Produkty",
                             new XElement("ProductName", d.ProductName),
                                 new XElement("ProductCode", d.ProductCode),
                             new XElement("ProductSize", d.ProductSize),
                             new XElement("ProductPrice", d.ProductSize),
                             new XElement("PrimaryKey", d.PrimaryKey)),
                         from c in orderModetListTOSerialize
                         select new XElement("Użytkownik",
                         new XElement("loggedDbUserName", c.User.loggedDbUserName),
                         new XElement("LogedDateTime", c.User.LogedDateTime)),
                            new XElement("DataZamówienia", order.OrderTime),
                            new XElement("Suma", order.Total)
                            ));
                }
                loadFromDisk.Save(@"c:\Orders\Orders.xml");
            }
        }
        public List<OrderModel> OrderDeserialization()
        {
            string path = @"c:\Orders\Orders.xml";        
            XmlSerializer serializer = new XmlSerializer(typeof(List<OrderModel>));
            StreamReader reader = new StreamReader(path);
            return (List<OrderModel>)serializer.Deserialize((reader));
        }
    }

 
}
