namespace CodeFirstWithExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateColumnAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "date", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "date");
        }
    }
}
