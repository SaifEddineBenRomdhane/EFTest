using System.Collections.ObjectModel;

namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFTest.EFTestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFTest.EFTestContext context)
        {
            context.Authors.AddOrUpdate(a => a.Name,
                new Author { 
                    Name="Author 1",
                    Courses = new Collection<Course>()
                    {
                        new Course(){Name = "Course For Author  1",Description = "Description"}
                    }
                });
        }
    }
}
