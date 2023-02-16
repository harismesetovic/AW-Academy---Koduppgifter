using System;

namespace Assessments.Hotels
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public int Pools { get; set; }

        public Hotel(string hotelName, int pools)
        {
            HotelName = hotelName;
            Pools = pools;
        }


        public virtual string GetHotelDescription()
        {
            return $"{HotelName} is a standard hotel having {Pools} {(Pools == 1 ? "pool" : "pools")}.";

            //// The GetHotelDescription() method must be polymorphic.
            //string hotelDescription = hotel.GetHotelDescription();
            //Assert.Equal("CC is a standard hotel having 3 pools.", hotelDescription);
        }

        public void AddRoomType()
        {
            
        }
    }

}
