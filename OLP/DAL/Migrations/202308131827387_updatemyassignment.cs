namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemyassignment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyAssignments", "Status", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.MyAssignments", "Stauts");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MyAssignments", "Stauts", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.MyAssignments", "Status");
        }
    }
}
