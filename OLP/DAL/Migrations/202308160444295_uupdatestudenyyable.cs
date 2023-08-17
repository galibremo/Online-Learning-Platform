namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uupdatestudenyyable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "NumOfActvCrs", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "NumOfActvCrs");
        }
    }
}
