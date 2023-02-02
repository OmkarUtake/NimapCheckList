namespace CrudOperation.Migrations
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
                        name = c.String(nullable: false),
                        description = c.String(nullable: false),
                        myitem_itemid = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Items", t => t.myitem_itemid)
                .Index(t => t.myitem_itemid);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        itemid = c.Int(nullable: false, identity: true),
                        item = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.itemid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "myitem_itemid", "dbo.Items");
            DropIndex("dbo.Categories", new[] { "myitem_itemid" });
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
        }
    }
}
