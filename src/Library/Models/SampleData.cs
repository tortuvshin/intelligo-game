using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Models
{
    public class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Book.Any())
            {
                var austen = context.Author.Add(
                    new Author { LastName = "Austen", FirstMidName = "Jane" }).Entity;
                var dickens = context.Author.Add(
                    new Author { LastName = "Dickens", FirstMidName = "Charles" }).Entity;
                var cervantes = context.Author.Add(
                    new Author { LastName = "Cervantes", FirstMidName = "Miguel" }).Entity;

                context.SaveChanges();
            }
        }
    }
}
