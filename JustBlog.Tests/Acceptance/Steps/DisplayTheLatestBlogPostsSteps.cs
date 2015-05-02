using JustBlog.Controllers;
using JustBlog.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using TechTalk.SpecFlow;
using FluentAssertions;
using JustBlog.Actions;
using JustBlog.Infrastructure;

namespace JustBlog.Tests.Acceptance.Steps
{
    [Binding]
    public class DisplayTheLatestBlogPostsSteps
    {
        private IEnumerable<Post> posts;

        [Given(@"the blog has posts")]
        public void GivenTheBlogHasPosts()
        {
        }
        
        [When(@"I request a list of posts")]
        public void WhenIRequestAListOfPosts()
        {
            IJustBlogDb db = new JustBlogDb();
            var postsRepository = new PostsRepository(db);
            var readPosts = new ReadPosts(postsRepository);
            var controller = new PostsController(readPosts);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            posts = controller.Posts() as IEnumerable<Post>;
        }

        [Then(@"I should get a list of post titles order by descending published date")]
        public void ThenIShouldGetAListOfPostTitlesOrderByDescendingPublishedDate()
        {
            posts.Should().NotBeNull();
        }

    }
}
