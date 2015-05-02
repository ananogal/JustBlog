using JustBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustBlog.Infrastructure
{
    public class PostsRepository
    {
        private IJustBlogDb db;

        public PostsRepository()
        {

        }

        public PostsRepository(IJustBlogDb db)
        {
            this.db = db;
        }

        public virtual IEnumerable<Post> LoadLatest()
        {
            return db.Query<Post>().OrderByDescending(p => p.PublishedDate).Take(10);
        }
    }
}
