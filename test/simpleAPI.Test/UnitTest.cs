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
            Assert.Equal(new string[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"}, returnValue);
        }

        [Fact]
        public void GetValues()
        {
            var returnValue = valueController.Get();
            Assert.Equal(new string[] { "value 1", "value 2" }, returnValue.Value);
        }
    }
}
