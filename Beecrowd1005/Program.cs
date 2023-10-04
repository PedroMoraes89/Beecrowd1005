using System;
using System.Globalization;

namespace Beecrowd {
    class Program1005 {
        static void Main(string[] args)
        {
            double NotaA, NotaB, PesoA, PesoB, Media;

            NotaA = double.Parse(Console.ReadLine());
            NotaB = double.Parse(Console.ReadLine());

            PesoA = 3.5;
            PesoB = 7.5;

            Media = ((NotaA * PesoA) + (NotaB * PesoB)) / (PesoA + PesoB);

            Console.WriteLine("MEDIA = " +  Media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}