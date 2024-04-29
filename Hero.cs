using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    
    public class Hero
    {
        private Hero MainChara;
        public string name;
        public int MaxHP;
        public int MaxMP;
        public int hp;
        public int MP;
        public int STR;
        public int INT;
        public int MATK;
        public int END;
        public int RES;
        public int SPD;
        public int LUCK;
        public int MONEY;
        public Hero(string aName, int maxhp, int maxmp, int str, int In, int matk, int end, int res, int spd, int luck, int money) 
        {
            Name = aName; MaxHP = maxhp; MaxMP = maxmp; hp = maxhp; MP = maxmp; STR = str; INT = In; MATK = matk; END = end; RES = res; SPD = spd; LUCK = luck; MONEY = money;
        }


        public int HP
        {
            get => hp;
            set => hp = value;
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
        public static void AddMoney(Hero MainChara, int money)
        {
            MainChara.MONEY += money;
        }
    }
}
