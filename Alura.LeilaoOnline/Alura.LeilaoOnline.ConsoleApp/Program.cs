using System;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        private static void Verifica(double esperado, double obtido)
        {
            var cor = Console.ForegroundColor;

            if (esperado == obtido)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TESTE OK " + obtido);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TESTE FALHO! Esperado: {esperado}, obtido: {obtido}");
            }
            Console.ForegroundColor = cor;
        }

        static void Main()
        {

            //LeilaoComVariosLances();
            //LeilaoComApenasUmLance();

        }

    }
}
