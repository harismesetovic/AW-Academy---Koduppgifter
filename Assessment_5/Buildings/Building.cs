namespace Buildings
{
    public abstract class Building
    {
        public Building(int yearOfConstruction, decimal salesValueInMillions, int squareMetersPerFloor)
        {
            YearOfConstruction= yearOfConstruction;
            SalesValueInMillions= salesValueInMillions;
            SquareMetersPerFloor= squareMetersPerFloor;
        }

        public int YearOfConstruction { get; set; }
        public decimal SalesValueInMillions { get; set; }
        public int SquareMetersPerFloor { get; set; }
        public virtual int TotalNumberOfSquareMeters { get; set; }

    }
}
