using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Author
    {
        public string Name { get; set; }
        public IList<Item> Items { get; set; }
    }
}
