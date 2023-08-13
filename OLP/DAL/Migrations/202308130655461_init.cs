namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Student_Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Students", "Student_Name", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
