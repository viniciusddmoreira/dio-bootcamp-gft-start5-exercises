﻿namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;

            do
            {
                Console.WriteLine("Digite um valor, 0 para sair");
                valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    Console.WriteLine("Você saiu da aplicação");
                    break;
                }
                else
                {
                    Console.WriteLine("O valor informado é: " + valor);
                    continue;
                }
            } while (condicao == true);
        }
    }
}