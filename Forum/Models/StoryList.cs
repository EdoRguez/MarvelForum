using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class StoryList
    {
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionUri { get; set; }
        public IEnumerable<StorySummary> Items { get; set; }
    }
}
