namespace MultipleClassesEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        courselevel = c.Int(nullable: false),
                        fullPrice = c.Single(nullable: false),
                        authod_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Authors", t => t.authod_id)
                .Index(t => t.authod_id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TagCourses",
                c => new
                    {
                        Tag_id = c.Int(nullable: false),
                        Course_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_id, t.Course_id })
                .ForeignKey("dbo.Tags", t => t.Tag_id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_id, cascadeDelete: true)
                .Index(t => t.Tag_id)
                .Index(t => t.Course_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagCourses", "Course_id", "dbo.Courses");
            DropForeignKey("dbo.TagCourses", "Tag_id", "dbo.Tags");
            DropForeignKey("dbo.Courses", "authod_id", "dbo.Authors");
            DropIndex("dbo.TagCourses", new[] { "Course_id" });
            DropIndex("dbo.TagCourses", new[] { "Tag_id" });
            DropIndex("dbo.Courses", new[] { "authod_id" });
            DropTable("dbo.TagCourses");
            DropTable("dbo.Tags");
            DropTable("dbo.Courses");
            DropTable("dbo.Authors");
        }
    }
}
