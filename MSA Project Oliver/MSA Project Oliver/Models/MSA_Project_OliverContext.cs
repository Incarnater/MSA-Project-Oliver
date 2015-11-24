using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace MSA_Project_Oliver.Models
{
    public class MSA_Project_OliverContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public class MyConfiguration : DbMigrationsConfiguration<MSA_Project_OliverContext>
        {
            public MyConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;
            }

            protected override void Seed(MSA_Project_OliverContext context)
            {
                var specials = new List<Special>
            {
                new Special { ID = 1,   Name = "Flame-grilled Chicken(Half)", Description = "Our signature flame grilled chicken, half size", Price = 10.00},
                new Special { ID = 2,   Name = "Flame-grilled Chicken(Whole)", Description = "Our signature flame grilled chicken, whole size", Price = 20.00},
                new Special { ID = 3,   Name = "Classic Chicken Burger", Description = "Flame grilled chicken in a delicious burger", Price = 16.00},
                new Special { ID = 4,   Name = "BBQ Wings", Description = "Chicken on the bone", Price = 12.00},
                new Special { ID = 5,   Name = "Chicken Pita", Description = "Chicken all wrapped in a pita", Price = 13.50},
                new Special { ID = 6,   Name = "Salad", Description = "It's pure salad, no meat.", Price = 9.00},
                new Special { ID = 7,   Name = "Chicken Salad", Description = "Now we're talking", Price = 14.00},

            };
                specials.ForEach(s => context.Specials.AddOrUpdate(p => p.ID, s));
                context.SaveChanges();
            }

        }

        public MSA_Project_OliverContext() : base("name=MSA_Project_OliverContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSA_Project_OliverContext, MyConfiguration>());
        }

        public System.Data.Entity.DbSet<MSA_Project_Oliver.Models.Special> Specials { get; set; }
        public IQueryable<Special> Special { get; internal set; }
    }
}
