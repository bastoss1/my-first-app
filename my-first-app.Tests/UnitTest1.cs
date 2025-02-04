using System;
using Xunit;
using Microsoft.Extensions.Logging.Abstractions;
using myfirstapp.Controllers;

namespace Samples.WeatherForecast.Api.UnitTest
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void ShouldReturnAListOfValues()
        {
            // Arrange
            var logger = new NullLogger<WeatherForecastController>();
            var controller = new WeatherForecastController(logger);

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
        }
    }
}
