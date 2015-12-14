using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiliDomain.DbObjects;

namespace ChiliService.Interface
{
    public interface IProductService
    {
        List<ProductDbObject> GetAll();
        ProductDbObject GetById(int id);
        void Update(ProductDbObject product);
        void Delete(ProductDbObject product);
        void DeleteById(int id);
        void AddNew(ProductDbObject product);
    }
}
