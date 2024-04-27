﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Project_Prototype
{
    public class Items
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Items(string name, string description)
        {
            Name = name; Description = description;
        }
    }
    public class Weapon : Items
    {
        public int STR { get; private set; }
        public int INT { get; private set; }
        public int MATK { get; private set; }
        public string SKILL { get; private set; }
        public int PRICE { get; private set; }

        public Weapon(string name, string description, int str, int In, int matk, string skill = "none", int price = 0) : base(name, description)
        {
            STR = str; INT = In; MATK = matk; SKILL = skill; PRICE = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine("Stats:");
            if (STR != 0)
            {
                Console.Write($" STR [+{STR}]");
            }
            if (INT != 0)
            {
                Console.Write($" INT [+{INT}]");
            }
            if (MATK != 0)
            {
                Console.Write($" MATK [+{MATK}]");
            }
            if (SKILL != "None")
            {
                Console.Write($" SKILL [{SKILL}]");
            }
        }
    }
    public class Armor : Items
    {
        public int END { get; private set; }
        public int RES { get; private set; }
        public string SKILL { get; private set; }
        public int PRICE { get; private set; }

        public Armor(string name, string description, int end, int res, string skill = "None", int price = 0) : base(name, description)
        {
            END = end; RES = res; SKILL = skill; PRICE = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine("Stats:");
            if (END != 0)
            {
                Console.Write($" END [+{END}]");
            }
            if (RES != 0)
            {
                Console.Write($" RES [+{RES}]");
            }
            if (SKILL != "None")
            {
                Console.Write($" SKILL [{SKILL}]");
            }

        }
    }
    public class Boots : Items
    {
        public int END { get; private set; }
        public int RES { get; private set; }
        public int SPD { get; private set; }
        public string SKILL { get; private set; }
        public Boots(string name, string description, int spd, int end = 0, int res = 0, string skill = "None") : base(name, description)
        {
            END = end; RES = res; SPD = spd; SKILL = skill;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine("Stats:");
            if (END != 0)
            {
                Console.Write($" END [+{END}]");
            }
            if (RES != 0)
            {
                Console.Write($" RES [+{RES}]");
            }
            if (SPD != 0)
            {
                Console.Write($" SPD [+{SPD}]");
            }
            if (SKILL != "None")
            {
                Console.Write($" SKILL [{SKILL}]");
            }

        }
    }
    public class Accessory : Items
    {
        public int HP { get; private set; }
        public int MP { get; private set; }
        public int LUCK { get; private set; }
        public string SKILL { get; private set; }
        public Accessory(string name, string description, int luck, int hp = 0, int mp = 0, string skill = "None") : base(name, description)
        {
            LUCK = luck; HP = hp; MP = mp; SKILL = skill;
        }
    }
    public class EquipmentManager
    {
        private List<Weapon> WeaponList;
        private List<Armor> ArmorList;
        private List<Boots> BootList;
        private List<Accessory> AccessoryList;

        public void WeaponCreator()
        {
            WeaponList.Add(new Weapon("Short Sword", "A small sword with a short range",1, 0, 0));
            WeaponList.Add(new Weapon("Holy Cross", "A symbol of your belief", 0, 2, 2));
            WeaponList.Add(new Weapon("Long Sword", "A regular sword, maybe you could even scratch your back now", 4, 0, 0));
            WeaponList.Add(new Weapon("Magic Grimoire", "A small book engraved with the Fire Arrow spell", 0, 2, 3, "Fire Arrow"));
            WeaponList.Add(new Weapon("Claymore", "Massive sword, crushes instead of slashing", 12, 0, 0, "Ground Breaker"));
            WeaponList.Add(new Weapon("IceCream Machine", "A lost Item engraved with the Blizzard spell", 1, 0, 0, "Ice Arrow"));
            WeaponList.Add(new Weapon("Dragon Slayer", "the biggest sword ever created, its more like a huge lump of iron", 25, 0, 0, "Dream Smasher"));
            WeaponList.Add(new Weapon("Necronomicon", "A banned grimoire said to be connected to the underworld", 6, 20, 15, "Black Hole"));

        }
        public void ArmorCreator()
        {
            ArmorList.Add(new Armor("Regular Clothes","They stink and offer no benefits other than nostalgia",0,0));
            ArmorList.Add(new Armor("Nun Outfit", "You have been using these for ages, and they still look new", 0, 3));
            ArmorList.Add(new Armor("Leather Armor", "Better than nothing I guess", 5, 0));
            ArmorList.Add(new Armor("Witch's Outfit", "Survival is a priority, pride leads to death", 5, 15, ""));
            ArmorList.Add(new Armor("Guard Armor", "The city's guards have a better looking version, but offers the same protection", 20, 10));
            ArmorList.Add(new Armor("Dragon Dress", "Dress created from the scales of a dragon", 10, 20));
            ArmorList.Add(new Armor("Berserk Armor", "It consumes your sanity (and body) in exchange for absolute power", 100, 45));
            ArmorList.Add(new Armor("Saint Outfit", "At this point no one can deny you strngth, regardless of if you recived help from god or not", 45, 100));
        }
        public void BootCreator()
        {
            BootList.Add(new Boots("Boots", "They have seen better times", -1,2,2));
            BootList.Add(new Boots("Dark Blue Shoes", "Regular shoes fit for a sister", 0));
            BootList.Add(new Boots("Leather Boots", "not fashionable but they are confortable", 2,2));
            BootList.Add(new Boots("Witchcraft's ring", "A ring that slighly levitates you off the ground", 5,1,3));
            BootList.Add(new Boots("Guard Boots", "heavy...", -3,5,5));
            BootList.Add(new Boots("Dragonic Heels", "A dragon Teeth acts as the high heel", 5,10,10));
            BootList.Add(new Boots("Berserker Boots", "Light and strong", 5,10,10));
            BootList.Add(new Boots("Hermes's Sandals", "Comfortable and very fluffy", 20,5,5));
        }
        public void AccessoryCreator()
        {
            AccessoryList.Add(new Accessory("HP Ring", "Increases HP", 1,50));
            AccessoryList.Add(new Accessory("MP Ring", "Increases MP", 1,50));
            AccessoryList.Add(new Accessory("Lucky Necklace", "Luck be in the Air Tonight", 10));
            AccessoryList.Add(new Accessory("Overlord Bangle", "You can feel it's overwhelming power", 10,100,100));
        }
    }
}
