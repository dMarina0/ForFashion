using BusinessObjects;
using BusinessObjects.Entities;
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
            context.Dresses.AddOrUpdate(
               d => d.Id,
               new Dress() { Id = 1, Name = "Floral" },
               new Dress() { Id = 2, Name = "Combined asymetric dress" },
               new Dress() { Id = 3, Name = "Midi dress" },
               new Dress() { Id = 4, Name = "Stripped dress" },
                new Dress() { Id = 5, Name = "Long ribbed dress" },
               new Dress() { Id = 6, Name = "Polka dot dress" },
               new Dress() { Id = 7, Name = "Long stripped dress" },
               new Dress() { Id = 8, Name = "Sleeveless oversized dress" },
                new Dress() { Id = 9, Name = "Flowing dress with ruffled sleeves" },
               new Dress() { Id = 10, Name = "Off-the-shoulder dress" },
               new Dress() { Id = 11, Name = "Oversized dress with fringe" },
               new Dress() { Id = 12, Name = "Combined midi dress" },
                new Dress() { Id = 13, Name = "Constrasting Jacquard Dress" },
               new Dress() { Id = 14, Name = "Shinny ribbed dress" },
               new Dress() { Id = 15, Name = "Checked shirt tunic" },
               new Dress() { Id = 16, Name = "Tulle dress" },
                new Dress() { Id = 17, Name = "Frilled-sleeve dress" },
               new Dress() { Id = 18, Name = "Printed satin dress" },
               new Dress() { Id = 19, Name = "Multicoloured stripped dress" },
               new Dress() { Id = 20, Name = "Denim mini dress" }
               );
            context.SaveChanges();  
            base.Seed(context);

        }
    }
}
 