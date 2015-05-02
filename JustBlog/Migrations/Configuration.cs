namespace JustBlog.Migrations
{
    using JustBlog.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JustBlog.Infrastructure.JustBlogDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(JustBlog.Infrastructure.JustBlogDb context)
        {
            context.Posts.AddOrUpdate(p => p.PublishedDate,
               new Post { PublishedDate = DateTime.Parse("01/01/2000") },
               new Post { PublishedDate = DateTime.Parse("01/02/2000") },
               new Post { PublishedDate = DateTime.Parse("01/03/2000") },
               new Post { PublishedDate = DateTime.Parse("01/04/2000") },
               new Post { PublishedDate = DateTime.Parse("01/05/2000") },
               new Post { PublishedDate = DateTime.Parse("01/06/2000") },
               new Post { PublishedDate = DateTime.Parse("01/07/2000") },
               new Post { PublishedDate = DateTime.Parse("01/08/2000") },
               new Post { PublishedDate = DateTime.Parse("01/09/2000") },
               new Post { PublishedDate = DateTime.Parse("01/10/2000") },
               new Post { PublishedDate = DateTime.Parse("01/11/2000") },
               new Post { PublishedDate = DateTime.Parse("01/12/2000") },
               new Post { PublishedDate = DateTime.Parse("01/01/2001") }
               );
        }
    }
}
