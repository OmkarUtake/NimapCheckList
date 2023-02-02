namespace CodeFirstWithExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);

            Sql("INSERT into Categories VALUES(1,'DotNet')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
