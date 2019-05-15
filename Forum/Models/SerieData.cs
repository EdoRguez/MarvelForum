using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class SeriesDataWrapper
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public SeriesDataContainer Data { get; set; }
        public string Etag { get; set; }
    }

    public class SeriesDataContainer
    {
        public int Offser { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public IEnumerable<Series> Results { get; set; }
    }

    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }

        private string RealDescription { get; set; }
        public string Description {
            get {
                return RealDescription;
            }
            set
            {                
                if(string.IsNullOrEmpty(value))
                {
                    RealDescription = "This serie doesn't have description yet";
                }
                else
                {
                    value = value.Trim();
                    RealDescription = value;
                }

            }
        }

        public string ResourceUri { get; set; }
        public IEnumerable<Url> Urls { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Rating { get; set; }
        public string Modified { get; set; }
        public Image Thumbnail { get; set; }
        public ComicList Comics { get; set; }
        public StoryList Stories { get; set; }
        public EventList Events { get; set; }
        public CharacterList Characters { get; set; }
        public CreatorList Creators { get; set; }
        public SeriesSummary Next { get; set; }
        public SeriesSummary Previous { get; set; }
    }
}
