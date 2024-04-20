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
        public string Name { get; private set; }
        public int HP { get; set; }
        public int MP { get; private set; }
        public int STR { get; private set; }
        public int INT { get; private set; }
        public int MATK {  get; private set; }
        public int END { get; private set; }
        public int RES { get; private set; }
        public int SPD { get; private set; }
        public int LUCK { get; private set; }

        public MinorEnemy(string name, int hp, int mp, int str, int In, int matk, int end, int res, int spd, int luck)
        {
            Name = name; HP = hp; MP = mp; STR = str; INT = In;  MATK = matk; END = end; RES = res; SPD = spd; LUCK = luck;
            
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
        public class MinorEnemyManager
        {
            private List<MinorEnemy> CommonEnemies;
            private MinorEnemy DeathMark;
            private Random random;

            public MinorEnemyManager()
            {
                CommonEnemies = new List<MinorEnemy>();
                random = new Random();
                DeathMark = new MinorEnemy("DEATH", 900, 900, 300, 300, 300, 300, 300, 300, 999);
                EnemyCreator();
            }
            public void EnemyCreator()
            {
                CommonEnemies.Add(new MinorEnemy("Goblin", 25, 0, 3, 4, 0, 2, 0 ,9, 2));
                CommonEnemies.Add(new MinorEnemy("Skeleton", 20, 5, 5, 2, 3, 10, -3, 3, 0));
                CommonEnemies.Add(new MinorEnemy("Orc", 30, 0, 20, 6, 0, 23, 5, -3, 5));
                CommonEnemies.Add(new MinorEnemy("Kobold", 25, 10, 5, 4, 4, 4, 5, 18, 7));
                CommonEnemies.Add(new MinorEnemy("Bandit", 20, 10, 10, 10, 10, 5, 13, 9, 13));
                CommonEnemies.Add(new MinorEnemy("Shadow", 80, 23, 22, 17, 13, 9999, -20, -5, 10));
                CommonEnemies.Add(new MinorEnemy("Treant", 20, 10, 8, 14, 9, 35, -5, 0, 2));

            }
            public MinorEnemy GetRandomEnemy()
            {
                int LuckUnluck = random.Next(1, 51);
                if (LuckUnluck == 6)
                {
                    return DeathMark;
                }
                else
                {
                    return CommonEnemies[random.Next(CommonEnemies.Count)];
                }

            }
        }
    }
}
