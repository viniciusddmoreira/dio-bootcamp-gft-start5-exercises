//Abaixo segue um exemplo de código que você pode ou não utilizar

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            
//TODO: Complete os espaços em branco com uma possível solução para o desafio
            double media = (A*0.2)+(B*0.3)+(C*0.5);
            Console.WriteLine($"MEDIA = {media.ToString("0.0")}");
            Console.ReadKey();
        }
    }
}