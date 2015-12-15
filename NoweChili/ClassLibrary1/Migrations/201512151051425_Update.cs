namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserDbObjects", "IsAdmin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserDbObjects", "IsAdmin", c => c.Boolean(nullable: false));
        }
    }
}
