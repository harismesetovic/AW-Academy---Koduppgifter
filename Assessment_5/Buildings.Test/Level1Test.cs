using System;
using System.Globalization;
using Xunit;

namespace Buildings.Test
{
    // A test method (decorated with [Fact] or [Theory]) will become green in
    // the Test Explorer window if ALL Assert() calls within the test method pass.

    // To debug a test method you set a breakpoint (F9) in the test method, then
    // right click the test method in the Test Explorer window and select
    // the Debug option.

    // Note: The parameters of the [Theory] test methods get their arguments from
    // the [InlineData()] attributes.

    public class Level1Test
    {
        [Fact]
        public void Test1()
        {
            // Ensures that a decimal comma is used instead of a decimal point.
            CultureInfo.CurrentCulture = new CultureInfo("sv-SE");

            string townName = "Köpenhamn";
            double inhabitantsInMillions = 0.61;
            Town town = new Town(townName, inhabitantsInMillions);

            // Create a power plant. A power plant "IS A" building.
            // A building has three (3) properties. A "Year of Construction",
            // a "Sales value in millions", and a number of "Square meters per
            // floor".
            // A power plant has an additional property which specifies the
            // number of terrawatt hours it produces per year.

            // Building data.
            int yearOfConstruction = 1956;
            decimal salesValueInMillions = 1.45m;
            int squareMetersPerFloor = 52;

            // Additional power plant data.
            double tWhPerYear = 7.32;

            Building powerPlant = new PowerPlant(yearOfConstruction, salesValueInMillions, squareMetersPerFloor, tWhPerYear);

            // Add the power plant to a single list of buildings in the town.
            town.AddBuilding(powerPlant);

            // Add a skyscraper to the single list of buildings in the town.

            // Building data.
            yearOfConstruction = 2020;
            salesValueInMillions = 2.10m;
            squareMetersPerFloor = 221;

            // Skyscraper data.
            int numberOfFloors = 30;

            Building skyscraper = new Skyscraper(yearOfConstruction, salesValueInMillions, squareMetersPerFloor, numberOfFloors);
            town.AddBuilding(skyscraper);

            string expected = "Köpenhamn has approx. 0,6 million inhabitants and 2 buildings.";
            string actual = town.Description;
            Assert.Equal(expected, actual);
            Assert.Equal("Oslo has approx. 1,1 million inhabitants and 0 buildings.", new Town("Oslo", 1.1).Description);
        }

        [Theory]
        [InlineData(4, 19, "The average age of all buildings in New York is 72 years.")]
        [InlineData(59, 1962, "The average age of all buildings in New York is 64,2 years.")]
        [InlineData(7999, 17, "The average age of all buildings in New York is 70,2 years.")]
        // Note: The parameters of this method (Test02) get their arguments from the InlineData attributes.
        public void Test2(int numBuildings, int seed, string expected)
        {
            // Ensures that a decimal comma is used instead of a decimal point.
            CultureInfo.CurrentCulture = new CultureInfo("sv-SE");

            Town town = new Town("New York", 19.29);

            // The following private method in this class named
            // CreateRandomBuildings HAS ALREADY BEEN IMPLEMENTED AT THE END OF
            // THIS FILE. SIMPLY UNCOMMENT ALL OF ITS CODE! Do not spend any
            // time trying to understand the method. It's not necessary and
            // won't help you.
            CreateRandomBuildings(town, numBuildings, seed, false);

            // Return the average age of all buildings in the town. NOTE:
            // Although this test method assumes that the year is 2023. The
            // following method must also work for future years. That is, make
            // use of the DateTime.Now property.
            string averageAgeInfo = town.AverageAgeOfAllBuildings_Linq();
            Assert.Equal(expected, averageAgeInfo);
        }

        [Theory]
        [InlineData(7000, 1883, 1.00, 0)]
        [InlineData(200, 183, 1000.00, 8213872)]
        [InlineData(7836, 1962, 150.00, 9929508)]
        public void Test3(int numBuildings, int seed, decimal salesValueInMillions, int expectedSqrMeters)
        {
            Town town = new Town("New York", 19.29);
            CreateRandomBuildings(town, numBuildings, seed, false);

            // Return the total number of square meters for all buildnings
            // having a sales value less than the value of the
            // salesValueInMillions parameter. This test does not require but
            // may use Linq!

            // Note that to compute the total number of square meters for a
            // Skyscraper, its square meters per floor must be multiplied by
            // its number of floors. Note that buildings, like power plants,
            // have a single floor.
            // Finally, note that your solution proposal should make use of
            // polymorphism.
            int actualSqrMeters = town.TotalNumberOfSquareMeters(salesValueInMillions);
            Assert.Equal(expectedSqrMeters, actualSqrMeters);
        }

        [Theory]
        [InlineData(3, 1733, 750.00, 48765)]
        [InlineData(6844, 1983, 1000.00, 123249.4)]
        [InlineData(2222, 222, 222.00, 125152.4)]
        public void Test4(int numBuildings, int seed, decimal salesValueInMillions, double expectedSqrMeters)
        {
            Town town = new Town("New York", 19.29);
            CreateRandomBuildings(town, numBuildings, seed, false);

            // Return the average number of total square meters of all
            // buildnings having a sales value greater than the value of the
            // salesValueInMillions parameter. This method does not require
            // but may use Linq!
            double actualSqrMeters = town.AverageNumberOfSquareMeters(salesValueInMillions);
            Assert.Equal(expectedSqrMeters, actualSqrMeters);
        }

        [Theory]
        [InlineData(3, 21, 1880, 2304.46933422618, 1494)]
        [InlineData(555, 23, 1880, 1385.88455920214, 2577)]
        [InlineData(7831, 2006, 1880, 1050.43012286645, 2831)]
        public void Test5(int numBuildings, int seed, int yearOfConstruction, decimal salesValueInMillions, int squareMetersPerFloor)
        {
            Town town = new Town("New York", 19.29);
            CreateRandomBuildings(town, numBuildings, seed, true);

            // Return the oldest building in the town.
            // If two or more of the oldest buildings have the same age,
            // return the buildning the has the highest sales value.
            // If two or more of these buidings have the same sales value,
            // return the first building having the smallest number of
            // square meters per floor (not the total square meters).
            Building oldestBuilding = town.GetTheOldestBuilding_Linq();
            Assert.Equal(yearOfConstruction, oldestBuilding.YearOfConstruction);
            Assert.Equal(salesValueInMillions, oldestBuilding.SalesValueInMillions);
            Assert.Equal(squareMetersPerFloor, oldestBuilding.SquareMetersPerFloor);
        }

        [Theory]
        [InlineData(3, 45, 2, 77812)]
        [InlineData(4286, 28, 1585, 327579307)]
        [InlineData(682, 83, 254, 48926736)]
        public void Test6(int numBuildings, int seed, int expectedRemoved, int expectedSqrMeters)
        {
            Town town = new Town("New York", 19.29);
            CreateRandomBuildings(town, numBuildings, seed, false);

            // Remove all buildnings that are 90 years old or older and
            // return the number of buildings that were removed. The method
            // DemolishBuildnings does not require but may use Linq! NOTE:
            // Although this test method assumes that the year is 2023. The
            // DemolishBuildnings() method must also work for future years.
            // That is, make use of the DateTime.Now property.
            int ageOfBuildning = 90;
            int actuallyRemoved = town.DemolishBuildnings(ageOfBuildning);
            int actualSqrMeters = town.TotalNumberOfSquareMeters(5000.00m);
            Assert.Equal(expectedRemoved, actuallyRemoved);
            Assert.Equal(expectedSqrMeters, actualSqrMeters);
        }

        // NOTE: The following method is NOT a test method but a helper method.
        // Please uncomment its code before running the Test2() method.
        private static void CreateRandomBuildings(Town town, int numBuildings, int seed, bool similar)
        {
            Random random = new Random(seed);

            int yearOfConstruction;
            decimal salesValueInMillions;
            int squareMetersPerFloor;
            int numberOfFloors;
            double tWhPerYear;

            for (int i = 0; i < numBuildings; i++)
            {
                yearOfConstruction = random.Next(1882, 2023 + 1);
                salesValueInMillions = (decimal)NextFloat(126.6, 2349.9);
                squareMetersPerFloor = random.Next(280, 3000 + 1);
                numberOfFloors = random.Next(32, 163 + 1);
                tWhPerYear = NextFloat(0.662, 183.2);

                if (random.Next(1, 100 + 1) < 25)
                    town.AddBuilding(BuildPowerPlant());
                else
                {
                    if (similar)
                    {
                        Skyscraper sky1 = new Skyscraper(1880, salesValueInMillions, squareMetersPerFloor, numberOfFloors);
                        town.AddBuilding(sky1);

                        Skyscraper sky2 = new Skyscraper(1880, salesValueInMillions + 1, squareMetersPerFloor, numberOfFloors);
                        town.AddBuilding(sky2);

                        Skyscraper sky3 = new Skyscraper(1880, salesValueInMillions + 1, squareMetersPerFloor - 1, numberOfFloors);
                        town.AddBuilding(sky3);

                        similar = false;
                    }
                    else
                        town.AddBuilding(BuildSkyscraper());
                }
            }

            Skyscraper BuildSkyscraper() =>
                new Skyscraper(yearOfConstruction, salesValueInMillions, squareMetersPerFloor, numberOfFloors);

            PowerPlant BuildPowerPlant() =>
                new PowerPlant(yearOfConstruction, salesValueInMillions, squareMetersPerFloor, tWhPerYear);

            double NextFloat(double min, double max)
            {
                double val = random.NextDouble() * (max - min) + min;
                return val;
            }
        }
    }
}