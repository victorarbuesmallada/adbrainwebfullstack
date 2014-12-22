using Reddit.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditClient
{
    /// <summary>
    /// Interface for Reddit client calls
    /// </summary>
    public interface IRedditClient
    {
        Task<Response> GetSportItems();
    }
}
