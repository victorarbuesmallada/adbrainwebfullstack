using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RedditClient;
using Business.Interfaces;
using Api.Controllers;
using Reddit.DataTransfer;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using DefaultConfiguration.App_Start;
using AutoMapper;
using DataTransfer.Dto;

namespace Api.UnitTests
{
    [TestClass]
    public class ItemsControllerTests
    {

        [TestInitialize]
        public void Setup()
        {
            AutomapperConfig.Configure();
        }

        [TestMethod]
        public void GetSportsByDomainGroupByAuthorIsSuccesful()
        {
            //Arrange
            var domain = "youtube.com";
            var response = new Response()
                {
                    Data = new ResponseData()
                    {
                        Children = new List<Item>()
                        {
                            new Item(){
                                Data = new ItemData(){
                                    Author = "author",
                                    Id = "12345",
                                    Created = 1234245252,
                                    Domain = domain,
                                    Title = "title",
                                    PermaLink = "http://www.permalink.com"
                                }
                            }
                        }
                    }
                };
            var items = Mapper.Map<IList<Item>, IList<Domain.Item>>(response.Data.Children);
            var clientResponse = Task.FromResult(response);

            var redditClient = new Mock<IRedditClient>();
            var itemManager = new Mock<IItemManager>();

            redditClient.Setup(rc => rc.GetSportItems()).Returns(clientResponse);
            itemManager.Setup(im => im.ProcessSportsRequest(items, It.IsAny<string>()));

            var itemsController = new ItemsController(itemManager.Object, redditClient.Object);

            //Act
            itemsController.GetSportsByDomainGroupByAuthor(domain).ContinueWith((controllerResponse) => {            
                //Assert
                Assert.IsTrue(controllerResponse.Result is OkNegotiatedContentResult<IList<AuthorDto>>, "Result should be successful!");
                redditClient.Verify();
                itemManager.Verify();
            });
        }        
    }
}
