using ClassLibrary1;
namespace xUnitProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("brIghTs", "Brights")]
        [InlineData("     acaDemY", "Academy")]
        public void Test1(string dirtyStr, string expected)
        {
            // Arrange

            // Act
            string cleanStr = Class1.CleanUp(dirtyStr);

            // Assert
            Assert.Equal(expected, cleanStr);

        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(11, 12)]
        [InlineData(110, 111)]
        public void TestAddOne(int i, int expected)
        {
            //Arrange

            //Act
            int returnInt = Class1.AddOne(i);

            //Assert
            Assert.Equal(expected, returnInt);
        }
    }
}