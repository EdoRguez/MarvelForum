using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class EventList
    {
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionUri { get; set; }
        public IEnumerable<EventSummary> Items { get; set; }
    }
}
