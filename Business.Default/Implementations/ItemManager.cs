using Business.Interfaces;
using DataAccess.Interfaces;
using Domain;
using log4net;
using System.Collections.Generic;

namespace Business.Default.Implementations
{
    public class ItemManager : IItemManager
    {
        private static readonly ILog Log = log4net.LogManager.GetLogger(typeof(ItemManager));

        private readonly IItemDao _itemDao;
        private readonly IAuthorDao _authorDao;

        public ItemManager(IItemDao itemDao, IAuthorDao authorDao)
        {
            _itemDao = itemDao;
            _authorDao = authorDao;
        }

        /// <summary>
        /// Process the sports request
        /// </summary>
        /// <param name="items">Items to be saved</param>
        /// <param name="domain">Domain</param>
        /// <returns>Items returned by author</returns>
        public IList<Author> ProcessSportsRequest(IList<Item> items, string domain)
        {
            Log.Info("Saving items");
            
            _itemDao.Upsert(items);

            Log.InfoFormat("Retrieving items for {0}", domain);
            return _authorDao.GetAuthorsWithItemsByDomain(domain);
        }
    }
}
