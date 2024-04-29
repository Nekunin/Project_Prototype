using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    internal class Inventory_Equipment
    {
        EquipmentManager equipmentManager = new EquipmentManager();
        public void ManagementofItems()
        {
            equipmentManager.WeaponCreator();
            equipmentManager.ArmorCreator();
            equipmentManager.BootCreator();
            equipmentManager.AccessoryCreator();
        }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        public Boots EquippedBoots { get; set; }
        public Accessory EquippedAccessory { get; set; }
        private Hero MainChara;
        public static void Inventory(Hero MainChara)
        {
            string InventoryP = $@"{MainChara.name}'s Inventory
 HP [{MainChara.MaxHP}/{MainChara.HP}] MP [{MainChara.MaxMP}/{MainChara.MP}]
 Gold [{MainChara.MONEY}]";
            string[] InventoryO = { "Items", "Equipment", "Exit Menu" };
            Menu InventoryMenu = new Menu(InventoryP, InventoryO);
            while (true)
            {
                int Inv_selectedIndex = InventoryMenu.Run();

                switch (Inv_selectedIndex)
                {
                    case 0:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                    case 1:
                         Equipment(MainChara);
                        break;
                    case 2:
                        return;
                }
            }
        }
        public static void Equipment(Hero MainChara)
        {
            string EquipmentP = $"{MainChara.name}'s Inventory";
            string[] EquipmentO = { "Weapon", "Armor", "Boots", "Accesory", "Exit Inventory" };
            Menu Equip = new Menu(EquipmentP, EquipmentO);
            while (true)
            {
                int selectedIndex = Equip.Run();

                switch (selectedIndex)
                {
                    case 0:
                        DisplayWeaponMenu(MainChara);
                        break;
                    case 1:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                    case 2:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                    case 3:
                        Console.WriteLine("Not Implemented Yet");
                        break;
                    case 4:
                        return;
                }
            }
        }
        //Initial Equipment
        public void StartingEquipment(Hero MainChara, EquipmentManager x)
        {
            if (MainChara.name == "Leon")
            {
                Weapon EquippedWeapon = x.WeaponList[0];
                x.OwnedWeapons.Add(EquippedWeapon);

                Armor EquippedArmor = x.ArmorList[0];
                x.OwnedArmors.Add(EquippedArmor);

                Boots EquippedBoots = x.BootList[0];
                x.OwnedBoots.Add(EquippedBoots);

                Accessory EquippedAccessory = x.AccessoryList[0];
                x.OwnedAccessories.Add(EquippedAccessory);
            }
            else if (MainChara.name == "Reset")
            {
                Weapon EquippedWeapon = x.WeaponList[1];
                x.OwnedWeapons.Add(EquippedWeapon);

                Armor EquippedArmor = x.ArmorList[1];
                x.OwnedArmors.Add(EquippedArmor);

                Boots EquippedBoots = x.BootList[1];
                x.OwnedBoots.Add(EquippedBoots);

                Accessory EquippedAccessory = x.AccessoryList[1];
                x.OwnedAccessories.Add(EquippedAccessory);
            }
        }
        public void EquipWeapon(Weapon weapon)
        {
            EquippedWeapon = weapon;
        }
        public void EquipArmor(Armor armor)
        {
            EquippedArmor = armor;
        }
        public void EquipBoot(Boots boots)
        {
            EquippedBoots = boots;
        }
        public void EquipAccessory(Accessory accessory)
        {
            EquippedAccessory = accessory;
        }
        private static void DisplayWeaponMenu(Hero MainChara)
        {

        }
    }
}
