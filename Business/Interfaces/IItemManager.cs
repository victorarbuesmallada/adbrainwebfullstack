using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    /// <summary>
    /// Interface for the items business layer logic
    /// </summary>
    public interface IItemManager
    {
        IList<Author> ProcessSportsRequest(IList<Item> items, string domain);
    }
}
