using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogFullStack.Server.Models;

namespace BlogFullStack.Server.Data
{
    public class BlogFullStackServerContext : DbContext
    {
        public BlogFullStackServerContext (DbContextOptions<BlogFullStackServerContext> options)
            : base(options)
        {
        }

        public DbSet<BlogFullStack.Server.Models.BusinessContactDetails> BusinessContactDetails { get; set; } = default!;
        public DbSet<BlogFullStack.Server.Models.DynamicContent> DynamicContent { get; set; } = default!;
        public DbSet<BlogFullStack.Server.Models.FeedbackData> FeedbackData { get; set; } = default!;
        public DbSet<BlogFullStack.Server.Models.StaticContent> StaticContent { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BusinessContactDetails>().HasData(

                new BusinessContactDetails
                {
                    BusinessContactID = 1,

                    BusinessContactPhoneNumber = "(360) 123-4567",

                    BusinessContactEmail = "VeryRealCo@RealMail.io",

                    BusinessName = "ToastCo",

                    BusinessAddress = "308 Negra Arroyo Lane, Albuquerque, New Mexico"

                },
                new BusinessContactDetails
                {
                    BusinessContactID = 2,

                    BusinessContactPhoneNumber = "(360) 123-4567",

                    BusinessContactEmail = "Wingdings@Wingmail.io",

                    BusinessName = "Wingdings inc",

                    BusinessAddress = "600 Centralia College Blvd, Centralia, WA 98531"

                }
            
            );

            modelBuilder.Entity<DynamicContent>().HasData(

                new DynamicContent
                {
                    Name = "Test",

                    Body = "This is a post",

                    Author = "Arial Hughman",

                    CreatedDate = DateTime.Now,

                    LastModifiedDate = DateTime.Now,

                    Content = "Really cool stuff"

                },
                new DynamicContent
                {
                    Name = "Test2",

                    Body = "Do not dawdle. I lust for my revenge.",

                    Author = "SHODAN",

                    CreatedDate = new DateTime(1999, 8, 11),

                    LastModifiedDate = DateTime.Now,

                    Content = "Really neat stuff"

                }
            );

            modelBuilder.Entity<FeedbackData>().HasData(
                new FeedbackData
                {
                    FeedBackID = 1,

                    Feedback = "I like toast",

                    FeedbackEmail = "RealGuy@RealMail.io"

                },
                new FeedbackData
                {
                    FeedBackID = 2,

                    Feedback = "I'm somewhat partial to toast",

                    FeedbackEmail = "MildlyInterestingGuy@RealMail.io"

                }

            );
            modelBuilder.Entity<StaticContent>().HasData(
                new StaticContent
                {
                    StaticContentID = 1,

                    Name = "About",

                    CreatedDate = new DateTime(2024, 2, 1),

                    LastModifiedDate = DateTime.Now,

                    Content = "We make stuff"

                },
                new StaticContent
                {
                    StaticContentID = 2,

                    Name = "Help",

                    CreatedDate = new DateTime(2024, 2, 1),

                    LastModifiedDate = DateTime.Now,

                    Content = "Everything you need to know"

                }

            );
        }
    }
}
