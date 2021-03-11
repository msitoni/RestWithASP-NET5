using _01_RestWithASPNET.Hypermedia;
using _01_RestWithASPNET.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_RestWithASPNET.Data.VO
{
    public class BookVO : ISupportHyperMedia
    {
        public long Id { get; set; }

        public String Author { get; set; }

        public DateTime LaunchDate { get; set; }

        public Decimal Price { get; set; }

        public String Title { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
