using System;
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
    public class Weapons : Items
    {
        public int STR { get; private set; }
        public int INT { get; private set; }
        public int MATK { get; private set; }
        public string SKILL { get; private set; }
        public int PRICE { get; private set; }

        public Weapons(string name, string description, int str, int In, int matk, string skill = "none", int price = 0) : base(name, description)
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
    public class Armors : Items
    {
        public int END { get; private set; }
        public int RES { get; private set; }
        public string SKILL { get; private set; }
        public int PRICE { get; private set; }

        public Armors(string name, string description, int end, int res, int price = 0, string skill = "None") : base(name, description)
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
}
