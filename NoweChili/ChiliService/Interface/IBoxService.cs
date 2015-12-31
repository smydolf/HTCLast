using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiliDomain.DbObjects;

namespace ChiliService.Interface
{
    public interface IBoxService
    {
        List<BoxDbObject> GetAll();
        BoxDbObject GetById(int id);
        void Update(int Id, BoxDbObject updatedBox);
        void Delete(BoxDbObject box);
        void DeleteById(int id);
        void AddNew(BoxDbObject box);
    }
}
