namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateWatchlist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WatchLists", "MyCrsId", c => c.Int(nullable: false));
            CreateIndex("dbo.WatchLists", "MyCrsId");
            AddForeignKey("dbo.WatchLists", "MyCrsId", "dbo.MyCourses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WatchLists", "MyCrsId", "dbo.MyCourses");
            DropIndex("dbo.WatchLists", new[] { "MyCrsId" });
            DropColumn("dbo.WatchLists", "MyCrsId");
        }
    }
}
