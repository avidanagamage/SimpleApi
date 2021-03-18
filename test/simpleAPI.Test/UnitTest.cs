using System;
using Xunit;
using simpleAPI.Controllers;
using System.Linq;

namespace simpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController weatherController = new WeatherForecastController();
        ValuesController valueController = new ValuesController();
        [Fact]
        public void GetRequestWeather()
        {
            var returnValue = weatherController.Get();
            Assert.NotNull(returnValue);
        }

        [Fact]
        public void GetValues()
        {
            var returnValue = valueController.Get();
            Assert.Equal(new string[] { "val 1", "val 2" }, returnValue.Value);
        }
    }
}
