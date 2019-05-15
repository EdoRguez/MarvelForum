using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class ComicDataWrapper
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string Text { get; set; }
        public string AtttributionHtml { get; set; }
        public ComicDataContainer Data { get; set; }
        public string Etag { get; set; }
    }

    public class ComicDataContainer
    {
        public int Offset { get; set; }
        public int Limt { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public IEnumerable<Comic> Results { get; set; }
    }

    public class Comic
    {
        public int Id { get; set; }
        public int DigitalId { get; set; }
        public string Title { get; set; }
        public double IssueNumber { get; set; }
        public string VariantDescription { get; set; }

        private string RealDescription { get; set; }
        public string Description {

            get {
                return RealDescription;
            }
            set
            {                
                if(string.IsNullOrEmpty(value))
                {
                    RealDescription = "This comic doesn't have description yet";
                }
                else
                {
                    value = value.Trim();
                    RealDescription = value;
                }        
            }
        }

        public string Modified { get; set; }
        public string Isbn { get; set; }
        public string Upc { get; set; }
        public string DiamondCode { get; set; }
        public string Ean { get; set; }
        public string Issn { get; set; }
        public string Format { get; set; }
        public int PageCount { get; set; }
        public IEnumerable<TextObject> TextObjects { get; set; }
        public string ResourceUri { get; set; }
        public IEnumerable<Url> Urls { get; set; }
        public SeriesSummary Series { get; set; }
        public IEnumerable<ComicSummary> Variants { get; set; }
        public IEnumerable<ComicSummary> Collections { get; set; }
        public IEnumerable<ComicSummary> CollectedIssues { get; set; }
        public IEnumerable<ComicDate> Dates { get; set; }
        public IEnumerable<ComicPrice> Prices { get; set; }
        public Image Thumbnail { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public CreatorList Creators { get; set; }
        public CharacterList Characters { get; set; }
        public StoryList Stories { get; set; }
        public EventList Events { get; set; }
    }

    public class TextObject
    {
        public string Type { get; set; }
        public string Language { get; set; }
        public string Text { get; set; }
    }

    public class ComicDate
    {
        public string Type { get; set; }
        public string Date { get; set; }
    }

    public class ComicPrice
    {
        public string Type { get; set; }
        public float Price { get; set; }
    }

    public class CreatorList
    {
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionUri { get; set; }
        public IEnumerable<CreatorSummary> Items { get; set; }
    }

    public class CreatorSummary
    {
        public string ResourceUri { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

    public class CharacterList
    {
        public int Available { get; set; }
        public int Returned { get; set; }
        public string CollectionUri { get; set; }
        public IEnumerable<CharacterSummary> Items { get; set; }
    }

    public class CharacterSummary
    {
        public string ResourceUri { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

}
