using System.Runtime.CompilerServices;

namespace Project_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            myGame.start();

            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Hero hero = new Hero();
            hero.Name = name;
            MinorEnemy enemy = new MinorEnemy();
            BattleMenu.gameLoop(hero, enemy);
        }
    }
}
