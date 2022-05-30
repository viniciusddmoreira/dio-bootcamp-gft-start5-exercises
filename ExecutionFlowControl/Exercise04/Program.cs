namespace Exercise04
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
                    if (valor < 10)
                    {
                        continue;
                    }
                    Console.WriteLine("O valor é maior que o número 10");
                }
            } while (condicao == true);
        }
    }
}