namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnableAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserDbObjects", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserDbObjects", "IsAdmin");
        }
    }
}
