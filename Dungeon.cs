using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    internal class Dungeon
    {
        private MinorEnemyManager enemyManager;
        private int currentFloor;
        private int Goal;
        public Dungeon(Hero MainChara, int Goal)
        {

            enemyManager = new MinorEnemyManager();
            int currentFloor = 1;
            this.Goal = Goal;
            while (currentFloor <= Goal)
            {
                Console.WriteLine("Forest of Despair");
                Console.WriteLine($"Floor: [{currentFloor}/{Goal}]");
                Console.ReadLine();

                //dungeon menu creation
                string prompt = "Forest of Despair";
                string[] options = { "Advance", "Rest", "Inventory", "Retreat" };
                Menu DungeonMenu = new Menu(prompt, options);
                int selectedIndex = DungeonMenu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        if (Advance())
                        {
                            Console.WriteLine("You reached the next floor without having to fight");
                            currentFloor++;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            //enemy will be selected from a random list
                            Console.WriteLine("You encountered an enemy!");
                            Console.ReadLine();
                            MinorEnemy enemy = enemyManager.GetRandomEnemy();
                            Battle battle = new Battle(MainChara, enemy);
                            if (MainChara.HP <= 0)
                            {
                                //Closes the game if you die
                                Console.WriteLine("You have succumbed to your wounds.");
                                Console.ReadLine();
                                ExitGame();
                                return;
                            }   
                            currentFloor++;
                            Console.WriteLine("You defeated the enemy!");
                            enemy.HP = enemy.MaxHP;
                            if (currentFloor == 50)
                            {
                                Console.Clear();
                                Console.WriteLine("You win!");
                                Console.ReadLine();
                                ExitGame();
                            }
                            Console.ReadLine();
                        }
                        break;
                    case 1:
                        if (Rest())
                        {
                        Console.WriteLine("You took a short rest. HP and MP recovered.");
                        MainChara.HP += (int)(MainChara.MaxHP * 0.2);
                        MainChara.MP += (int)(MainChara.MaxMP * 0.2);
                            if (MainChara.HP > MainChara.MaxHP)
                        {
                            MainChara.HP = MainChara.MaxHP;
                        }
                            if (MainChara.MP > MainChara.MaxMP)
                        {
                            MainChara.MP = MainChara.MaxMP;
                        }
                        Console.WriteLine("{0}/{1}", MainChara.HP, MainChara.MaxHP);
                        Console.ReadLine();
                        }
                        else
                        {
                            //enemy will be selected from a random list
                            Console.WriteLine("An enemy found you!");
                            Console.ReadLine();
                            MinorEnemy enemy = enemyManager.GetRandomEnemy();
                            Battle battle = new Battle(MainChara, enemy);
                            if (MainChara.HP <= 0)
                            {
                                //Closes the game if you die
                                Console.WriteLine("You have succumbed to your wounds.");
                                Console.ReadLine();
                                ExitGame();
                                return;
                            }
                            Console.WriteLine("You defeated the enemy!");
                            enemy.HP = enemy.MaxHP;
                        }
                        break;
                    case 2:
                        Inventory_Equipment.Inventory(MainChara);
                        break;
                    case 3:
                        Story2.Town(MainChara);
                        return;
                }
                static void ExitGame()
                {
                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadKey();
                    //Close the console app 
                    Environment.Exit(0);
                }
            }
        }
        private bool Advance()
        {
            Random random = new Random();
            int chance = random.Next(1, 101);
            return chance <= 40;
        }
        private bool Rest()
        {
            Random random = new Random();
            int chance = random.Next(1, 101);
            return chance <= 70;
        }
        public class MinorEnemyManager
        {
            private List<MinorEnemy> CommonEnemies;
            private MinorEnemy DeathMark;
            private Random random;

            public MinorEnemyManager()
            {
                CommonEnemies = new List<MinorEnemy>();
                random = new Random();
                DeathMark = new MinorEnemy("DEATH", 900, 900, 300, 300, 300, 300, 300, 300, 999);
                EnemyCreator();
            }
            public void EnemyCreator()
            {
                CommonEnemies.Add(new MinorEnemy("Goblin", 25, 0, 3, 4, 0, 2, 0, 9, 2));
                CommonEnemies.Add(new MinorEnemy("Skeleton", 20, 5, 5, 2, 3, 10, -3, 3, 0));
                CommonEnemies.Add(new MinorEnemy("Orc", 30, 0, 20, 6, 0, 23, 5, -3, 5));
                CommonEnemies.Add(new MinorEnemy("Kobold", 25, 10, 5, 4, 4, 4, 5, 18, 7));
                CommonEnemies.Add(new MinorEnemy("Bandit", 20, 10, 10, 10, 10, 5, 13, 9, 13));
                CommonEnemies.Add(new MinorEnemy("Shadow", 80, 23, 22, 17, 13, 9999, -20, -5, 10));
                CommonEnemies.Add(new MinorEnemy("Treant", 20, 10, 14, 14, 9, 35, -5, 0, 2));

            }
            public MinorEnemy GetRandomEnemy()
            {
                int LuckUnluck = random.Next(1, 51);
                if (LuckUnluck == 6)
                {
                    return DeathMark;
                }
                else
                {
                    return CommonEnemies[random.Next(CommonEnemies.Count)];
                }

            }
        }
    }
}