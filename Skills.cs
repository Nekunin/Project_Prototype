using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prototype
{
    public class Skill
    {
        public string Name { get; private set; }
        public int BaseDamage { get; private set; }
        public double IntelligenceModifier { get; private set; }
        public double MagicAttackModifier { get; private set; }
        public int MPcost {  get; private set; }
        public int HPRecovery { get; private set; }
        public int MPRecovery { get; private set; }
        public static List<Skill> ResetSkills;
        public static List<Skill> LeonSkills;
        public static List<Skill> EquipmentSkills;

        public Skill(string name, int baseDamage, double intelligenceModifier, double magicAttackModifier, int MPCost, int HPrecovery = 0, int MPrecovery = 0)
        {
            Name = name;
            BaseDamage = baseDamage;
            IntelligenceModifier = intelligenceModifier;
            MagicAttackModifier = magicAttackModifier;
            MPcost = MPCost;
            HPRecovery = HPrecovery;
            MPRecovery = MPrecovery;
        }
        static Skill()
        {
            ResetSkills = new List<Skill>
            {
                new Skill("Fire Ball", 30, 1.2, 1.5, 30),
                new Skill("Frozen Eyeballs", 50, 1.5, 1.8, 60),
                new Skill("Heal", 0, 1, 1, 50, 100),
                new Skill("Life Drain", 10, 1, 1, 5, 10)
            };
            LeonSkills = new List<Skill>
            {
                new Skill("Bonk", 50, 1.3, 1.2, 20),
                new Skill("UpperCut", 30, 1.3, 1.2, 10),
                new Skill("FirstAid", -50, -50, -50, 20, 40),
                new Skill("Atomic Slash", 999, 1, 1, 100),
                new Skill("MP Recovery", -50, -50, -50, 0, 0, 10)
            };
            EquipmentSkills = new List<Skill>
            {
                new Skill("Black Hole", 999, 8, 8, 300),
                new Skill("Dream Smasher", 999, 4, 4, 100),
                new Skill("Full Heal", 0, 0, 0, 50, 999),
                new Skill("Ice Arrow", 60, 2, 2, 50),
                new Skill("Fire Arrow", 75, 2, 2.3, 70),
                new Skill("Ground Breaker", 100, 3, 1.2, 25)
            };
        }
        public double CalculateDamage(Hero MainChara)
        {
            // Calculate the damage using the base damage and modifiers
            double totalDamage = BaseDamage + MainChara.INT * IntelligenceModifier + MainChara.MATK * MagicAttackModifier;

            // Ensure the damage is not negative
            return totalDamage > 0 ? totalDamage : 0;
        }
        public int HealthRecovery(Hero MainChara, Skill skill)
        {
           int HP = MainChara.HP + skill.HPRecovery;
            if (HP > MainChara.MaxHP)
            {
                HP = MainChara.MaxHP;
            }
            return HP;
        }
    }
}
