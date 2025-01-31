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

                });

            modelBuilder.Entity<DynamicContent>().HasData(

            new DynamicContent
            {
                Name = "Test",

                Body = "This is a post",

                Author = "Arial Hughman",

                CreatedDate = DateTime.Now,

                LastModifiedDate = DateTime.Now,

                Content = "Really cool stuff"

            });

            modelBuilder.Entity<FeedbackData>().HasData(
                new FeedbackData
                {
                    FeedBackID = 1,

                    Feedback = "I like toast"



                }

                );
        }
    }
}
