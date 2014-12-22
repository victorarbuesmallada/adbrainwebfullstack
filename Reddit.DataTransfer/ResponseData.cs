using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit.DataTransfer
{
    public class ResponseData
    {
        [JsonProperty(PropertyName = "modhash")]
        public string ModHash { get; set; }

        [JsonProperty(PropertyName = "children")]
        public List<Item> Children { get; set; }

        [JsonProperty(PropertyName = "after")]
        public string After { get; set; }

        [JsonProperty(PropertyName = "before")]
        public string Before { get; set; }
    }
}
