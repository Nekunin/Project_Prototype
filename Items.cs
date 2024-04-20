using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    internal class Items
    {
    }
    public class Potion
    {
        private int hpRecover = 10;
        public void Consume(Hero p)
        {
            if (p.HP + hpRecover > p.MaxHp)
            {
                p.HP = p.MaxHp;
            }
            else
            {
                p.HP += hpRecover;
            }
        }
    }
}
