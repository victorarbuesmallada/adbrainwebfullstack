using AutoMapper;
using Business.Interfaces;
using DataTransfer.Dto;
using log4net;
using Reddit.DataTransfer;
using RedditClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    /// <summary>
    /// Controller with item-related endpoints
    /// </summary>
    public class ItemsController : ApiController
    {
        private static readonly ILog Log = log4net.LogManager.GetLogger(typeof(ItemsController));

        private readonly IItemManager _itemManager;
        private readonly IRedditClient _redditClient;

        public ItemsController(IItemManager itemManager,
            IRedditClient redditClient)
        {
            _itemManager = itemManager;
            _redditClient = redditClient;
        }

        public async Task<IHttpActionResult> GetSportsByDomainGroupByAuthor(string domain)
        {
            IList<AuthorDto> result = new List<AuthorDto>();
            try
            {
                return await _redditClient.GetSportItems().ContinueWith((sportsFeed) =>
                {
                    var items = Mapper.Map<IList<Item>, IList<Domain.Item>>(((Response)sportsFeed.Result).Data.Children);
                    result = Mapper.Map<IList<Domain.Author>, IList<AuthorDto>>(_itemManager.ProcessSportsRequest(items, domain));
                    return Ok<IList<AuthorDto>>(result);
                });
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("An exception happened while trying to process the sports request \nError: {0}", ex.Message);
                return BadRequest();
            }
        }

    }
}
