using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//namespace Project_Prototype
//{
//    public class BattleMenu
//    {
//        public static void gameLoop(Hero player, MinorEnemy monster)
//        {
//            int playerChoice = 0;
//            do
//            {
//                Console.Clear();
//                Console.WriteLine("Enter 1 to attack, 2 to heal, 3 to check info");

//                try
//                {
//                    playerChoice = int.Parse(Console.ReadLine());
//                }
//                catch
//                {
//                    playerChoice = 0;
//                }

//                if (playerChoice == 1)
//                {
//                    Console.Clear();
//                    Console.WriteLine("You attacked!");
//                    Console.WriteLine("You dealt {0} dmg", player.GiveDamage());
//                    monster.TakeDamage(player.GiveDamage());
//                    Console.ReadKey();
//                    if (monster.HP > 0)
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Enemy attacked!");
//                        Console.WriteLine("You took {0} dmg", monster.GiveDamage());
//                        player.TakeDamage(monster.GiveDamage());
//                        Console.ReadKey();
//                    }
//                }
//                else if (playerChoice == 2 || playerChoice == 2)
//                {
//                    //consume potion
//                }
//                else if (playerChoice == 3)
//                {
//                    Console.Clear();
//                    Console.WriteLine("{0}'s info", player.Name);
//                    Console.WriteLine("HP: {0}/{1}", player.HP, player.MaxHP);
//                    Console.ReadKey();
//                }
//            } while (player.HP > 0 && monster.HP > 0);

//            Console.Clear();
//            Console.WriteLine("Battle is over!");
//            Console.WriteLine(player.HP > 0 ? "You win!" : "{0} has succumbed to their wounds", player.Name);
//            Console.ReadKey();
//        }
//        public int HeroPhysicalAttack(Hero MainChara, MinorEnemy x)
//        {
//            int physicaldamage = (MainChara.STR + Weapon.STR) - x.END;
//            return physicaldamage > 0 ? physicaldamage : 0;

//        }
//        public int HeroMagicalAttack(Hero MainChara, MinorEnemy x)
//        {
//            int magicaldamage = (MainChara.INT + MainChara.MATK + Weapon.INT + Weapon.MATK) - x.RES;
//            return magicaldamage >0 ? magicaldamage : 0;
//        }


//    }
//}
