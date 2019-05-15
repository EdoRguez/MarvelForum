using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class FindVM
    {
        public IEnumerable<Character> Characters { get; set; }
        public IEnumerable<Comic> Comics { get; set; }
        public IEnumerable<Creator> Creators { get; set; }
        public IEnumerable<Series> Series { get; set; }
    }
}
