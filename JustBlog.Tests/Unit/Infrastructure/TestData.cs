using JustBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Tests.Unit.Infrastructure
{
    class TestData
    {
        public static IQueryable<Post> Posts
        {
            get
            {
                var posts = new List<Post>();
                for (int i = 0; i < 100; i++)
                {
                    var post = new Post { PublishedDate = DateTime.Now.AddDays(-i) };
                    posts.Add(post);
                }

                posts.Reverse();

                return posts.AsQueryable();
            }
        }
    }
}
