using JustBlog.Infrastructure;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using JustBlog.Tests.Unit.Fakes;

namespace JustBlog.Tests.Unit.Infrastructure
{
    [TestFixture]
    public class PostsRepositoryTests
    {
        [Test]
        public void ShouldLoadLatestPosts()
        {
            var db = new FakeJustBlogDb();
            db.AddSet(TestData.Posts);

            var postsRepository = new PostsRepository(db);

            var posts = postsRepository.LoadLatest();

            posts.Should().NotBeEmpty();

        }
    }
}
