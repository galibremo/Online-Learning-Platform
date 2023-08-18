namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatewatchlist1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WatchLists", "CourseStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WatchLists", "CourseStatus", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
