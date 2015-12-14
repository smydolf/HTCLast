using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiliDomain.DbObjects;

namespace ChiliService.Interface
{
    public interface ITransportService
    {
        List<TransportDbObject> GetAll();
        TransportDbObject GetById(int id);
        void Update(TransportDbObject transport);
        void Delete(TransportDbObject transport);
        void DeleteById(int id);
        void AddNew(TransportDbObject transport);
    }
}
