using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustBlog.Actions
{
    public class ReadPosts
    {
        private Infrastructure.PostsRepository postsRepository;

        public ReadPosts()
        {

        }

        public ReadPosts(Infrastructure.PostsRepository postsRepository)
        {
            this.postsRepository = postsRepository;
        }

        public virtual void Execute()
        {
            postsRepository.LoadLatest();
        }
    }
}
