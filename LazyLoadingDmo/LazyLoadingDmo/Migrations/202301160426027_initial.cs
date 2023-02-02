namespace LazyLoadingDmo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        course1 = c.String(),
                        course2 = c.String(),
                        course3 = c.String(),
                        course4 = c.String(),
                        Students_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Students", t => t.Students_id)
                .Index(t => t.Students_id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Students_id", "dbo.Students");
            DropIndex("dbo.Courses", new[] { "Students_id" });
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
