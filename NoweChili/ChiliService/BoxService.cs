using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiliDomain.DbObjects;
using ChiliService.Interface;
using ClassLibrary1;

namespace ChiliService
{
    public class BoxService : Repository<BoxDbObject>, IBoxService
    {
        public BoxService(HtcAplicationContext context) : base(context)
        {
        }

        public List<BoxDbObject> GetAll()
        {
            return Context.Set<BoxDbObject>().ToList();
        }

        public BoxDbObject GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<BoxDbObject>().Find(id);
        }

        public void Update(int Id, BoxDbObject updatedBox)
        {
            var existingEntityInBase = GetById(Id);
            if (existingEntityInBase != null)
            {
                existingEntityInBase.BoxName = updatedBox.BoxName;
                existingEntityInBase.BoxPrice = updatedBox.BoxPrice;
                SaveChange();
            }
            else
            {
                Console.WriteLine("GOWNO");
            }
        }

        public void Delete(BoxDbObject box)
        {
            if (box == null)
            {
                throw new ArgumentNullException(nameof(box));
            }
            base.DeleteEntity(box);

        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<BoxDbObject>().Remove(toDelete);

        }

        public void AddNew(BoxDbObject box)
        {
            if (box == null)
            {
                throw new ArgumentNullException(nameof(box));
            }
            base.AddEntity(box);
        }
    }
}

