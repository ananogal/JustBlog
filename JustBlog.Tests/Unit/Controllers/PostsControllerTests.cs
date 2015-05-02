using JustBlog.Actions;
using JustBlog.Controllers;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Tests.Unit.Controllers
{
    [TestFixture]
    public class PostsControllerTests
    {
        [Test]
        public void ColaborateWithReadPostsToGetListOfLatestPosts()
        {
            var readPosts = Substitute.For<ReadPosts>();
            var controller = new PostsController(readPosts);
            controller.Posts();

            readPosts.Received().Execute();
        }
    }
}
