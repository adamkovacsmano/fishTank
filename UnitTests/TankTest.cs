using ClassLibrary;
using Xunit;

namespace UnitTests
{
    public class TankTest
    {
        private readonly Tank _tank;

        public TankTest()
        {
            _tank = new Tank();
        }

        [Fact]
        public void Tank_Feed_ReturnsExpectedSum()
        {
            var fish1 = new GoldFish("Teo");
            var fish2 = new BabelFish("Grazia");
            var fish3 = new AngelFish("Boa");

            _tank.Add(fish1);
            _tank.Add(fish2);
            _tank.Add(fish3);

            var result = _tank.Feed();

            Assert.Equal(GoldFish.Weight + BabelFish.Weight + AngelFish.Weight, result);
        }

        [Theory]
        [InlineData(10, 5, 6)]
        [InlineData(3, 4, 2)]
        public void Tank_Feed_ReturnsExpectedSumWithMassiveData(int goldFishCount, int babelFishCount, int angelFishCount)
        {
            for (int i = 0; i < goldFishCount; i++)
            {
                _tank.Add(new GoldFish(i.ToString()));
            }

            for (int i = 0; i < babelFishCount; i++)
            {
                _tank.Add(new BabelFish(i.ToString()));
            }

            for (int i = 0; i < angelFishCount; i++)
            {
                _tank.Add(new AngelFish(i.ToString()));
            }

            // TODO: can we improve this?
            int totalGoldFishWeight = (int)(goldFishCount * GoldFish.Weight * 100);
            int totalBabelFishWeight = (int)(babelFishCount * BabelFish.Weight * 100);
            int totalAngelFishWeight = (int)(angelFishCount * AngelFish.Weight * 100);

            int expected = totalGoldFishWeight + totalBabelFishWeight + totalAngelFishWeight;

            Assert.Equal(expected, (int)(_tank.Feed() * 100));
        }

        [Fact]
        public void Tank_Feed_ReturnsZeroForEmptyTank()
        {
            var result = _tank.Feed();

            Assert.Equal(0, result);
        }
    }
}