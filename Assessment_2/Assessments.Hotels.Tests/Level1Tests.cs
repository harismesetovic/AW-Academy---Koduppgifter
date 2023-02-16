using System;
using System.Collections.Generic;
using Xunit;

namespace Assessments.Hotels.Tests
{
    // A test method (decorated with [Fact] or [Theory]) will become green in
    // the Test Explorer window if ALL Assert() calls within the test method pass.

    // To debug a test method you set a breakpoint (F9) in the test method, then
    // right click the test method in the Test Explorer window and select
    // the Debug option.

    public class Level1Tests
    {
        [Fact]
        public void DestinationStockholm()
        {
            // Create a city with the namn Stockholm
            var city = new City("Stockholm");

            // Add two hotels and one luxury hotel to the city.

            // The hotel "Berns" has 2 pools and is a hotel.
            city.AddToListOfHotels("Berns", 2);

            // The hotel "Skeppsholmen" has 1 pool and is a hotel.
            city.AddToListOfHotels("Skeppsholmen", 1);

            // The hotel "Grand" has 3 pools, is a luxury hotel,
            // and has a head butler named Reginald Jeeves.
            // Note: that all hotels should be added to a single list of hotels.
            city.AddToListOfHotels("Grand", 3, "Reginald Jeeves"); // Note: Overloaded method!

            // The method GetHotel_Linq() must use Linq.
            Hotel hotel = city.GetHotel_Linq("Grand");

            // Assert that the run-time type of the hotel variable is a LuxuryHotel instance.
            Assert.IsType<LuxuryHotel>(hotel);

            // Assert that the run-time type of hotel "Berns" is a Hotel instance.
            hotel = city.GetHotel_Linq("Berns");
            Assert.IsType<Hotel>(hotel);

            // Assert that GetHotel_Linq() returns null for a non-existing hotel.
            hotel = city.GetHotel_Linq("Under Construction Hotel");
            Assert.Null(hotel);

            // There are 2 + 1 + 3 = 6 pools in the city hotels.
            // Create two methods. One of the methods should use Linq and the other not.
            int numberOfPools = city.TotalNumberOfPools_No_Linq();
            Assert.Equal(6, numberOfPools);

            numberOfPools = city.TotalNumberOfPools_Linq();
            Assert.Equal(6, numberOfPools);

            // HotelNames should return a collection of all hotel names
            // Create two methods. One of the methods should use Linq and the other not.

            string[] hotelNames = city.HotelNames_No_Linq();
            List<string> hotelNames_Linq = city.HotelNames_Linq();

            Assert.Equal(3, hotelNames.Length);
            Assert.Equal("Berns", hotelNames[0]);
            Assert.Equal("Skeppsholmen", hotelNames[1]);
            Assert.Equal("Grand", hotelNames[2]);

            //// The following checks that "HotelNames_Linq" also returns correct values
            Assert.Equal(hotelNames, hotelNames_Linq);

            // "MaxPools" should tell the maximum number of pools found in a hotel in the city.
            // Create two methods. One of the methods should use Linq and the other not.
            int maximumNumberOfPools = city.MaxPools_No_Linq();
            Assert.Equal(3, maximumNumberOfPools);

            maximumNumberOfPools = city.MaxPools_Linq();
            Assert.Equal(3, maximumNumberOfPools);
        }

        [Fact]
        public void Destination_yyy()
        {
            var city = new City("yyy");
            city.AddToListOfHotels("AA", 20);
            city.AddToListOfHotels("BB", 19);

            Assert.Equal(39, city.TotalNumberOfPools_No_Linq());
            Assert.Equal(39, city.TotalNumberOfPools_Linq());

            var hotelNames = city.HotelNames_No_Linq();
            var hotelNames_Linq = city.HotelNames_Linq();

            Assert.Equal(2, hotelNames.Length);
            Assert.Equal("AA", hotelNames[0]);
            Assert.Equal("BB", hotelNames[1]);

            Assert.Equal(hotelNames, hotelNames_Linq);
            Assert.Equal(20, city.MaxPools_No_Linq());
            Assert.Equal(20, city.MaxPools_Linq());
        }

        [Fact]
        public void Destination_zzz()
        {
            var city = new City("zzz");
            city.AddToListOfHotels("AA", 1);
            city.AddToListOfHotels("BB", 12, "Charles Carson");
            city.AddToListOfHotels("CC", 3);
            city.AddToListOfHotels("DD", 1, "Geoffrey Butler");

            Assert.Equal(17, city.TotalNumberOfPools_No_Linq());
            Assert.Equal(17, city.TotalNumberOfPools_Linq());

            var hotelNames = city.HotelNames_No_Linq();
            var hotelNames_Linq = city.HotelNames_Linq();

            Assert.Equal(4, hotelNames.Length);
            Assert.Equal("AA", hotelNames[0]);
            Assert.Equal("BB", hotelNames[1]);
            Assert.Equal("CC", hotelNames[2]);
            Assert.Equal("DD", hotelNames[3]);

            Assert.Equal(hotelNames, hotelNames_Linq);

            Assert.Equal(12, city.MaxPools_No_Linq());
            Assert.Equal(12, city.MaxPools_Linq());

            Hotel hotel = city.GetHotel_Linq("CC");

            // The GetHotelDescription() method must be polymorphic.
            string hotelDescription = hotel.GetHotelDescription();
            Assert.Equal("CC is a standard hotel having 3 pools.", hotelDescription);

            hotel = city.GetHotel_Linq("DD");
            Assert.Equal("DD is a luxury hotel having 1 pool and a head butler named Geoffrey Butler.", hotel.GetHotelDescription());

            hotel = city.GetHotel_Linq("AA");
            Assert.Equal("AA is a standard hotel having 1 pool.", hotel.GetHotelDescription());

            hotel = city.GetHotel_Linq("BB");
            Assert.Equal("BB is a luxury hotel having 12 pools and a head butler named Charles Carson.", hotel.GetHotelDescription());
        }
    }
}