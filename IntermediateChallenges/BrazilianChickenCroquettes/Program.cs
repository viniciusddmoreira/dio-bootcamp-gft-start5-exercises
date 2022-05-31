// Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

namespace BrazilianChickenCroquettes
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] line = Console.ReadLine().Split(" ");

            float A = Int32.Parse(line[0]);
            float B = Int32.Parse(line[1]);
            //TODO: Complete os espaços em branco com uma possível solução para o desafio        
            float total = (A / B);

            if (A % B != 0)
                Console.WriteLine(Math.Round(total, 2).ToString("0.00"));
            else
                Console.WriteLine(total.ToString("0.00"));
        }
    }
}