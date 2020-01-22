using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherday
{
    public class City
    {
        private Guid Id;
        public string Country { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            if (String.IsNullOrEmpty(Country))
            {
                return $"{Name}";
            }
            return $"{Name}, {Country}";
        }
      
        public City(string country,string name)
        {
            this.Id = new Guid();
            this.Country = country;
            this.Name = name;
        }
        public City(string name)
        {
            this.Id = new Guid();
            this.Country = null;
            this.Name = name;
        }
    }
}
