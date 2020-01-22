using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weatherday;
using Xunit;

namespace UnitTestPrj.Tests
{
    public class CityServiceTests
    {
        private readonly CityService service;

        public CityServiceTests()
        {
            service = new CityService();
        }

        [Fact]
        public void Validation_Success()
        {
            var city = new City("Poland", "Poznañ");

            service.AddCity(city);

            var existCity = service.CityList.FirstOrDefault(w => w.Name == city.Name);

            Assert.NotNull(existCity);
        }

        [Theory]
        [InlineData(null, "test")]
        [InlineData("as", "test")]
        [InlineData("test", null)]
        [InlineData("test", "as")]
        [InlineData("test", "test")]
        public void Validation_Fail(string country, string city)
        {
            var ex = Assert.Throws<Exception>(() =>
            {
                var ncity = new City(country, city);

                service.AddCity(ncity);
            });
        }
    }
}
