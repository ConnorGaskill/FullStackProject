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
    }
}
