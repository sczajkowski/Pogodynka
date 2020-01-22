using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherday
{
    public class CityService
    {
        private List<City> cityList = new List<City>();
        public IReadOnlyCollection<City> CityList => cityList;

        public void AddCity(City c)
        {
            Validate(c);
            cityList.Add(c);
        }
        public void Validate(City c)
        {
            if (c.Name == null ||
                c.Name.Length < 3)
            {
                throw new Exception("Incorrect city name");
            }
        }
    }
}
