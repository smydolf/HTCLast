using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ChiliDomain.DbObjects;
using ChiliService.Interface;
using ClassLibrary1;

namespace ChiliService
{
    public class UserService : Repository<UserDbObject>, IUserService
    {
        public UserService(HtcAplicationContext context) : base(context)
        {
        }

        public List<UserDbObject> GetAll()
        {
            return Context.Set<UserDbObject>().ToList();
        }

        public UserDbObject GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return Context.Set<UserDbObject>().Find(id);
        }

        public UserDbObject GetUserByName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            return Context.Set<UserDbObject>().FirstOrDefault(o => o.UserName == name);
        }

        public void Update(int Id, UserDbObject Updateuser)
        {
            var existingEntityInBase = GetById(Id);
            if (existingEntityInBase != null)
            {
                existingEntityInBase.UserName = Updateuser.UserName;
                SaveChange();
            }
            else
            {
                Console.WriteLine("GOWNOOOO");
            }
        }
        public void Delete(UserDbObject user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            base.DeleteEntity(user);
        }
        public void DeleteById(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
            {
                throw new ArgumentNullException(nameof(toDelete));
            }
            Context.Set<UserDbObject>().Remove(toDelete);

        }

        public void AddNew(UserDbObject user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            base.AddEntity(user);
        }
    }
}
