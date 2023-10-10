using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpList.Services
{
    public class HousesService
    {
        public int Id { get; set; }
        public int Sqft { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}