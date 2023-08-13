namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inittables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        created = c.DateTime(nullable: false),
                        cid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Courses", t => t.cid, cascadeDelete: false)
                .Index(t => t.cid);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        created = c.DateTime(nullable: false),
                        description = c.String(),
                        tid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Teachers", t => t.tid, cascadeDelete: false)
                .Index(t => t.tid);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        email = c.String(),
                        password = c.String(),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.MyAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Deadline = c.DateTime(nullable: false),
                        TsrId = c.Int(nullable: false),
                        CrsId = c.Int(nullable: false),
                        StuId = c.Int(nullable: false),
                        Stauts = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CrsId, cascadeDelete: false)
                .ForeignKey("dbo.Students", t => t.StuId, cascadeDelete: false)
                .ForeignKey("dbo.Teachers", t => t.TsrId, cascadeDelete: false)
                .Index(t => t.TsrId)
                .Index(t => t.CrsId)
                .Index(t => t.StuId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Student_Id = c.Int(nullable: false, identity: true),
                        Student_Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        DOB = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Student_Id);
            
            CreateTable(
                "dbo.MyCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 100),
                        EnrDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 100),
                        StuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StuId, cascadeDelete: false)
                .Index(t => t.StuId);
            
            CreateTable(
                "dbo.MySubmissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubmitDate = c.DateTime(nullable: false),
                        CourseContent = c.String(nullable: false, maxLength: 100),
                        AssId = c.Int(nullable: false),
                        Status = c.String(nullable: false, maxLength: 100),
                        StuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MyAssignments", t => t.AssId, cascadeDelete: false)
                .ForeignKey("dbo.Students", t => t.StuId, cascadeDelete: false)
                .Index(t => t.AssId)
                .Index(t => t.StuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyAssignments", "TsrId", "dbo.Teachers");
            DropForeignKey("dbo.MySubmissions", "StuId", "dbo.Students");
            DropForeignKey("dbo.MySubmissions", "AssId", "dbo.MyAssignments");
            DropForeignKey("dbo.MyAssignments", "StuId", "dbo.Students");
            DropForeignKey("dbo.MyCourses", "StuId", "dbo.Students");
            DropForeignKey("dbo.MyAssignments", "CrsId", "dbo.Courses");
            DropForeignKey("dbo.Contents", "cid", "dbo.Courses");
            DropForeignKey("dbo.Courses", "tid", "dbo.Teachers");
            DropIndex("dbo.MySubmissions", new[] { "StuId" });
            DropIndex("dbo.MySubmissions", new[] { "AssId" });
            DropIndex("dbo.MyCourses", new[] { "StuId" });
            DropIndex("dbo.MyAssignments", new[] { "StuId" });
            DropIndex("dbo.MyAssignments", new[] { "CrsId" });
            DropIndex("dbo.MyAssignments", new[] { "TsrId" });
            DropIndex("dbo.Courses", new[] { "tid" });
            DropIndex("dbo.Contents", new[] { "cid" });
            DropTable("dbo.MySubmissions");
            DropTable("dbo.MyCourses");
            DropTable("dbo.Students");
            DropTable("dbo.MyAssignments");
            DropTable("dbo.Teachers");
            DropTable("dbo.Courses");
            DropTable("dbo.Contents");
        }
    }
}
