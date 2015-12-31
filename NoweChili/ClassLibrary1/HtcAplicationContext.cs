using System.Data.Entity;
using ChiliDomain.DbObjects;

namespace ClassLibrary1
{
    public class HtcAplicationContext :DbContext
    {
        public DbSet<ProductDbObject> ProductDbObjects { get; set; }
        public DbSet<TransportDbObject> TransportDbObjects { get; set; }
        public DbSet<UserDbObject> UserDbObjects { get; set; }
        public DbSet<BoxDbObject> BoxDbObjects { get; set; }
    }
}
