using JustBlog.Actions;
using JustBlog.Domain;
using System.Collections.Generic;
using System.Web.Http;

namespace JustBlog.Controllers
{
    public class PostsController : ApiController
    {
        private ReadPosts readPostsAction;

        public PostsController(ReadPosts readPostsAction)
        {
            this.readPostsAction = readPostsAction;
        }

        [Route("api/posts")]
        public IEnumerable<Post> Posts()
        {
            return readPostsAction.Execute();
        }
    }
}
