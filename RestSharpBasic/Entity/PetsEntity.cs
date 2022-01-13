using RestSharpBasic.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpBasic.DTO
{
    public class PetsEntity
    {
        public long Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public List<string> PhotoUrls { get; set; }
        public List<Category> Tags { get; set; }
        public string Status { get; set; }
    }
    
}
