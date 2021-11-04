using ConsoleApp1.Coords;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo herança de veículo:");
            ExemploVeiculo.Executar();

            Console.WriteLine("\nExemplo classes parciais Coordenadas:");
            ExemploCoordenadas.Executar();
        }
    }
}
