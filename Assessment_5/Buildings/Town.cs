namespace Buildings
{
    public class Town
    {
        public string TownName { get; set; }
        public double InhabitantsInMillions { get; set; }
        List<Building> buildings = new List<Building>();

        List<string> TownNames { get; set; } = new List<string>();
        public string Description => $"{TownName} has approx. {Math.Round(InhabitantsInMillions, 1)} million inhabitants and {buildings.Count} buildings.";

        public Town(string townName, double inhabitantsInMillions)
        {
            TownName = townName;
            InhabitantsInMillions = inhabitantsInMillions;
            buildings = new List<Building>();
        }

        public void AddBuilding(Building building)
        {
            buildings.Add(building);
        }

        public string AverageAgeOfAllBuildings_Linq()
        {
            double averageAge = buildings.Average(b => DateTime.Now.Year - b.YearOfConstruction);

            return $"The average age of all buildings in {TownName} is {Math.Round(averageAge, 1)} years.";
        }

        public int TotalNumberOfSquareMeters(decimal salesValueInMillions)
        {
            var query = buildings
                .Where(b => b.SalesValueInMillions < salesValueInMillions)
                .Sum(b => b.TotalNumberOfSquareMeters);
            return query;



            // Return the total number of square meters for all buildnings
            // having a sales value less than the value of the
            // salesValueInMillions parameter. This test does not require but
            // may use Linq!
        }

        public double AverageNumberOfSquareMeters(decimal salesValueInMillions)
        {
            var query = buildings
                .Where(b => b.SalesValueInMillions > salesValueInMillions)
                .Average(b => b.TotalNumberOfSquareMeters);

            return Math.Round(query, 1);

            // Return the average number of total square meters of all
            // buildnings having a sales value greater than the value of the
            // salesValueInMillions parameter. This method does not require
            // but may use Linq!
        }

        public Building GetTheOldestBuilding_Linq()
        {
            var query = buildings
                .OrderBy(b => b.YearOfConstruction)
                .ThenByDescending(b => b.SalesValueInMillions)
                .ThenBy(b => b.SquareMetersPerFloor)
                .First();

            return query;
            

            // Return the oldest building in the town. If two or more of the oldest buildings have the same age,
            // return the buildning the has the highest sales value. If two or more of these buidings have the same sales value,
            // return the first building having the smallest number of square meters per floor (not the total square meters).
        }

        public int DemolishBuildnings(int ageOfBuildning)
        {
            var currentYear = DateTime.Now.Year;
            var remove = buildings
                .Where(b => currentYear - b.YearOfConstruction >= ageOfBuildning).Count();

            buildings.RemoveAll(b => currentYear - b.YearOfConstruction >= ageOfBuildning);

            return remove;


            // Remove all buildnings that are 90 years old or older and return the number of buildings that were removed. The method
            // DemolishBuildnings does not require but may use Linq! NOTE: Although this test method assumes that the year is 2023. The
            // DemolishBuildnings() method must also work for future years. That is, make use of the DateTime.Now property.
        }
    }
}
