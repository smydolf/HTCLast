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
    public class TransportService : Repository<TransportDbObject>, ITransportService
    {
        public TransportService(HtcAplicationContext context) : base(context)
        {
        }

        public List<TransportDbObject> GetAll()
        {
            return Context.Set<TransportDbObject>().ToList();
        }

        public TransportDbObject GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<TransportDbObject>().Find(id);
        }

        public void Update(int Id,TransportDbObject Updatedtransport)
        {
            var existingEntityInBase = GetById(Id);
            if (existingEntityInBase != null)
            {
                existingEntityInBase.TransportName = Updatedtransport.TransportName;
                existingEntityInBase.TransportPrice = Updatedtransport.TransportPrice;
               
            }
            else
            {
                Console.WriteLine("GOWNOOOO");

            }
        }

        public void Delete(TransportDbObject transport)
        {
            if (transport == null)
            {
                throw new ArgumentNullException(nameof(transport));
            }
            base.DeleteEntity(transport);

        }

        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<TransportDbObject>().Remove(toDelete);

        }

        public void AddNew(TransportDbObject transport)
        {
            if (transport == null)
            {
                throw new ArgumentNullException(nameof(transport));
            }
            base.AddEntity(transport);
        }
    }
}
