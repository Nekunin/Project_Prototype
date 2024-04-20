using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static void CheckMP(Hero p)
        {

        }
    }
    public class ConsumableItems : Items
    {
        public int Restore_HP { get; private set; }
        public int Restore_MP { get; private set;}
        public ConsumableItems(string name, string description, int Restore_hp,  int Restore_mp) : base(name, description)
        {
            Restore_HP = Restore_hp; Restore_MP = Restore_mp;
        }
        //more to do here
    }
    public class StatBoosters

}
