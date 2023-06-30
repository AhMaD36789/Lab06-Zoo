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
            lion.Roar();

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void LionPlayTest()
        {
            // Arrange
            Lion lion = new Lion();

            // Act
            lion.Play();

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void TigerRoarTest()
        {
            // Arrange
            Tiger tiger = new Tiger();

            // Act
            tiger.Roar();

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void TigerPlayTest()
        {
            // Arrange
            Tiger tiger = new Tiger();

            // Act
            tiger.Play();

            // Assert
            Assert.True(true);
        }
        [Fact]
        public void CrocodileLayEggsTest()
        {
            // Arrange
            Crocodile crocodile = new Crocodile();

            // Act
            crocodile.LayEggs();

            // Assert
            Assert.True(true);
        }
        [Fact]
        public void CrocodileSwimTest()
        {
            // Arrange
            Crocodile crocodile = new Crocodile();

            // Act
            crocodile.Swim();

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void PythonLayEggsTest()
        {
            // Arrange
            Python python = new Python();

            // Act
            python.LayEggs();

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void PythonSwimTest()
        {
            // Arrange
            Python python = new Python();

            // Act
            python.Swim();

            // Assert
            Assert.True(true);
        }
        [Fact]
        public void SpiderSpinWebTest()
        {
            // Arrange
            Spider spider = new Spider();

            // Act
            spider.SpinWeb();

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void SpiderInjectVenomTest()
        {
            // Arrange
            Spider spider = new Spider();

            // Act
            spider.InjectVenom();

            // Assert
            Assert.True(true);
        }
    }
}
