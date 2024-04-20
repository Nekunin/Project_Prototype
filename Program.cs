namespace Project_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Hero hero = new Hero(name);
            Enemy enemy = new Enemy();
            BattleMenu.gameLoop(hero, enemy);
            Console.WriteLine("Hello");
        }
    }
}
