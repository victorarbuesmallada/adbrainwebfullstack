
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.Dto
{
    /// <summary>
    /// Dto for the author entity
    /// </summary>
    public class AuthorDto
    {
        [JsonProperty(PropertyName="author")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IList<ItemDto> Items { get; set; }
    }
}
