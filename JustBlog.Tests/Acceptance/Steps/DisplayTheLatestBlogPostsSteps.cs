using JustBlog.Controllers;
using JustBlog.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using TechTalk.SpecFlow;
using FluentAssertions;

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
            var controller = new PostsController(null);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            posts = controller.Posts() as IEnumerable<Post>;
        }
        
        [Then(@"I should get a list of post titles")]
        public void ThenIShouldGetAListOfPostTitles()
        {
            posts.Should().NotBeNull();
        }
    }
}
