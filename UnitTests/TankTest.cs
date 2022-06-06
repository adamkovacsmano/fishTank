using ClassLibrary;
using Xunit;

namespace UnitTests
{
    public class TankTest
    {
        [Fact]
        public void Tank_Feed_ReturnsExpectedSum()
        {
            var fish1 = new GoldFish("Teo");
            var fish2 = new GoldFish("Grazia");

            var tank = new Tank();
            tank.Add(fish1);
            tank.Add(fish2);

            var result = tank.Feed();

            Assert.Equal(2.4, result);
        }
    }
}