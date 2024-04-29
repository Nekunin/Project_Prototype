using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    public class MinorEnemy
    {
        public int hp;
        public string Name { get; private set; }
        public int HP { get => hp; set => hp = value; }
        public int MP { get; private set; }
        public int STR { get; private set; }
        public int INT { get; private set; }
        public int MATK { get; private set; }
        public int END { get; private set; }
        public int RES { get; private set; }
        public int SPD { get; private set; }
        public int LUCK { get; private set; }

        public MinorEnemy(string name, int hp, int mp, int str, int In, int matk, int end, int res, int spd, int luck)
        {
            Name = name; HP = hp; MP = mp; STR = str; INT = In; MATK = matk; END = end; RES = res; SPD = spd; LUCK = luck;

        }
        //For test gameloop
        public MinorEnemy()
        {
            HP = 200;
        }
        public void TakeDamage(int dmg)
        {
            HP -= dmg;
        }
        public int GiveDamage()
        {
            //can change later
            return 70;
        }
    }
}