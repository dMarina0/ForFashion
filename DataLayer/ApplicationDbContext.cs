using BusinessObjects;
using BusinessObjects.Entities;
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
            modelBuilder.Entity<Dress>().Property(d => d.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Collection>().Property(d => d.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Videos>().Property(l => l.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Chat>().Property(c => c.ConnectionId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Shirt> Shirts { get; set; }

        public DbSet<UserDetails> UserDetails { get; set; }

        public DbSet<Dress> Dresses { get; set; }
        public DbSet<Videos> Videos { get; set; }
        public DbSet<Collection> Collection { get; set; }

        //public DbSet<User> Users { get; set; }
        //public DbSet<UserDetails> UserDetails { get; set; }        
        public DbSet<FashionHouse> FashionHouse { get; set; }
        
        public DbSet<Chat> Chat { get; set; }
    }
}
