using System;
using System.Collections.Generic;
using Xunit;

namespace Assessment.Divers.Test
{
    // A test method (decorated with [Fact] or [Theory]) will become green in
    // the Test Explorer window if ALL Assert() calls within the test method pass.

    // To debug a test method you set a breakpoint (F9) in the test method, then
    // right click the test method in the Test Explorer window and select
    // the Debug option.

    public class Level1Tests
    {
        [Fact]
        public void John()
        {
            var diver = new Diver("John");
            diver.AddFish("shark");

            string desc = diver.GetDescription(); // GetDescription()

            Assert.Equal("John likes shark", desc);
        }

        [Fact]
        public void Paul()
        {
            var diver = new Diver("Paul");
            diver.AddFish("carp");
            string desc = diver.GetDescription();
            Assert.Equal("Paul likes carp", desc);
        }

        [Fact]
        public void Lisa()
        {
            var diver = new Diver("Lisa");
            diver.AddFish("goldfish");
            diver.AddFish("catfish");
            diver.AddFish("zander");

            string desc = diver.GetDescription();

            Assert.Equal("Lisa likes goldfish,catfish,zander", desc);
        }

        [Fact]
        public void Dont_Care_About_Casing()
        {
            var diver = new Diver("Lisa");
            diver.AddFish("GOLDfish");
            diver.AddFish("Catfish");
            diver.AddFish("zanDer");

            string description = diver.GetDescription();

            Assert.Equal("Lisa likes goldfish,catfish,zander", description);
        }

        [Fact]
        public void Sue_Doesnt_Like_Any_Fish()
        {
            var diver = new Diver("Sue");
            string description = diver.GetDescription();

            Assert.Equal("Sue doesn't like any fish", description);
        }

        [Fact]
        public void Nancy()
        {
            var diver = new Diver("Nancy");

            diver.AddFish("catfish");
            diver.AddFish("zander");
            diver.AddFish("goldfish");
            diver.AddFish("sword fish");
            diver.AddFish("tench");
            diver.AddFish("mackerel");
            diver.AddFish("blob fish");

            string description = diver.GetDescription();

            Assert.Equal("Nancy likes catfish,zander,goldfish,sword fish,tench,mackerel,blob fish", description);

            // Get all fishes with 7 or more letters. Sort the result alphabetically
            // Do two methods, with and without Linq.

            var fishes = diver.FishesSortedAlphabetically(7); // No need to implement your own sort algorithm.
                                                              // Just call List.Sort() without any arguments.

            var fishes_linq = diver.FishesSortedAlphabetically_Linq(7);

            Assert.Equal(new List<string>
            {
                "blob fish",
                "catfish",
                "goldfish",
                "mackerel",
                "sword fish",
            }, fishes);

            //Assert.Equal(fishes, fishes_linq);

            // 9 or more letters
            var fishes2 = diver.FishesSortedAlphabetically(9);
            var fishes_linq2 = diver.FishesSortedAlphabetically_Linq(9);

            Assert.Equal(new List<string>
            {
                "blob fish",
                "sword fish",
            }, fishes2);

            //Assert.Equal(fishes2, fishes_linq2);

            // 6 or more letters
            var fishes3 = diver.FishesSortedAlphabetically(6);
            var fishes_linq3 = diver.FishesSortedAlphabetically_Linq(6);

            Assert.Equal(new List<string>
            {
                "blob fish",
                "catfish",
                "goldfish",
                "mackerel",
                "sword fish",
                "zander"
            }, fishes3);

            Assert.Equal(fishes3, fishes_linq3);
        }

        [Fact]
        public void Marc()
        {
            var d = new Diver("Marc");
            int position = d.GetPosition();

            Assert.Equal(0, position);
        }

        [Fact]
        public void Marc_Swims_Down()
        {
            var diver = new Diver("Marc");

            Assert.Equal(0, diver.GetPosition());

            diver.SetDirectionDown();

            Assert.Equal(0, diver.GetPosition());

            diver.Swim();
            diver.Swim();
            diver.Swim();

            Assert.Equal(-3, diver.GetPosition());
        }

        [Fact]
        public void George_Swims_Down_and_Then_Up()
        {
            var diver = new Diver("George");

            Assert.Equal(0, diver.GetPosition());

            diver.SetDirectionDown();

            Assert.Equal(0, diver.GetPosition());

            diver.Swim();
            diver.Swim();
            diver.Swim();
            diver.Swim();
            diver.Swim();

            Assert.Equal(-5, diver.GetPosition());

            diver.Swim();
            diver.Swim();

            Assert.Equal(-7, diver.GetPosition());

            diver.SetDirectionUp();

            Assert.Equal(-7, diver.GetPosition());

            diver.Swim();
            diver.Swim();

            Assert.Equal(-5, diver.GetPosition());
        }
    }
}
