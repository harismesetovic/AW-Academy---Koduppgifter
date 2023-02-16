using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessments.Hotels
{
    public class City
    {
        public string city { get; set; }
        List<Hotel> hotels { get; set; }



        public City(string city)
        {
            this.city = city;
            hotels = new List<Hotel>();
        }

        public void AddToListOfHotels(string hotelName, int pools)
        {
            Hotel hotel = new Hotel(hotelName, pools);
            hotels.Add(hotel);
        }
        public void AddToListOfHotels(string hotelName, int pools, string headButlerName)
        {
            LuxuryHotel luxuryHotel = new LuxuryHotel(hotelName, pools, headButlerName);
            hotels.Add(luxuryHotel);
        }

        public Hotel GetHotel_Linq(string hotelName)
        {
            var h = hotels
                .Where(h => h.HotelName == hotelName)
                .FirstOrDefault();
            return h;
        }

        public int TotalNumberOfPools_No_Linq()
        {
            int allPools = 0;
            foreach (Hotel hotel in hotels)
            {
                allPools += hotel.Pools;
            }
            return allPools;
        }

        public int TotalNumberOfPools_Linq()
        {
            return hotels
                .Sum(h => h.Pools);
        }

        public string[] HotelNames_No_Linq()
        {
            string[] hNames = new string[hotels.Count];
            for (int i = 0; i < hotels.Count; i++)
            {
                hNames[i] = hotels[i].HotelName;
            }
            return hNames;
        }

        public List<string> HotelNames_Linq()
        {
            return hotels
                .Select(h => h.HotelName).ToList();
        }

        public int MaxPools_No_Linq()
        {
            int maximumPools = 0;
            foreach (var hotel in hotels)
            {
                if (hotel.Pools > maximumPools)
                {
                    maximumPools = hotel.Pools;
                }
            }
            return maximumPools;
        }

        public int MaxPools_Linq()
        {
            return hotels
                .Max(h => h.Pools);
        }
    }
}
