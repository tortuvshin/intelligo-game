using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itera.Fagdag.November.Domain.Models;

namespace Itera.Fagdag.November.Data
{
    public static class SeedData
    {
        public static void SeedBooks(IteraLibraryDbContext dbContext)
        {
            dbContext.Books.Add(new Book
            {
                BookId = 1,
                Author = "Robert C. Martin",
                Title = "Clean Code",
                Description = "Even bad code can function. But if code isn’t clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn’t have to be that way. Noted software expert Robert C. Martin presents a revolutionary paradigm with Clean Code: A Handbook of Agile Software Craftsmanship. Martin has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code “on the fly” into a book that will instill within you the values of a software craftsman and make you a better programmer—but only if you work at it. What kind of work will you be doing? You’ll be reading code—lots of code. And you will be challenged to think about what’s right about that code, and what’s wrong with it. More importantly, you will be challenged to reassess your professional values and your commitment to your craft.",
                CoverImageUrl = "~/Resources/Uploads/CleanCode.jpg",
                Language = "English",
                Pages = 464,
                ISBN10 = "0132350882",
                ISBN13 = "978-0132350884"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 2,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 3,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });


            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });

            dbContext.Books.Add(new Book
            {
                BookId = 4,
                Author = "Roy Osherove",
                Title = "The Art of Unit Testing",
                Description = "Developers know they \"should\" be unit testing, but it can be intimidating and tedious, and they don't always see the payoff for the effort they put into it. The Art of Unit Testing, Second Edition is a step-by-step guide that helps reluctant developers learn how to write simple tests and leads them through developing robust test sets that are maintainable, readable, and trustworthy. Readers will explore test patterns and organization, working with legacy code, and even \"untestable\" code. Along the way, they'll learn about integration testing and techniques and tools for testing databases and other technologies.",
                CoverImageUrl = "~/Resources/Uploads/TheArtOfUnitTesting.jpg",
                Language = "English",
                Pages = 375,
                ISBN10 = "1617290890",
                ISBN13 = "978-1617290893"
            });
        }
    }
}