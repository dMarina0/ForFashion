using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //ContextKey = "DataLayer.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {

            context.Shirts.AddOrUpdate(
               s => s.Id,
               new Shirt() { Id = 4, Name = "ff" });
            context.SaveChanges();  
            base.Seed(context);

        }
    }
}
