namespace Buildings
{
    public class Skyscraper : Building
    {
        public int NumberOfFloors { get; set; }

        public override int TotalNumberOfSquareMeters { get; set; }

        public Skyscraper(int yearOfConstruction, decimal salesValueInMillions, int squareMetersPerFloor, int numberOfFloors) : base(yearOfConstruction, salesValueInMillions, squareMetersPerFloor)
        {
            NumberOfFloors= numberOfFloors;
            TotalNumberOfSquareMeters = squareMetersPerFloor * numberOfFloors;
        }
    }
}
