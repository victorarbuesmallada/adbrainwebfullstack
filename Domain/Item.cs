using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Item
    {

        public string Id { get; set; }
        public string Domain { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public string PermaLink { get; set; }
        public string AuthorName { get; set; }
        public Author Author { get; set; }

    }
}
