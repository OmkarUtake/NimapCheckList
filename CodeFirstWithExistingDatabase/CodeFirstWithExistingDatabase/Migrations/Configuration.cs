namespace CodeFirstWithExistingDatabase.Migrations
{
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstWithExistingDatabase.Alldetails>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstWithExistingDatabase.Alldetails context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            context.Authors.AddOrUpdate(a => a.name,
                new Author
                {
                    name = "Smith",
                    Courses = new Collection<Course>()
                    {
                        new Course() {name="MVC",description="DesignApproach", courselevel=2,fullPrice=100}
                    }
                }

                ); ;
        }
    }
}
