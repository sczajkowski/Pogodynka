using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherday
{
    public class City
    {
        public string Country { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
             return $"{Name}, {Country}";
        }
      
        public City(string country,string name)
        {
            this.Country = country;
            this.Name = name;
        }
    }
}
