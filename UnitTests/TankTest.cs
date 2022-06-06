using ClassLibrary;
using Xunit;

namespace UnitTests
{
    public class TankTest
    {
        [Fact]
        public void Tank_Feed_ReturnsExpectedSum()
        {
            var fish1 = new Fish("Teo", 1.2);
            var fish2 = new Fish("Grazia", 2.3);

            var tank = new Tank();
            tank.Add(fish1);
            tank.Add(fish2);

            var result = tank.Feed();

            Assert.Equal(3.5, result);
        }
    }
}