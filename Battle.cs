using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    internal class Battle
    {
        public Battle(Hero Player, MinorEnemy Enemy)
        {
            string prompt = @$"Battle for Supremacy
Battle against: {Enemy.Name}";
            string[] options = { "Attack", "Skill", "Guard", "Items" };
            Menu Fight = new Menu(prompt, options);
            while (Player.HP > 0 && Enemy.HP > 0)
            {
                int selectedIndex = Fight.Run();

                switch (selectedIndex)
                {
                    case 0:
                        //run attack calculations 
                        int damageToEnemy = HeroPhysicalAttack(Player, Enemy);
                        UpdateEnemyHP(Enemy, damageToEnemy);
                        if (Enemy.HP > 0)
                        {
                            int damageToPlayer = MonsterPhysicalAttack(Player, Enemy);
                            UpdatePlayerHP(Player, damageToPlayer);
                        }
                        break;
                    case 1:
                        UseSkill(Player, Enemy);
                        if (Enemy.HP > 0)
                        {
                            int damageToPlayer = MonsterPhysicalAttack(Player, Enemy);
                            UpdatePlayerHP(Player, damageToPlayer);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Wait for the full release");
                        Console.ReadLine();
                        break;
                    case 3:
                        break;
                }
            }
        }
        public int HeroPhysicalAttack(Hero MainChara, MinorEnemy x)
        {
            int physicaldamage = (MainChara.STR) - (x.END + x.LUCK);
            physicaldamage = physicaldamage > 0 ? physicaldamage : 0;
            Console.WriteLine($"You dealt {physicaldamage} points of damage to {x.Name}");
            Console.ReadLine();
            return physicaldamage;
        }

        public int MonsterPhysicalAttack(Hero MainChara, MinorEnemy x)
        {
            int physicaldamage = (x.STR + x.INT + x.MATK + x.LUCK) - (MainChara.END + MainChara.RES);
            physicaldamage = physicaldamage > 0 ? physicaldamage : 0;
            Console.WriteLine($"You received {physicaldamage} points of damage from {x.Name}'s attack");
            Console.ReadLine();
            return physicaldamage;
        }
        public void UpdatePlayerHP(Hero MainChara, int damage)
        {
            MainChara.HP -= damage;
        }

        public void UpdateEnemyHP(MinorEnemy x, int damage)
        {
            x.HP -= damage;
        }
        public void UseSkill(Hero MainChara, MinorEnemy x)
        {
            if (MainChara.name == "Reset")
            {
                string prompt = "Choose a Skill";
                string[] options = new string[Skill.ResetSkills.Count];
                for (int i = 0; i < Skill.ResetSkills.Count; i++)
                {
                    options[i] = Skill.ResetSkills[i].Name;
                }
                Menu SkillMenu = new Menu(prompt, options);
                int selectedIndex = SkillMenu.Run();
                if (selectedIndex >= 0 && selectedIndex < Skill.ResetSkills.Count)
                {
                    Skill selectedSkill = Skill.ResetSkills[selectedIndex];
                    // Check if MP is sufficient to use the skill
                    if (MainChara.MP >= selectedSkill.MPcost)
                    {
                        // Perform the selected skill action here
                        double damage = selectedSkill.CalculateDamage(MainChara);
                        Console.WriteLine($"Using {selectedSkill.Name}, dealt {damage} damage!");
                        if (selectedSkill.Name == "Life Drain")
                        {
                            int hprecovery = selectedSkill.HealthRecovery(MainChara, selectedSkill);
                            Console.WriteLine($"{MainChara.Name} has recovered {hprecovery - MainChara.HP} points of hp");
                            MainChara.HP = hprecovery;

                        }
                        // Reduce MP
                        MainChara.MP -= selectedSkill.MPcost;
                        // Apply damage to the enemy or any other action based on the skill
                        double enemyDamage = selectedSkill.CalculateDamage(MainChara);
                        Console.WriteLine($"Enemy took {enemyDamage} damage!");
                        Console.ReadLine();
                        // Reduce enemy's HP
                        x.HP -= (int)enemyDamage;
                    }
                    else
                    {
                        Console.WriteLine("Not enough MP to use this skill!");
                    }
                }
            }
            else if (MainChara.name == "Leon")
            {
                string prompt2 = "Choose a Skill";
                string[] options2 = new string[Skill.LeonSkills.Count];
                for (int i = 0; i < Skill.LeonSkills.Count; i++)
                {
                    options2[i] = Skill.LeonSkills[i].Name;
                }
                Menu SkillMenu2 = new Menu(prompt2, options2);
                int selectedIndex2 = SkillMenu2.Run();
                if (selectedIndex2 >= 0 && selectedIndex2 < Skill.LeonSkills.Count)
                {
                    Skill selectedSkill2 = Skill.LeonSkills[selectedIndex2];
                    // Check if MP is sufficient to use the skill
                    if (MainChara.MP >= selectedSkill2.MPcost)
                    {
                        // Perform the selected skill action here
                        double damage = selectedSkill2.CalculateDamage(MainChara);
                        ///add the mp recovery skill
                        
                        if (selectedSkill2.Name == "FirstAid")
                        {
                            int hprecovery = selectedSkill2.HealthRecovery(MainChara, selectedSkill2);
                            Console.WriteLine($"{MainChara.Name} has recovered {hprecovery - MainChara.HP} points of hp");
                            MainChara.HP = hprecovery;

                        }
                        if (selectedSkill2.Name == "MP Recovery")
                        {
                            MainChara.MP += selectedSkill2.MPRecovery;
                            if (MainChara.MP > MainChara.MaxMP)
                            {
                                MainChara.MP = MainChara.MaxMP;
                            }
                            Console.WriteLine("Recovered 10 MP");
                            Console.WriteLine("MP: {0}/{1}", MainChara.MP, MainChara.MaxMP);
                            Console.ReadKey();
                        }
                        Console.WriteLine($"Using {selectedSkill2.Name}, dealt {damage} damage!");

                    }

                    else
                    {
                        // Perform the selected skill action here
                        double damage = selectedSkill2.CalculateDamage(MainChara);
                        Console.WriteLine($"Using {selectedSkill2.Name}, dealt {damage} damage!");
                    }
                    // Reduce MP
                    MainChara.MP -= selectedSkill2.MPcost;
                    // Apply damage to the enemy or any other action based on the skill
                    double enemyDamage = selectedSkill2.CalculateDamage(MainChara);
                    Console.WriteLine($"Enemy took {enemyDamage} damage!");
                    Console.ReadLine();
                    // Reduce enemy's HP
                    x.HP -= (int)enemyDamage;
                }
                else
                {
                    Console.WriteLine("Not enough MP to use this skill!");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }

        }
    }
}

