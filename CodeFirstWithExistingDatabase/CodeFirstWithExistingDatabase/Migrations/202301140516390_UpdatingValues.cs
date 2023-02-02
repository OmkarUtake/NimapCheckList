namespace CodeFirstWithExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingValues : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE categories SET description='Framework' where id=1");
        }
        
        public override void Down()
        {
        }
    }
}
