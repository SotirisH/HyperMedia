using System.Collections.Generic;

namespace HyperMedia.SampleWebAPI.Models
{
    public class ProductModel : ISupportsHyperMedia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}