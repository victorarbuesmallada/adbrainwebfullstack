
using Domain;
using System.Collections.Generic;
namespace DataAccess.Interfaces
{
    public interface IAuthorDao
    {
        IList<Author> GetAuthorsWithItemsByDomain(string domain);
    }
}
