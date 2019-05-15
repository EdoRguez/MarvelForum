using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class CreatorDataWrapper
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHtml { get; set; }
        public CreatorDataContainer Data { get; set; }
        public string Etag { get; set; }
    }

    public class CreatorDataContainer
    {
        public int Offser { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public IEnumerable<Creator> Results { get; set; }
    }

    public class Creator
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string FullName { get; set; }
        public string Modified { get; set; }
        public string ResourceUri { get; set; }
        public IEnumerable<Url> Urls { get; set; }
        public Image Thumbnail { get; set; }
        public SeriesList Series { get; set; }
        public StoryList Stories { get; set; }
        public ComicList Comics { get; set; }
        public EventList Events { get; set; }
    }

}
