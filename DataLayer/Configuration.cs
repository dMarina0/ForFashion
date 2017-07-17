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
               new Shirt() {  Id = 1, Name = "Floral print shirt"},
               new Shirt() {  Id = 2, Name = " Striped shirt"},
               new Shirt() { Id = 3, Name = "Top with bow"},
               new Shirt() { Id = 4, Name = "Shirt with back bows" },
               new Shirt() { Id = 5, Name = "Frilled shirt" },
               new Shirt() { Id = 6, Name = "Cropped shirt" },
               new Shirt() { Id = 7, Name = "Poplin shirt" },
                new Shirt() { Id = 8, Name = "Short shirt whith embroideries" },
               new Shirt() { Id = 9, Name = "Tropical print shirt" },
               new Shirt() { Id = 10, Name = "Constrast shirt" },
               new Shirt() { Id = 11, Name = "Asymetric cut out shirt" }, 
               new Shirt() { Id = 12, Name = "Oversized shirt" },
               new Shirt() { Id = 13, Name = " Tulle shirt" },
               new Shirt() { Id = 14, Name = "Off the shoulder shirt" },
                new Shirt() { Id = 15, Name = "Check shirt with frill" },
               new Shirt() { Id = 16, Name = "Denim shirt" },
               new Shirt() { Id = 17, Name = "Double layered shirt" },
               new Shirt() { Id = 18, Name = "Kimono blouse" },
                new Shirt() { Id = 19, Name = "Halter neck top" },
               new Shirt() { Id = 20, Name = "Polka dot shirt" },
               new Shirt() { Id = 21, Name = "Shirt with pearl details" },
               new Shirt() { Id = 22, Name = "Velvet top" },
               new Shirt() { Id = 23,Name = "Blouse with hood"},
               new Shirt() { Id = 24, Name = "Frilled sateen blouse"},
               new Shirt() { Id = 25, Name = "V-neck chocker shirt"},
               new Shirt() { Id = 26, Name = "Metallic button overshirt"},
               new Shirt() { Id = 27, Name = "Faux suede top"},
               new Shirt() { Id = 28, Name = "Pearly shirt"},
               new Shirt() { Id = 29, Name = "Cats print shirt"},
               new Shirt() { Id = 30, Name = "High-neck blouse"}
               );
            context.SaveChanges();  
            base.Seed(context);
            context.Database.ExecuteSqlCommand("ALTER TABLE Users ADD CONSTRAINT Details UNIQUE(DetailsID)");
            
        }
    }
    
}
 