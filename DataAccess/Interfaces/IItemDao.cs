using Domain;
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    /// <summary>
    /// Interface for the item data access
    /// </summary>
    public interface IItemDao
    {
        /// <summary>
        /// Save/Update items
        /// </summary>
        void Upsert(IList<Item> items);
    }
}
