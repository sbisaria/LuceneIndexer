using System.Collections.Generic;
using System.Linq;

namespace MvcLuceneSampleApp.Search
{
    public class HotelData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public static HotelData Get(int id)
        {
            return GetAll().SingleOrDefault(x => x.Id.Equals(id));
        }
        public static List<HotelData> GetAll()
        {
            return new List<HotelData> {
        new HotelData {Id = 1, Name = "Hayat",Type="Hotel", Description = "A Five Star Hotel"},
        new HotelData {Id = 2, Name = "Conrad",Type="Hotel", Description = "Luxury Hotel"},
        new HotelData {Id = 3, Name = "Holiday-In",Type="Hotel", Description = "A Five Star Hotel"},
        new HotelData {Id = 4, Name = "Country-In",Type="Hotel", Description = "Luxury Hotel"},
        new HotelData {Id = 5, Name = "Clarks-In",Type="Hotel", Description = "Luxury Hotel"},
    };
        }
    }
}