using System.ComponentModel.DataAnnotations;
using ChiliDomain.DbObjects.Interface;

namespace ChiliDomain.DbObjects
{
    
    public class TransportDbObject: IEntity
    {
        [Key]
        public int PrimaryKey { get; set; }
        public string TransportName { get; set; }
        public decimal TransportPrice { get; set; }

        public override string ToString()
        {
            return TransportName + " " + TransportPrice + " zł";
        }
    }
}
