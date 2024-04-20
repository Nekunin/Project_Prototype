using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Project_Prototype
{
    public class BattleMenu
    {
        public static void checkChoice(int c)
        {
            Console.Clear();
            switch(c)
            {
                case 1:
                    Console.WriteLine("You attacked");
                    break;
                case 2:
                    Console.WriteLine("You ran away");
                    break;
                case 3:
                    Console.WriteLine("Choose potion");
                    break;
                default:
                    dispBattleMenu();
                    break;
            }
            
        }
        public static void dispBattleMenu()
        {
            int choice = 0;
            Console.Clear();

            Console.WriteLine("Choose an option");
            Console.WriteLine("Attack (1)  Flee (2)  Consumable  (3)");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());
            checkChoice(choice);
        }
        public static void dispAttack()
        {

        }
    }
}
