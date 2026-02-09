using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
                //DROBI
            Console.Write("Enter amount of fractions: ");
            int n = int.Parse(Console.ReadLine());

            List<Fraction> fractions = new();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Numerator {i + 1}: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write($"Denominator {i + 1}: ");
                int den = int.Parse(Console.ReadLine());

                fractions.Add(new Fraction
                {
                    Numerator = num,
                    Denominator = den
                });
            }

            XmlSerializer fracSerializer = new(typeof(List<Fraction>));

            using (FileStream fs = new("fractions.xml", FileMode.Create))
            {
                fracSerializer.Serialize(fs, fractions);
            }

            List<Fraction> loadedFractions;
            using (FileStream fs = new("fractions.xml", FileMode.Open))
            {
                loadedFractions = (List<Fraction>)fracSerializer.Deserialize(fs);
            }

            Console.WriteLine("\nLoaded Fractions:");
            foreach (var f in loadedFractions)
            {
                Console.WriteLine(f);
            }

           /*     //SHURNAL INFO
            Magazine magazine = new();

            Console.Write("\nTitle: ");
            magazine.Title = Console.ReadLine();

            Console.Write("Publisher: ");
            magazine.Publisher = Console.ReadLine();

            Console.Write("Release Date: ");
            magazine.ReleaseDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Amount of pages: ");
            magazine.Pages = int.Parse(Console.ReadLine());

            XmlSerializer magSerializer = new(typeof(Magazine));

            using (FileStream fs = new("magazine.xml", FileMode.Create))
            {
                magSerializer.Serialize(fs, magazine);
            }

            Magazine loadedMagazine;
            using (FileStream fs = new("magazine.xml", FileMode.Open))
            {
                loadedMagazine = (Magazine)magSerializer.Deserialize(fs);
            }

            Console.WriteLine("\nLoaded Magazine:");
            Console.WriteLine(loadedMagazine); */
        }
    }
}