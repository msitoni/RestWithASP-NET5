using _01_RestWithASPNET.Hypermedia;
using _01_RestWithASPNET.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_RestWithASPNET.Data.VO
{
    public class PersonVO : ISupportHyperMedia
    {
        public long Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Address { get; set; }

        public String Gender { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
