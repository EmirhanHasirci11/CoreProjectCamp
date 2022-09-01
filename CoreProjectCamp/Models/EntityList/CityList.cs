using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Models.EntityList
{
    public class CityList
    {
        public static List<City> GetCityList()
        {
            List<City> c = new List<City>();
            c.Add(new City()
            {
                CityID=1,
                CityName="Adana"
            });
            c.Add(new City()
            {
                CityID = 2,
                CityName = "Adıyaman"

            });
            c.Add(new City()
            {
                CityID = 3,
                CityName = "Afyon"
            });
            c.Add(new City()
            {
                CityID = 4,
                CityName = "Ağrı"
            });
            c.Add(new City()
            {
                CityID = 5,
                CityName = "Amasya"
            });
            c.Add(new City()
            {
                CityID = 6,
                CityName = "Ankara"
            });
            c.Add(new City()
            {
                CityID = 7,
                CityName = "Antalya"
            });
            c.Add(new City()
            {
                CityID = 8,
                CityName = "Artvin"
            });
            c.Add(new City()
            {
                CityID = 9,
                CityName = "Aydın"
            });
            c.Add(new City()
            {
                CityID = 10,
                CityName = "Balıkesir"
            });
            c.Add(new City()
            {
                CityID = 11,
                CityName = "Bilecik"
            });
            c.Add(new City()
            {
                CityID = 12,
                CityName = "Bingöld"
            });
            c.Add(new City()
            {
                CityID=13,
                CityName="Bitlis"
            });
            c.Add(new City()
            {
                CityID = 14,
                CityName = "Bolu"
            });
            c.Add(new City()
            {
                CityID = 15,
                CityName = "Burdur"
            });
            c.Add(new City()
            {
                CityID = 16,
                CityName = "Bursa"
            });
            c.Add(new City()
            {
                CityID = 17,
                CityName = "Çanakkale"
            });
            c.Add(new City()
            {
                CityID = 18,
                CityName = "Çankırı"
            });
            c.Add(new City()
            {
                CityID = 19,
                CityName = "Çorum"
            });
            c.Add(new City()
            {
                CityID = 20,
                CityName = "Denizli"
            });
            c.Add(new City()
            {
                CityID = 21,
                CityName = "Diyarbakır"
            });
            c.Add(new City()
            {
                CityID = 22,
                CityName = "Edirne"
            });
            c.Add(new City()
            {
                CityID = 23,
                CityName = "Elazığ"
            });
            c.Add(new City()
            {
                CityID = 24,
                CityName = "Erzincan"
            });
            c.Add(new City()
            {
                CityID = 25,
                CityName = "Erzurum"
            });
            c.Add(new City()
            {
                CityID = 26,
                CityName = "Eskişehir"
            });
            c.Add(new City()
            {
                CityID = 27,
                CityName = "Gaziantep"
            });
            c.Add(new City()
            {
                CityID = 28,
                CityName = "Giresun"
            });
            c.Add(new City()
            {
                CityID = 29,
                CityName = "Gümüşhane"
            });
            c.Add(new City()
            {
                CityID = 30,
                CityName = "Hakkari"
            });


            return c;
        }

    }
}
