using System.ComponentModel.DataAnnotations;

namespace ChiliDomain.DbObjects.Interface
{
    public interface IEntity
    {
        [Key]
        int PrimaryKey { get; set; }
    }
}
