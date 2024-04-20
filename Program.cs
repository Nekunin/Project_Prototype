namespace Project_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HealingPotion p1 = new HealingPotion();
            Hero player = new Hero();
            player.HP = 25;
            Console.WriteLine("Current hp: {0}", player.HP);
            p1.Consume(player);
            Console.WriteLine("Used healing potion: {0}", player.HP);
            p1.Consume(player);
            Console.WriteLine("Used healing potion: {0}", player.HP);
        }
    }
}
