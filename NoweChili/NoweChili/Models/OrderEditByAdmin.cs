using System.Collections.Generic;
using System.Collections.ObjectModel;
using NoweChili.DeAndSerialization;

namespace NoweChili.Models
{
   public  class OrderEditByAdmin
   {
       private List<OrderModel> orderModel { get; set; }
        public  ObservableCollection<OrderModel> OOrderModels { get; set; }
        

       public OrderEditByAdmin()
       {
           orderModel = new List<OrderModel>();
            GetList();
            OOrderModels = new ObservableCollection<OrderModel>(orderModel);
       }
       private void GetList()
       {
           Serialization serialization = new Serialization();
           orderModel = serialization.OrderDeserialization();
       }
    }
}
