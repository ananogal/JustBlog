using JustBlog.Domain;
using JustBlog.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustBlog.Actions
{
    public class ReadPosts
    {
        private PostsRepository postsRepository;

        public ReadPosts()
        {

        }

        public ReadPosts(PostsRepository postsRepository)
        {
            this.postsRepository = postsRepository;
        }

        public virtual IEnumerable<Post> Execute()
        {
            return postsRepository.LoadLatest();
        }
    }
}
