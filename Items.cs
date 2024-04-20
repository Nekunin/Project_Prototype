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
    public class CheckPotion
    {
        public static void CheckHP(Hero p, int hpRecover)
        {
           
            if (p.HP + hpRecover > p.MaxHP)
            {
                p.HP = p.MaxHP;
            }
            else
            {
                p.HP += hpRecover;
            }
        }
        public static void CheckMP(Hero p)
        {

        }
    }
    public class LesserHealingPotion
    {
        public void Consume(Hero p)
        {
            int hpRecover = (int)(0.25 * p.MaxHP);
            CheckPotion.CheckHP(p, hpRecover);
        }
    }
    public class HealingPotion
    {
        public void Consume(Hero p)
        {
            int hpRecover = (int)(0.5 * p.MaxHP);
            CheckPotion.CheckHP(p, hpRecover);
        }
    }
    public class GreaterHealingPotion
    {
        public void Consume(Hero p) 
        {
            int hpRecover = p.MaxHP;
            CheckPotion.CheckHP(p, hpRecover);
        }
    }
}
