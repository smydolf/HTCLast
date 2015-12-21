using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Documents;
using ChiliDomain.DbObjects;
using NoweChili.Annotations;

namespace NoweChili.Models
{
    public class ProductModel 

    {
        private static List<ProductDbObject> ProductDbObjects { get; set; }
        public ObservableCollection<ProductDbObject> OProductDbObjects { get; set; }
   
        public ProductModel()
        {
            ProductDbObjects = new List<ProductDbObject>();
            ProductDbObjects = Services.productService.GetAll();
            OProductDbObjects = new ObservableCollection<ProductDbObject>(ProductDbObjects);

        }
   
    }
}
