using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ChiliDomain.DbObjects;
using ChiliService.Interface;
using ClassLibrary1;

namespace ChiliService
{
    public class ProductService : Repository<ProductDbObject>, IProductService
    {
        public ProductService(HtcAplicationContext context) : base(context)
        {
        }

        public List<ProductDbObject> GetAll()
        {
            return Context.Set<ProductDbObject>().ToList();
        }

        public ProductDbObject GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<ProductDbObject>().Find(id);
        }

        public void Update(int Id, ProductDbObject updatedProduct)
        {
            var existingEntityInBase = GetById(Id);
            if (existingEntityInBase != null)
            {
                existingEntityInBase.ProductCode = updatedProduct.ProductCode;
                existingEntityInBase.ProductName = updatedProduct.ProductName;
                existingEntityInBase.ProductPrice = updatedProduct.ProductPrice;
                existingEntityInBase.ProductSize = updatedProduct.ProductSize;
                SaveChange();
            }
            else
            {
               Console.WriteLine("GOWNO");
            }
        }

        public void Delete(ProductDbObject product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            base.DeleteEntity(product);

        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<ProductDbObject>().Remove(toDelete);

        }

        public void AddNew(ProductDbObject product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            base.AddEntity(product);
        }
    }
}
