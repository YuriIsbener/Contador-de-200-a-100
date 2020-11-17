using System;

namespace Contador_de_200_a_100
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Conte comigo");

            for(var contador = 200; contador >= 100; contador--)
            {
                Console.WriteLine(contador);
            }
        }
    }
}
