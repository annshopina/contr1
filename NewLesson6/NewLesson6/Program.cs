using System;

namespace NewLesson6
{

    class MainClass
    {
        public struct City
        {
            public string Name;
            public int Population;
            public int Density;
        }

        public static void Main(string[] args)
        {

            string Userdata = Console.ReadLine();
            string[] CityInfo = Userdata.Split(';');

            City[] cities = new City[CityInfo.Length];
            int citynum = 0;
            for (var i = 0; i < CityInfo.Length; i++)
            {
                string[] cityParts = CityInfo[i].Split('=');
                cities[citynum] = new City();
                cities[citynum].Name = cityParts[0];
                string[] cityData = cityParts[1].Split(',');

                cities[citynum].Population = Int32.Parse(cityData[0]);
                cities[citynum].Density = Int32.Parse(cityData[1]);
                Console.WriteLine(cities[citynum].Density);
                Console.WriteLine(cities[citynum].Population);
                Console.WriteLine(cities[citynum].Name);
                citynum++;
            }
            int maxPopulation = cities[0].Population;
            int maxPopulationIndex = 0;

            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i].Population > maxPopulation)
                {
                    maxPopulation = cities[i].Population;
                    maxPopulationIndex = i;
                }
                Console.WriteLine(maxPopulation);

            }
        }
    }
}




        
       
    
