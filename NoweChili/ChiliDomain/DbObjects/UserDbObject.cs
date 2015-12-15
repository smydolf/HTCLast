using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ChiliDomain.DbObjects.Interface;

namespace ChiliDomain.DbObjects
{
    
    public class UserDbObject: IEntity
    {
        [Key]
        public int PrimaryKey { get; set; }
        public string UserName { get; set; }
        private bool IsAdmin { get; set; }

    }
}
