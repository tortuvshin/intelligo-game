using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Itera.Fagdag.November.Domain.Models;

namespace Itera.Fagdag.November.Data
{
    public class IteraLibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            // Add any configuration or mapping stuff here

            //modelBuilder.Entity<Cart>().HasMany(c => c.CartBooks).WithOptional().Map(m => m.MapKey("CartBookId"));
        }

        public void Seed(IteraLibraryDbContext dbContext)
        {
            #if DEBUG
            // Create my debug (testing) objects here
            #endif
            // Normal seeding goes here
            SeedData.SeedBooks(dbContext);
        }

        public class DropCreateAlwaysInitializer : DropCreateDatabaseAlways<IteraLibraryDbContext>
        {
            protected override void Seed(IteraLibraryDbContext dbContext)
            {
                dbContext.Seed(dbContext);

                base.Seed(dbContext);
            }
        }

        public class DropCreateIfChangeInitializer : DropCreateDatabaseIfModelChanges<IteraLibraryDbContext>
        {
            protected override void Seed(IteraLibraryDbContext dbContext)
            {
                dbContext.Seed(dbContext);

                base.Seed(dbContext);
            }
        }

        public class CreateInitializer : CreateDatabaseIfNotExists<IteraLibraryDbContext>
        {
            protected override void Seed(IteraLibraryDbContext dbContext)
            {
                dbContext.Seed(dbContext);

                base.Seed(dbContext);
            }
        }

        static IteraLibraryDbContext()
        {
            #if DEBUG
            //Database.SetInitializer(new DropCreateAlwaysInitializer());
            Database.SetInitializer(new DropCreateIfChangeInitializer());
            #else
            Database.SetInitializer(new CreateInitializer());
            #endif
        }
    }
}