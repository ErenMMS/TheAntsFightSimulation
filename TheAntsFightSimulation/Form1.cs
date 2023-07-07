namespace TheAntsFightSimulation
{
    public partial class Form1 : Form
    {
        Shikaree_Master shikaree_master = new Shikaree_Master();
        Golden_Crystal golden_crystal = new Golden_Crystal();
        Jack_Jumper jack_jumper = new Jack_Jumper();

        double attackBonus;
        double skillAttackBonus;

        string[] skillName;
        double[] skillRate;
        bool[] preperation;

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
            string selectedAnt = AntsSelectorBox.Text;
            attackBonus = Convert.ToDouble(textBoxAttack.Text);
            skillAttackBonus = Convert.ToDouble(textBoxSAttack.Text);

            listBox1.Items.Clear();

            // when added lot of ant use switch case or a different design
            if (selectedAnt == "Shikaree Master")
            {
                skillName = shikaree_master.skillName;
                skillRate = shikaree_master.skillRate;
                preperation = shikaree_master.preperation;
                listBox1.Items.Add("Shikaree Master");
            }
            else if (selectedAnt == "Jack Jumper")
            {
                skillName = jack_jumper.skillName;
                skillRate = jack_jumper.skillRate;
                preperation = jack_jumper.preperation;
                listBox1.Items.Add("Jack Jumper");
            }

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
                bool[] triggeredSkills = IsSkillTriggered(skillRate[0], preperation[0], skillRate[1], preperation[1], skillRate[2], preperation[2], i);

                if (triggeredSkills[0] == true)
                {
                    if (selectedAnt == "Shikaree Master")
                    {
                        skill1Dmg += shikaree_master.Skill1(attackBonus, skillAttackBonus);
                    }
                    else if(selectedAnt == "Jack Jumper")
                    {
                        skill1Dmg += jack_jumper.Skill1(attackBonus, skillAttackBonus);
                    }

                    counterForSkill1++;
                    skillN1 = skillName[0] + " x" + counterForSkill1;

                }
                if (triggeredSkills[1] == true)
                {
                    if (selectedAnt == "Shikaree Master")
                    {
                        skill2Dmg += shikaree_master.Skill2(attackBonus, skillAttackBonus);
                    }
                    else if (selectedAnt == "Jack Jumper")
                    {
                        skill2Dmg += jack_jumper.Skill2(attackBonus, skillAttackBonus);
                    }

                    counterForSkill2++;
                    skillN2 = skillName[1] + " x" + counterForSkill2;
                }
                if (triggeredSkills[2] == true)
                {
                    if (selectedAnt == "Shikaree Master")
                    {
                        skill3Dmg += shikaree_master.Skill3(attackBonus, skillAttackBonus);
                    }
                    else if (selectedAnt == "Jack Jumper")
                    {
                        skill3Dmg += jack_jumper.Skill3(attackBonus, skillAttackBonus);
                    }

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
            listBox1.Items.Add(Math.Floor(allSkillDmg / 1000000) + "m");
        }
    }
}