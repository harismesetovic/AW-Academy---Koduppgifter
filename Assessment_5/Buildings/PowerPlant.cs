namespace Buildings
{
    public class PowerPlant : Building
    {
        public double TWhPerYear { get; set; }
        public override int TotalNumberOfSquareMeters { get; set; }

        public PowerPlant(int yearOfConstruction, decimal salesValueInMillions, int squareMetersPerFloor, double tWhPerYear) : base(yearOfConstruction, salesValueInMillions, squareMetersPerFloor)
        {
            TWhPerYear= tWhPerYear;
            TotalNumberOfSquareMeters= squareMetersPerFloor;
        }
    }
}