namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateStudenttable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Username", c => c.String(maxLength: 15));
            AddColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Students", "UserType", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "UserType");
            DropColumn("dbo.Students", "Password");
            DropColumn("dbo.Students", "Username");
        }
    }
}
