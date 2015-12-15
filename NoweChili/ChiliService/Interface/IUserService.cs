using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiliDomain.DbObjects;

namespace ChiliService.Interface
{
    public interface IUserService
    {
        List<UserDbObject> GetAll();
        UserDbObject GetById(int id);
        void Update(int Id, UserDbObject Updateuser);
        void Delete(UserDbObject user);
        void DeleteById(int id);
        void AddNew(UserDbObject user);
    }
}
