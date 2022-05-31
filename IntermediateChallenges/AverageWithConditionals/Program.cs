//Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

namespace AverageWithConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, avg;
            string[] values = Console.ReadLine().Split(' ');
            //TODO: Complete os espaços em branco com uma possível solução para o desafio
            a = double.Parse(values[0]) * 0.2;
            b = double.Parse(values[1]) * 0.3;
            c = double.Parse(values[2]) * 0.4;
            d = double.Parse(values[3]) * 0.1;

            avg = (a + b + c + d);
            Console.WriteLine("Media: " + avg.ToString("0.0"));
            if (avg >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            if (avg < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            if (avg >= 5 && avg <= 6.9)
            {
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine($"Nota do exame: {e.ToString("0.0")}");
                avg = (avg + e) / 2;
                if (avg >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                if (avg < 5)
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine("Media final: " + avg.ToString("0.0"));
            }

            Console.ReadKey();
        }
    }
}