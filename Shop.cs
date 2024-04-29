using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    internal class Shop
    {
        public static void shop(Hero MainChara)
        {
            string prompt = "W@lmart";
            string[] options = { "Buy Items", "Buy Weapon", "Buy Armor", "Buy Boots", "Buy Accessory", "Talk", "Exit" };
            Menu Shop = new Menu(prompt, options);
            while (true)
            {
                int selectedIndex = Shop.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Console.WriteLine("Please take a look at our merchandise");

                        break;
                    case 1:
                        Console.WriteLine("Wait for the full release");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Wait for the full release");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Wait for the full release");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Wait for the full release");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("I hate this job, I hope you don't end up like me...");
                        Console.ReadLine();
                        break;
                    case 6:
                        return;
                }
            }

        }
        private bool IsWeaponAvailableInShop(Hero MainChara, Weapon weapon)
        {
            if (MainChara.name == "Leon")
            {
                return weapon.Name == "Long Sword" || weapon.Name == "Claymore";
            }
            else
            {
                return weapon.Name == "IceCream Machine" || weapon.Name == "Magic Grimoire";
            }
        }
        private void DisplayWeaponListForPurchase(Hero MainChara, EquipmentManager equipmentManager)
        {
            Console.WriteLine("W@lmart's Shop");
            Console.WriteLine("[Weapon List]");
            for (int i = 0; i < equipmentManager.WeaponList.Count; i++)
            {

                if (IsWeaponAvailableInShop(MainChara, equipmentManager.WeaponList[i]))
                {
                    Console.WriteLine($"{i + 1}. {equipmentManager.WeaponList[i].Name} - {equipmentManager.WeaponList[i].Description} - Price: {equipmentManager.WeaponList[i].PRICE}");
                }
            }
        }
    }
}
