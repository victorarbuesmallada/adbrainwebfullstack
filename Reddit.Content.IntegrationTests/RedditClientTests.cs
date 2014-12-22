using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reddit.Client.IntegrationTests
{
    [TestClass]
    public class RedditClientTests
    {
        [TestMethod]
        public void RedditSportsRequestResponseIsSuccessful()
        {
            //Arrange
            var redditClient = new RedditClient.RedditClient();

            //Act
            var task = redditClient.GetSportItems();

            //Assert
            Assert.IsNotNull(task.Result, "Couldn't retrieve anything");
        }
    }
}
