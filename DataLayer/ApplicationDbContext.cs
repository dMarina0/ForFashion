using BusinessObjects;

using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>("DefaultConnection"));
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity <Shirt> ().Property(s=> s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //modelBuilder.Entity<Shirt>().HasKey(s => s.Id);
           /* modelBuilder.Entity<UserDetails>() .HasKey(e => e.UserID);

            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<User>()
                        .HasOptional(s => s.Details)
                        .WithRequired(a => a.Id);



    */

        }

        public DbSet<Shirt> Shirts { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<UserDetails> UserDetails { get; set; }        
    }
}
