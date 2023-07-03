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

        // Lab 07 TESTS

        [Fact]
        public void InterfaceImplementationTest()
        {
            Crocodile crocodile = new Crocodile();
            Lion lion = new Lion();
            Tiger tiger = new Tiger();
            Spider spider = new Spider();
            Python python = new Python();

            string resCrocodile = crocodile.Drink();
            string resCrocodile2 = crocodile.Hide();
            string resTiger = tiger.Hide();
            string resLion = lion.Drink();
            string resPython = python.Hide();
            string resSpider = spider.Drink();


            Assert.Equal("crocodiles live in rivers they're always drinking water", resCrocodile);
            Assert.Equal("Tigers are so good at hiding when hunting. they can be called one of the best hide and seek players", resTiger);
            Assert.Equal("Crocodiles are so good at moving without disrupting the water one can be in this river here and i wouldnt know it", resCrocodile2);
            Assert.Equal("Lions dont drink water often", resLion);
            Assert.Equal("pythons dont hide on trees. they live there", resPython);
            Assert.Equal("spiders drink the blood of victims not water", resSpider);
        }

        [Fact]
        public void InheritanceTest()
        {
            Reptiles reptiles = new Crocodile();
            Assert.Equal("The crocodile is laying eggs.", reptiles.LayEggs());
            Assert.True(reptiles is Animal);
        }

        [Fact]

        public void PolyTest()
        {
            Tiger tiger = new Tiger();
            string result = ((Mammals)tiger).Groom();
            Assert.Equal(result, tiger.Groom());
            Assert.IsAssignableFrom<Animal>(tiger);
        }

    }
}
