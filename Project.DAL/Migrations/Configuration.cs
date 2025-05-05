namespace Project.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Project.ENTITIES.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Project.DAL.ContextClasses.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Project.DAL.ContextClasses.MyContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(new List<Category>
        {
            new Category { CategoryName = "Fiction" },
            new Category { CategoryName = "Science" },
            new Category { CategoryName = "History" },
            new Category { CategoryName = "Technology" },
            new Category { CategoryName = "Philosophy" }
        });
                context.SaveChanges();
            }
            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
