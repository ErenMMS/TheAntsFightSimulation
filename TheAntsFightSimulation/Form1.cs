namespace TheAntsFightSimulation
{
    public partial class Form1 : Form
    {
        Shikaree_Master shikaree_master = new Shikaree_Master();
        Golden_Crystal golden_crystal = new Golden_Crystal();

        double attackBonus;
        double skillAttackBonus;


        public Form1()
        {
            InitializeComponent();
        }

        public bool[] IsSkillTriggered(double skill1Rate, bool prepare1, double skill2Rate, bool prepare2, double skill3Rate, bool prepare3, int round)
        {
            // if there is preparation only hit in 2, 4, 6 and 8 round
            bool[] triggeredSkills = new bool[3];

            Random random1 = new Random();
            bool isSkill1Triggered = random1.NextDouble() <= skill1Rate;
            Random random2 = new Random();
            bool isSkill2Triggered = random2.NextDouble() <= skill2Rate;
            Random random3 = new Random();
            bool isSkill3Triggered = random3.NextDouble() <= skill3Rate;

            /// if there is prep and in the prep round than not trigger the skill
            
            // Skill1
            if ((prepare1 == true) && (round % 2 == 1))
            {
                triggeredSkills[0] = false;
            }
            else if (isSkill1Triggered == true)
            {
                triggeredSkills[0] = true;
            }
            else
            {
                triggeredSkills[0] = false;
            }

            // Skill2
            if ((prepare2 == true) && (round % 2 == 1))
            {
                triggeredSkills[1] = false;
            }
            else if (isSkill2Triggered == true)
            {
                triggeredSkills[1] = true;
            }
            else
            {
                triggeredSkills[1] = false;
            }

            // Skill3
            if ((prepare3 == true) && (round % 2 == 1))
            {
                triggeredSkills[2] = false;
            }
            else if (isSkill3Triggered == true)
            {
                triggeredSkills[2] = true;
            } 
            else
            {
                triggeredSkills[2] = false;
            }

            return triggeredSkills;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            // Future Plan for multiple ant // 

            // input AntName => a function and that function go to the ant class and call attack functions

            //string inputAnt;
            //string[] skillName = intputAnt.skillName;
            //double[] skillRate = inputAnt.skillRate;
            //double[] skillDamage = inputAnt.skillDamage;

            // // // // // // // // // // // /

            attackBonus = Convert.ToDouble(textBoxAttack.Text);
            skillAttackBonus = Convert.ToDouble(textBoxSAttack.Text);

            listBox1.Items.Clear();

            string[] skillName = shikaree_master.skillName;
            double[] skillRate = shikaree_master.skillRate;
            bool[] preperation = shikaree_master.preperation;

            double skill1Rate = skillRate[0];
            double skill2Rate = skillRate[1];
            double skill3Rate = skillRate[2];

            string skillN1 = skillName[0] + "x0";
            string skillN2 = skillName[1] + "x0";
            string skillN3 = skillName[2] + "x0";

            int counterForSkill1 = 0;
            int counterForSkill2 = 0;
            int counterForSkill3 = 0;

            double skill1Dmg = 0;
            double skill2Dmg = 0;
            double skill3Dmg = 0;

            for (int i = 0; i < 8; i++) // 8 round
            {
                bool[] triggeredSkills = IsSkillTriggered(skill1Rate, preperation[0], skill2Rate, preperation[1], skill3Rate, preperation[2], i);

                if (triggeredSkills[0] == true)
                {
                    skill1Dmg += shikaree_master.Skill1(attackBonus, skillAttackBonus);

                    counterForSkill1++;
                    skillN1 = skillName[0] + " x" + counterForSkill1; //skillN1 = skillName[0] + " x" + ++counterForSkill1;

                }
                if (triggeredSkills[1] == true)
                {
                    skill2Dmg += shikaree_master.Skill2(attackBonus, skillAttackBonus);

                    counterForSkill2++;
                    skillN2 = skillName[1] + " x" + counterForSkill2;
                }
                if (triggeredSkills[2] == true)
                {
                    skill3Dmg += shikaree_master.Skill3(attackBonus, skillAttackBonus);

                    counterForSkill3++;
                    skillN3 = skillName[2] + " x" + counterForSkill3;
                }
            }
            double allSkillDmg = skill1Dmg + skill2Dmg + skill3Dmg;

            int SumSkill = counterForSkill1 + counterForSkill2 + counterForSkill3;
            listBox1.Items.Add(skillN1);
            listBox1.Items.Add(skillN2);
            listBox1.Items.Add(skillN3);
            listBox1.Items.Add(SumSkill);
            listBox1.Items.Add(Math.Floor(allSkillDmg/1000000) + "m");
        }
    }
}