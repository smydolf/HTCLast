using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiliDomain.DbObjects.Interface;

namespace ChiliDomain.DbObjects
{
    public class BoxDbObject: IEntity
    {
        public int PrimaryKey { get; set; }

        public string BoxName { get; set; }
        public decimal BoxPrice { get; set; }

        public override string ToString()
        {
            return BoxName + " " + BoxPrice.ToString("N2") + " zł";
        }
    }
}
