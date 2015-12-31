namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MojaMigracja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDbObjects",
                c => new
                    {
                        PrimaryKey = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductCode = c.Int(nullable: false),
                        ProductSize = c.Int(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PrimaryKey);
            
            CreateTable(
                "dbo.TransportDbObjects",
                c => new
                    {
                        PrimaryKey = c.Int(nullable: false, identity: true),
                        TransportName = c.String(),
                        TransportPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PrimaryKey);
            
            CreateTable(
                "dbo.UserDbObjects",
                c => new
                    {
                        PrimaryKey = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PrimaryKey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserDbObjects");
            DropTable("dbo.TransportDbObjects");
            DropTable("dbo.ProductDbObjects");
        }
    }
}
