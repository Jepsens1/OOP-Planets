using System;
using System.Collections.Generic;

namespace OOP_Planets
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Planet> planets = new List<Planet>();
            planets.Add(new Planet("Merkur", 0.330, 4879, 5427, 3.7, TimeSpan.FromHours(1407.6), TimeSpan.FromHours(4222.6), 57.9, TimeSpan.FromDays(88), 47.4, 167, 0, false));
            planets.Add(new Planet("Venus", 4879, 12.104, 5243, 8.9, TimeSpan.FromHours(-5832.5), TimeSpan.FromHours(2802), 108, TimeSpan.FromDays(224.7), 35.0, 464, 0, false));
            planets.Add(new Planet("Earth", 5.97, 12.756, 5514, 9.8, TimeSpan.FromHours(23.9), TimeSpan.FromHours(24), 149.6, TimeSpan.FromDays(365.2), 29.8, 15, 1, false));
            planets.Add(new Planet("Mars", 0.642, 6792, 3933, 3.7, TimeSpan.FromHours(24.6), TimeSpan.FromHours(24.7), 227.9, TimeSpan.FromDays(687.0), 24.1, -65, 2, false));
            planets.Add(new Planet("Jupiter", 1898, 142.984, 1326, 23.1, TimeSpan.FromHours(9.9), TimeSpan.FromHours(9.9), 778.6, TimeSpan.FromDays(4331), 13.1, -110, 67, true));
            planets.Add(new Planet("Sarturn", 568, 120.536, 687, 9.0, TimeSpan.FromHours(10.7), TimeSpan.FromHours(10.7), 1433.5, TimeSpan.FromDays(10.747), 9.7, -140, 62, true));
            planets.Add(new Planet("Uranus", 86.8, 51.118, 1271, 8.7, TimeSpan.FromHours(-17.2), TimeSpan.FromHours(17.2), 2872.5, TimeSpan.FromDays(30.589), 6.8, -195, 27, true));
            planets.Add(new Planet("Neptune", 102, 49.528, 1638, 11.0, TimeSpan.FromHours(16.1), TimeSpan.FromHours(16.1), 2872.5, TimeSpan.FromDays(59.8), 5.4, -200, 14, true));
            planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, TimeSpan.FromHours(-153.3), TimeSpan.FromHours(153.3), 5906.4, TimeSpan.FromDays(90.56), 4.7, -255, 5, false));

            planets.RemoveAt(8);
            planets.Insert(8, new Planet("Pluto", 0.0146, 2370, 2095, 0.7, TimeSpan.FromHours(-153.3), TimeSpan.FromHours(153.3), 5906.4, TimeSpan.FromDays(90.56), 4.7, -255, 5, false));
            List<Planet> planets2 = new List<Planet>();
            List<Planet> planets3 = new List<Planet>();
            foreach (Planet planet in planets)
            {
               if (planet.MeanTemperature < 0)
               {
                    planets2.Add(planet);
                   
               }
               if (planet.Diameter > 10.000 && planet.Diameter < 50.000)
                {
                    planets3.Add(planet);
                }
                Console.WriteLine(planet.Name);

            }
            Console.WriteLine();
            foreach (Planet planet1 in planets2)
            {
                Console.WriteLine(planet1.Name);
            }
            Console.WriteLine();
            foreach (Planet planet2 in planets3)
            {
                Console.WriteLine(planet2.Name);
                //Fjerner alle planeter fra listen
                //planets3.Remove(planet2);
            }
            


        }
    }
}
