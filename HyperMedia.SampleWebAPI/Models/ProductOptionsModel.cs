using System.Collections.Generic;

namespace HyperMedia.SampleWebAPI.Models
{
    public class ProductOptionsModel : ISupportsHyperMedia
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}