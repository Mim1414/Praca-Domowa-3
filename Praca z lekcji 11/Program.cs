using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Praca_z_lekcji_11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                Console.WriteLine("Uzytkowniku podaj liczbe a ja odpowiem czy jest parzysta czy może nie");
                var UserNumber = int.Parse(Console.ReadLine());
                    if ((UserNumber % 2) == 0)
                    {
                        Console.WriteLine($"Liczba {UserNumber} jest Parzysta");

                    }
                    else
                    {
                        Console.WriteLine($"Liczba {UserNumber} jest Nieparzysta");
                    };

            }
            catch(Exception)
            {
               Console.WriteLine("Podane dane nie są tylko liczbami.\nPodaj liczbę następnym razem." );
            }
            finally 
            {
                Console.ReadLine();
            }
        }
    }
}
