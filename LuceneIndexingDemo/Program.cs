using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcLuceneSampleApp.Search;

namespace LuceneIndexingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HotelData> hotelList = HotelData.GetAll();
            LuceneSearch.AddUpdateLuceneIndex(hotelList);
            while (true)
            {
                Console.WriteLine("Enter a search query for hotels...");
                string querry = Console.ReadLine();
                IEnumerable<HotelData> hotelResults = LuceneSearch._search(querry);
                if (hotelResults.Count<HotelData>() > 0)
                {
                    Console.WriteLine($"{hotelResults.Count<HotelData>()} Record(s) found are listed below:\n");
                    int i = 1;
                    foreach (HotelData hotel in hotelResults)
                    {
                        Console.WriteLine($"\nRecord: {i++}\n");
                        Console.WriteLine($"Name : {hotel.Name}\nType : {hotel.Type}\nDescription : {hotel.Description}");
                    }
                }
                else Console.WriteLine("No such record found");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
