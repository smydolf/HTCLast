namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaswordToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserDbObjects", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserDbObjects", "Password");
        }
    }
}
