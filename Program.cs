﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace szemelyazonosito
{
    internal class Program
    {
        public static void Szemelyazonosito()
        {
            Console.Write("Adja meg a személyazonosítójának az első 10 jegyét: ");
            var szemszam = Console.ReadLine();
            string Szulsorszam = szemszam.Substring(7, 3);
            int ev = DateTime.Now.Year;

            if (szemszam[0] % 2 == 0)
            {
                Console.WriteLine("A személy nő nemű");
            }
            else
            {
                Console.WriteLine("A személy férfi nemű");
            }

            Console.WriteLine($"A születési sorszám: {Szulsorszam}");

            int szulEv = 1900 + int.Parse(szemszam.Substring(1, 2));
            if (szemszam[0] == '3' || szemszam[0] == '4');
            {
                szulEv += 100;
            }

            int szuletesnap = ev - szulEv;
            Console.WriteLine($"Ez a személy {szuletesnap} születésnapját ünnepli ebben az évben.");
            Console.WriteLine("");
        }

        public static void Szemelyazonosito2()
        {
            Console.Write("Adja meg a személyazonosítójának az első 10 jegyét: ");
            int szulEv1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adjon meg egy másik személyazonosítónak az első 10 jegyét: ");
            int szulEv2 = Convert.ToInt32(Console.ReadLine());

            if (szulEv1 > szulEv2)
            {
                Console.WriteLine("Az 1. személy idősebb.");
            }
            else if (szulEv1 < szulEv2)
            {
                Console.WriteLine("A 2. személy idősebb.");
            }
            else
            {
                Console.WriteLine("A két személy egykorú");
            }
               
            
        }

        static void Main(string[] args)
        {
            Szemelyazonosito();
            Szemelyazonosito2();
        }
    }
}
