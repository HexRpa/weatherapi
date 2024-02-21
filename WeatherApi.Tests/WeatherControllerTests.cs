using System.Linq;
using WeatherApi.Controllers;
using Xunit;

namespace WeatherApi.Tests
{
    public class WeatherControllerTests
    {
        [Fact]
        public void Get_ReturnsFiveForecasts()
        {
            // Arrange
            var controller = new WeatherController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.Equal(5, result.Count());
        }
    }
}
