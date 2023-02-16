using System;
using Xunit;

namespace Assessments.Hotels.Tests
{
    // A test method (decorated with [Fact] or [Theory]) will become green in
    // the Test Explorer window if ALL Assert() calls within the test method pass.

    // To debug a test method you set a breakpoint (F9) in the test method, then
    // right click the test method in the Test Explorer window and select
    // the Debug option.

    public class Level2Tests
    {
        // Note: keep in mind that the RoomType-enum in the future may change
        // and your methods should keep on working.

        [Fact]
        public void GrandHotel()
        {
            throw new NotImplementedException(); // NOTE!!! Delete this line, then:
                                                 // Step-by-step, uncomment the other lines in this method
                                                 // (in order to deal with one compiler error at a time).

            //var hotel = new Hotel("Grand Hotel", 2);

            //hotel.AddRoomType("Adult");
            //hotel.AddRoomType("Family");
            //hotel.AddRoomType("Senior");

            //Assert.True(hotel.HasRoomType(RoomType.Adult));
            //Assert.True(hotel.HasRoomType(RoomType.Family));
            //Assert.True(hotel.HasRoomType(RoomType.Senior));

            //Assert.Equal("Grand Hotel is a standard hotel having 2 pools.", hotel.GetHotelDescription());
        }

        [Fact]
        public void HotelStallmästaregården()
        {
            throw new NotImplementedException(); // NOTE!!! Delete this line, then:
                                                 // Step-by-step, uncomment the other lines in this method
                                                 // (in order to deal with one compiler error at a time).

            //var hotel = new Hotel("Stallmästaregården", 5);
            //hotel.AddRoomType("Family");
            //hotel.AddRoomType("Senior");

            //Assert.True(hotel.HasRoomType(RoomType.Senior));
            //Assert.True(hotel.HasRoomType(RoomType.Family));

            //Assert.Equal("Stallmästaregården is a standard hotel having 5 pools.", hotel.GetHotelDescription());
        }

        [Fact]
        public void CantAddSameRoomTypeTwice()
        {
            throw new NotImplementedException(); // NOTE!!! Delete this line, then:
                                                 // Step-by-step, uncomment the other lines in this method
                                                 // (in order to deal with one compiler error at a time).

            //var hotel = new Hotel("Nobis", 5);

            //hotel.AddRoomType("Family");
            //hotel.AddRoomType("Senior");

            //Assert.Throws<ArgumentException>(() => hotel.AddRoomType("Family"));
        }

        [Fact]
        public void CantAddRoomTypeThatDoesntExist()
        {
            throw new NotImplementedException(); // NOTE!!! Delete this line, then:
                                                 // Step-by-step, uncomment the other lines in this method
                                                 // (in order to deal with one compiler error at a time).

            //var hotel = new Hotel("Victory", 5);
            //Assert.Throws<ArgumentException>(() => hotel.AddRoomType("Familyyyyyyyyyyy"));
        }
    }
}
