using AbstractingRPGGame.src.Entities;

namespace AbstractingRPGGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight", 749, 72, 469, 72);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 574, 89, 292, 89);
            Wizard jenica = new Wizard("Jenica", 42, "White Wizard", 601, 482, 325, 474);
            Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 385, 641, 106, 611);
            
            Console.WriteLine(arus);
            Console.WriteLine(wedge);
            Console.WriteLine(jenica);
            Console.WriteLine(topapa);
            Console.WriteLine();

            Console.WriteLine(arus.Attack());
            Console.WriteLine(topapa.Attack(5));
            Console.WriteLine(jenica.Attack());
            Console.WriteLine(wedge.Attack(8));
        }
    }
}