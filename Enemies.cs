using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    public class MinorEnemy
    {
        public string Name { get; private set; }
        public int HP { get; private set; }
        public int MP { get; private set; }
        public int STR { get; private set; }
        public int MATK {  get; private set; }
        public int END { get; private set; }
        public int RES { get; private set; }
        public int SPD { get; private set; }
        public int LUCK { get; private set; }


        public MinorEnemy(string name, int hp, int mp, int str, int matk, int end, int res, int spd, int luck)
        {
            Name = name; HP = hp; MP = mp; STR = str; MATK = matk; END = end; RES = res; SPD = spd; LUCK = luck;
            
        }
        public class MinorEnemyManager
        {
            private List<MinorEnemy> minorEnemies;
            private Random random;

            public MinorEnemyManager()
            {
                minorEnemies = new List<MinorEnemy>();
                random = new Random();
                EnemyCreator();
            }
            public void EnemyCreator()
            {
                minorEnemies.Add(new MinorEnemy("Goblin", 25, 0, 3, 0, 2, 0 ,9, 2));
                minorEnemies.Add(new MinorEnemy("Skeleton", 20, 5, 5, 3, 10, -3, 3, 0));
                minorEnemies.Add(new MinorEnemy("Orc", 30, 0, 20, 0, 23, 5, -3, 5));
            }
        }
    }
}
