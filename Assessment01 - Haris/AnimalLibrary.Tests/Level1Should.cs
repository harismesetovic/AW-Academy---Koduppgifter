using System;
using Xunit;
using AnimalLibrary;

namespace AnimalLibrary.Tests
{
    // A test method (decorated with [Fact] or [Theory]) will become green in
    // the Test Explorer window if ALL Assert() calls within the test method pass.

    // To debug a test method you set a breakpoint (F9) in the test method, then
    // right click the test method in the Test Explorer window and select
    // the Debug option.

    // Note: The parameters of the [Theory] test methods get their arguments from
    // the [InlineData()] attributes.

    public class Level1Should
    {
        [Theory]
        [InlineData(0, 3)]   // 0 + 3 = 3
        [InlineData(5, 8)]   // 5 + 3 = 8
        [InlineData(10, 13)] // 10 + 3 = 13
        public void Test_AddThree(int number, int expected)
        {
            int result = MethodsCollection.AddThree(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 12)]
        [InlineData(1, 15)]
        [InlineData(5, 27)]
        public void Test_AddFourAndThenMultiplyByThree(int number, int expected)
        {
            int result = MethodsCollection.AddFourAndThenMultiplyByThree(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("aaa", true, true, "-:AAA:-")]
        [InlineData("aaa", true, false, "AAA")]
        [InlineData("aaa", false, true, "-:aaa:-")]
        [InlineData("aaa", false, false, "aaa")]
        public void Test_MaybeUppercaseAndDecorateText(string s, bool toupper, bool decoration, string expected)
        {
            string result = MethodsCollection.MaybeUppercaseAndDecorateText(s, toupper, decoration);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-5555, "-5555 is a negative number")]
        [InlineData(-1, "-1 is a negative number")]
        [InlineData(92, "Add 8 to 92 and you get 100")]
        [InlineData(95, "Add 5 to 95 and you get 100")]
        [InlineData(100, "Add 0 to 100 and you get 100")]
        [InlineData(101, "101 is greater than 100")]
        [InlineData(4444, "4444 is greater than 100")]
        public void Test_TellRelationToHundred(int number, string expected)
        {
            string result = MethodsCollection.TellRelationToHundred(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Nemo", true, HamsterSpecie.Roborovski, "Nemo is a pet Roborovski hamster.")]
        [InlineData("Kernel", false, HamsterSpecie.Syrian, "Kernel is a wild Syrian hamster.")]
        public void Test_CreateAHamster(string name, bool isPet, HamsterSpecie specie, string expected)
        {
            var h = new Hamster(name, isPet, specie);

            string result = h.Greet();
            Assert.Equal(expected, result);
        }
    }
}