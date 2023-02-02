namespace CodeFirstWithExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumnInCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "category_id", c => c.Int());
            CreateIndex("dbo.Courses", "category_id");
            AddForeignKey("dbo.Courses", "category_id", "dbo.Categories", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "category_id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "category_id" });
            DropColumn("dbo.Courses", "category_id");
        }
    }
}
