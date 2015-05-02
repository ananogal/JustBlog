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
        private FakeJustBlogDb fakedb;
        private PostsRepository postsRepository;

        [SetUp]
        public void BeforeEach()
        {
            fakedb = new FakeJustBlogDb();
            fakedb.AddSet(TestData.Posts);

            postsRepository = new PostsRepository(fakedb);
        }

        [Test]
        public void ShouldLoadLatestPosts()
        {
            var posts = postsRepository.LoadLatest();

            posts.Should().NotBeEmpty();
        }

        [Test]
        public void ShouldLoadLatestTenPostsOrderByPublishedDate()
        {
            var posts = postsRepository.LoadLatest();

            posts.Should().BeInDescendingOrder(p => p.PublishedDate);
        }


        
    }
}
