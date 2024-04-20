using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    public class Hero
    {
        public string name;
        public int MaxHP = 500;
        public int MaxMP = 50;
        public int hp = 500;
        public int MP = 50;
        public int STR = 5;
        public int INT = 5;
        public int MATK = 5;
        public int END = 5;
        public int RES = 5;
        public int SPD = 5;  
        public int LUCK = 15;

        public int HP
        {
            get => hp;
            set
            {
                if ((HP + value) > MaxHp)
                {
                    HP = MaxHP;
                }
                else
                {
                    HP = value;
                }
            }
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public void TakeDamage(int dmg)
        {
            HP -= dmg;
        }
        public int GiveDamage()
        {
            //can change later
            return 20;
        }
    }
}
