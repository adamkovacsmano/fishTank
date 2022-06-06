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
            var fish2 = new BabelFish("Grazia");
            var fish3 = new AngelFish("Boa");

            var tank = new Tank();
            tank.Add(fish1);
            tank.Add(fish2);
            tank.Add(fish3);

            var result = tank.Feed();

            Assert.Equal(0.1 + 0.2 + 0.3, result);
        }
    }
}