using Assessments.Hotels;

public class LuxuryHotel : Hotel
{
    public string HeadButlerName { get; set; }

    public LuxuryHotel(string hotelName, int pools, string headButlerName) : base(hotelName, pools)
    {
        HeadButlerName = headButlerName;
    }

    public override string GetHotelDescription()
    {
        return $"{HotelName} is a luxury hotel having {Pools} {(Pools == 1 ? "pool" : "pools")} and a head butler named {HeadButlerName}.";

        //hotel = city.GetHotel_Linq("DD");
        //Assert.Equal("DD is a luxury hotel having 1 pool and a head butler named Geoffrey Butler.", hotel.GetHotelDescription());
    }
}