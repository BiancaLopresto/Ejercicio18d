using System;

namespace Ejercicio18d.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Kilometros;
            double Millas;
            double Yardas;

            Console.Write("Ingrese los Kilometros: ");
            Kilometros= int.Parse(Console.ReadLine());

            if (Kilometros <= 0)
            {
                Console.Write("El kilometro debe ser mayor a cero");
            }else
            {
                Millas = Kilometros * 0.621371192;
                Yardas = Kilometros * 1093.6133;
                Console.Write($"Las Millas son {Millas} ");
                Console.Write($"Las Yardas son {Yardas}");
                

            }
            
            
            int N;
            double formula;

            Console.Write("Ingrese el numero N: ");
            N= int.Parse(Console.ReadLine());

            if (N > 0)
            {
                formula = (N * (N + 1)) / 2;
                Console.WriteLine($"La suma de este numero {N} es {formula}");
            }else
            {
                Console.WriteLine("N debe ser mayor que cero");
            }
        }
    }
}