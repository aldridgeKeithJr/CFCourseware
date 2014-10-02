using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_1
{
    public class House
    {
        public string bedrooms { get; set; }
        public string bathrooms { get; set; }
        public string sqft { get; set; }
        public string type { get; set; }

        public House() { } 

        public House(string bedrooms, string bathrooms, string sqft, string type)
        {
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
            this.sqft = sqft;
            this.type = type;
        }
    }
}
