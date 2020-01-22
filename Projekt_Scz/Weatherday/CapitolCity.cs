using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherday
{
    public class CapitolCity : City
    {
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Country))
            {
                return $"{Name}";
            }
            return $"{Name}, capitol city of {Country}";
        }
        public CapitolCity(string country, string name):base(country,name)
        {
            this.Country = country;
            this.Name = name;
        }
    }
}
