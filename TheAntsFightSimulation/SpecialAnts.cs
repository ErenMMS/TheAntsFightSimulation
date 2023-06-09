﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAntsFightSimulation
{
    /// <summary>
    /// class structure: Guardian, Shooter, Carrier ant classes are parent and those classes include difference stats from Special Ants skills buff
    /// child classes are Special Ants name like; Shikare Master for Carrier or Reap Master for Shooter.
    /// </summary>
    ///

    public class Shikaree_Master : Carrier_Class
    {
        // With Level 25 and Purple Awakening //
        // 5 Star Level 20 //

        Skill_Damage Skill_Damage = new Skill_Damage();
        public string[] skillName = { "İnfinite Deadhunt", "Rampant Attack", "Audacious Charge" };
        //public double[] skillRate = { 1.0, 1.0, 1.0 }; // full rate for max skill dmg testing
        public double[] skillRate = { 0.52, 0.47, 0.67}; // normal rate
        public double[] skillDamage = { 673.0, 353.5, 232.0 };
        public bool[] preperation = { false, false, true }; // Skill1, Skill2, Skill3

        public double Skill1(double attackBonus, double skillAttackBonus)
        {
            double dmg;
            
            dmg = Skill_Damage.DamagePerUse(attackBonus, skillAttackBonus, skillDamage[0], 1);
            return dmg;
        }
        public double Skill2(double attackBonus, double skillAttackBonus)
        {
            double dmg;

            dmg = Skill_Damage.DamagePerUse(attackBonus, skillAttackBonus, skillDamage[1], 3);
            return dmg;
        }
        public double Skill3(double attackBonus, double skillAttackBonus)
        {
            double dmg;

            dmg = Skill_Damage.DamagePerUse(attackBonus, skillAttackBonus, skillDamage[2], 3);
            return dmg;
        }
    }
    public class Golden_Crystal : Carrier_Class
    {
        // no 6th skill
        // all three skills are 10 lvl

        Skill_Damage Skill_Damage = new Skill_Damage();
        public string[] skillName = { "Battle Fever", "Violently Poisonous", "Swoop" };
        //public double[] skillRate = { 1.0, 1.0, 1.0 }; // full rate for max skill dmg testing
        public double[] skillRate = { 0.80, 0.80, 0.50 }; // normal rate
        public double[] skillDamage = { 280.0, 250.0, 180.0};
        public bool[] preperation = { false, true, false }; // Skill1, Skill2, Skill3

        public double Skill1(double attackBonus, double skillAttackBonus)
        {
            double dmg;

            dmg = Skill_Damage.DamagePerUse(attackBonus, skillAttackBonus, skillDamage[0], 1);
            return dmg;
        }
        public double Skill2(double attackBonus, double skillAttackBonus)
        {
            double dmg;

            dmg = Skill_Damage.DamagePerUse(attackBonus, skillAttackBonus, skillDamage[1], 3);
            return dmg;
        }
        public double Skill3(double attackBonus, double skillAttackBonus)
        {
            double dmg;

            dmg = Skill_Damage.DamagePerUse(attackBonus, skillAttackBonus, skillDamage[2], 3);
            return dmg;
        }
    }

    public class Jack_Jumper : Universal_Class
    {
        // With Level 1 and Green Awakening //
        // 0 Star Level 10 //

        Skill_Damage Skill_Damage = new Skill_Damage();
        public string[] skillName = { "Rampant Attack", "Jumping Attack", "Blitzkrieg" };
        //public double[] skillRate = { 1.0, 1.0, 1.0 }; // full rate for max skill dmg testing
        public double[] skillRate = { 0.40, 0.80, 0.50 }; // normal rate
        public double[] skillDamage = { 249.0, 130.0, 667.0 };
        public bool[] preperation = { false, false, true }; // Skill1, Skill2, Skill3

        public double Skill1(double attackBonus, double skillAttackBonus)
        {
            double dmg;

            dmg = Skill_Damage.DamagePerUse(attackBonus, skillAttackBonus, skillDamage[0], 2);
            return dmg;
        }
        public double Skill2(double attackBonus, double skillAttackBonus)
        {
            double dmg;

            dmg = Skill_Damage.DamagePerUse(attackBonus, skillAttackBonus, skillDamage[1], 2);
            return dmg;
        }
        public double Skill3(double attackBonus, double skillAttackBonus)
        {
            double dmg;

            dmg = Skill_Damage.DamagePerUse(attackBonus, skillAttackBonus, skillDamage[2], 1);
            return dmg;
        }
    }

    public class Gianth_Tooth : Universal_Class
    {
        // With Level 20 and Blue Awakening //
        // 4 Star Level 20 //
        public string[] skillName = { "Weakness Strike", "Disabling Attack", "Big Bite" };
        public double[] skillRate = { 0.40, 0.25, 0.30};
        public double[] skillDamage = { 455.0, 540.0, 644.0 };

        public double Skill2nd(bool activate)
        {
            double dmg = 0;
            return dmg;
        }
        public double Skill3rd(bool activate)
        {
            double dmg = 0;
            return dmg;
        }
        public double Skill8th(bool activate)
        {
            double dmg = 0;
            return dmg;
        }
    }
}
