namespace CodeFirstWithExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryTable1 : DbMigration
    {
        public override void Up()
        {
           // AddColumn("dbo.Categories", "description", c => c.String());
            Sql("UPDATE categories SET description='Framework' where id=1");
        }

        
        

        public override void Down()
        {
            DropColumn("dbo.Categories", "description");
        }
    }
}
