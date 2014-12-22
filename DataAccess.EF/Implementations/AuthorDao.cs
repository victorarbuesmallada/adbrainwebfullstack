using DataAccess.EF.Config;
using DataAccess.Interfaces;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Domain;
using System.Collections.Generic;

namespace DataAccess.EF.Implementations
{
    /// <summary>
    /// Data access class for authors
    /// </summary>
    public class AuthorDao : Dao, IAuthorDao
    {

        /// <summary>
        /// Get authors with their posts by domain
        /// </summary>
        /// <param name="domain">Domain of the post (e.g. youtube.com)</param>
        /// <returns>List of authors and their items</returns>
        public IList<Author> GetAuthorsWithItemsByDomain(string domain)
        {
           var authors = Authors.Include("Items").Where(a => a.Items.Any(i => i.Domain == domain)).ToList();

           return authors.Select(a => new Author
                        {
                            Name = a.Name,
                            Items = a.Items.Where(i => i.Domain == domain).ToList()
                        }).ToList();
        }

    }
}
