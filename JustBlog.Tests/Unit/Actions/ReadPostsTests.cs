using JustBlog.Actions;
using JustBlog.Infrastructure;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Tests.Unit.Actions
{
    [TestFixture]
    public class ReadPostsTests
    {
        [Test]
        public void ColaborateWirhPostsRepositoryToGetPosts()
        {
            var postsRepository = Substitute.For<PostsRepository>();
            var readPosts = new ReadPosts(postsRepository);

            readPosts.Execute();

            postsRepository.Received().LoadLatest();
        }
    }
}
