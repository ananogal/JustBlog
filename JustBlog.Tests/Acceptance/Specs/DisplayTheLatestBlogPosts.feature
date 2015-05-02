Feature: DisplayTheLatestBlogPosts
	In order to consume the latest Blog Posts
	As a consumer
	I want to get a list of posts

@mytag
Scenario: Post titles
	Given the blog has posts
	When I request a list of posts
	Then I should get a list of post titles order by descending published date
