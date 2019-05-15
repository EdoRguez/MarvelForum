using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class CharacterDataWrapper
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHTML { get; set; }
        public CharacterDataContainer Data { get; set; }
        public string Etag { get; set; }
    }

    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private string RealDescription { get; set; }
        public string Description {
            get { return RealDescription; }
            set {                
                if (String.IsNullOrEmpty(value))
                {
                    RealDescription = "This character doesn't have description yet";
                }
                else
                {
                    value = value.Trim();
                    RealDescription = value;
                }
            }
        }

        public string Modified { get; set; }
        public string ResourceURI { get; set; }
        public IEnumerable<Url> Urls { get; set; }
        public Image Thumbnail { get; set; }
        public ComicList Comics { get; set; }
        public StoryList Stories { get; set; }
        public EventList Events { get; set; }
        public SeriesList Series { get; set; }
    }

    public class CharacterDataContainer
    {
        public int Offser { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public IEnumerable<Character> Results { get; set; }
    }

    public class ComicList
    {
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionUri { get; set; }
        public IEnumerable<ComicSummary> Items { get; set; }
    }

    public class ComicSummary
    {
        public string ResourceUri { get; set; }
        public string Name { get; set; }
    }

    public class EventList
    {
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionUri { get; set; }
        public IEnumerable<EventSummary> Items { get; set; }
    }

    public class EventSummary
    {
        public string ResourceUri { get; set; }
        public string Name { get; set; }
    }

    public class Image
    {
        public string Path { get; set; }
        public string Extension { get; set; }
    }

    public class SeriesList
    {
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionUri { get; set; }
        public IEnumerable<SeriesSummary> Items { get; set; }
    }

    public class SeriesSummary
    {
        public string ResourceUri { get; set; }
        public string Name { get; set; }
    }

    public class StoryList
    {
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionUri { get; set; }
        public IEnumerable<StorySummary> Items { get; set; }
    }

    public class StorySummary
    {
        public string ResourceUri { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class Url
    {
        public string Type { get; set; }
        public string url { get; set; }
    }
}
