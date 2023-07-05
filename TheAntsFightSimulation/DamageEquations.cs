using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Channels;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;
using System.Reflection;

namespace TheAntsFightSimulation
{
    ///    "squarerrot(ants)" is the square root of the number of ants in one squad(one line) ---->> give constant value for now

    ///    "basic_attack_ants" is the base attack of your type of soldier ant.e.g. 105 for regular t9 shooter --->> SoldierAnts.cs classes //const

    //    "attackbonus" is the percentage bonus on attack that is displayed in combat reports as attack. if you have 200% attack bonus, the equation would be 1+2 = 3 --->> textBoxAttack

    //    "skillattackbonus" is the percentage bonus on skills that is displayed in combat reports as Sepcial Ant Skill Attack --->> textBoxSAttack

    //--- "damage_bonus" is normal attack damage.E.g.skill 1 and skill 6 past levels 11 to 20. Insect level 20. Mutation ascent.Usually if something says "Damage" that's just normal attacks // don't include for now//

    ///    "counter" is the counter effect to a specific type.e.g.shooters on carrier. --->> don't include

    ///    50% if crit is a 50% normal damage bonus when a crit occurs, e.g.through the shooter t9 crit chance evolution --->> don't include

    //    "pango_modifier" is a modifier that's specific to each wild creature. Groundhog has 1 (e.g. no modification), while pangolin has a different modifier per day and troop type

    //    "damage_skill_description" is the damage done by a skill. e.g. 55% chance to deal 250% damage to 1 random enemy squad. 250% or 2.5 would be used here, while targets would be 1 --->> this var take the value from skill methods in SpecialAnts.cs


    public class Skill_Damage
    {
        //      Skill Damage Equation    
        ///     
        ///     attack_power = squarerroot(ants) * basic_attack_ants* (1+attackbonus) * (1 + skillattackbonus)
        ///     damage_per_use = (attack_power - 1) * damage_skill_description* targets;
        ///     damage_in_report = damage_per_use* 8 * pango_modifier // 8 rounds
        ///

        public double DamagePerUse(double attackBonus, double skillAttackBonus, double antSkillDamage, int targets)
        {
            double damage_per_use;
            double attack_power;

            attack_power = Math.Sqrt(53000) * 96 * (1 + attackBonus / 100) * (1 + skillAttackBonus / 100);
            damage_per_use = (attack_power - 1) * (antSkillDamage / 100) * targets * (1 + 0.8);// last value is pango modifier %80 for carriers

            return damage_per_use;
        }
        
    }
    public class Normal_Damage
    {
        //     Normal Damage Equation
        /// 
        ///     attack_power = squarerroot(ants) * basic_attack_ants * (1+attackbonus)
        ///     damage_in_report = (attack_power - 1) * (1+damage_bonus + counter + 50% if crit) * 8 * pango_modifier // 8 rounds
        ///     

    }
}
