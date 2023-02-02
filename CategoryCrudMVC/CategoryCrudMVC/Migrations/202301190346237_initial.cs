namespace CategoryCrudMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        categoryName = c.String(nullable: false),
                        item_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Items", t => t.item_id)
                .Index(t => t.item_id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        description = c.String(nullable: false),
                        itemName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "item_id", "dbo.Items");
            DropIndex("dbo.Categories", new[] { "item_id" });
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
        }
    }
}
