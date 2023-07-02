using Xunit;
using Lab06_Zoo;

namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void LionRoarTest()
        {
            // Arrange
            Lion lion = new Lion();

            // Act
            string result = lion.Roar();

            // Assert
            Assert.Equal("The lion is ROAAARING", result);
        }

        [Fact]
        public void LionPlayTest()
        {
            // Arrange
            Lion lion = new Lion();

            // Act
            string result = lion.Play();

            // Assert
            Assert.Equal("the lions play really rough", result);
        }

        [Fact]
        public void TigerRoarTest()
        {
            // Arrange
            Tiger tiger = new Tiger();

            // Act
            string result = tiger.Roar();

            // Assert
            Assert.Equal("The tiger is ROAAARING", result);
        }

        [Fact]
        public void TigerPlayTest()
        {
            // Arrange
            Tiger tiger = new Tiger();

            // Act
            string result = tiger.Play();

            // Assert
            Assert.Equal("the tiger sneaks really well. LOOK BEHIND YOU!!", result);
        }

        [Fact]
        public void CrocodileLayEggsTest()
        {
            // Arrange
            Crocodile crocodile = new Crocodile();

            // Act
            string result = crocodile.LayEggs();

            // Assert
            Assert.Equal("The crocodile is laying eggs.", result);
        }

        [Fact]
        public void CrocodileSwimTest()
        {
            // Arrange
            Crocodile crocodile = new Crocodile();

            // Act
            string result = crocodile.Swim();

            // Assert
            Assert.Equal("The crocodile is swimming.", result);
        }


        [Fact]
        public void PythonLayEggsTest()
        {
            // Arrange
            Python python = new Python();

            // Act
            string result = python.LayEggs();

            // Assert
            Assert.Equal("The python is laying eggs.", result);
        }

        [Fact]
        public void PythonSwimTest()
        {
            // Arrange
            Python python = new Python();

            // Act
            string result = python.Swim();

            // Assert
            Assert.Equal("The python is swimming.", result);
        }

        [Fact]
        public void SpiderSpinWebTest()
        {
            // Arrange
            Spider spider = new Spider();

            // Act
            string result = spider.SpinWeb();

            // Assert
            Assert.Equal("The spider is spinning a web.", result);
        }

        [Fact]
        public void SpiderInjectVenomTest()
        {
            // Arrange
            Spider spider = new Spider();

            // Act
            string result = spider.InjectVenom();

            // Assert
            Assert.Equal("The spider is injecting venom.", result);
        }
    }
}
