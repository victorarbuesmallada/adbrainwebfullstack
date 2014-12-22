using System.Collections.Generic;
using DataAccess.Interfaces;
using Domain;
using DataAccess.EF.Config;
using System.Data.Entity;

namespace DataAccess.EF.Implementations
{
    /// <summary>
    /// EF Dao implementation for items
    /// </summary>
    public class ItemDao : Dao, IItemDao
    {

        public ItemDao()
            : base()
        {
        }

        /// <summary>
        /// Save/Update items
        /// </summary>
        public void Upsert(IList<Item> items)
        {
            foreach (var item in items)
            {
                var itemDb = Items.Find(item.Id);

                if (itemDb == null)
                {
                    var author = Authors.Find(item.AuthorName);
                    item.Author = author ?? new Author() { Name = item.AuthorName };
                    Items.Add(item);
                }
                else
                {
                    //renaming is allowed
                    itemDb.Title = item.Title;
                    Entry(itemDb).State = EntityState.Modified;
                }

            }
            SaveChanges();
        }
    }
}
