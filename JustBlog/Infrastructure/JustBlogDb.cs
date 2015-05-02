using JustBlog.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace JustBlog.Infrastructure 
{
    public class JustBlogDb : DbContext, IJustBlogDb
    {
        public JustBlogDb()
            : base("DefaultConnection")
        {

        }
        public DbSet<Post> Posts { get; set; }

        IQueryable<T> IJustBlogDb.Query<T>()
        {
            return Set<T>();
        }
    }
}
