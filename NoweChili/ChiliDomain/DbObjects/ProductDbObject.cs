using System.ComponentModel.DataAnnotations;
using ChiliDomain.DbObjects.Interface;

namespace ChiliDomain.DbObjects
{
    
    public class ProductDbObject: IEntity
    { 
       
        public string ProductName { get; set; }
        public int ProductCode { get; set; }
        public int ProductSize { get; set; }
        public decimal ProductPrice { get; set; }

        [Key]
        public int PrimaryKey { get; set; }
        public override string ToString()
        {
            return PrimaryKey + " " + ProductName + " " + ProductSize + " " + ProductPrice;
        }
    }
}
