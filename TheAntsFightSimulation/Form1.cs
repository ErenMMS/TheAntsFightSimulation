namespace TheAntsFightSimulation
{
    public partial class Form1 : Form
    {
        Shikaree_Master shikaree_master = new Shikaree_Master();
        public Form1()
        {
            InitializeComponent();
        }

        public bool[] SkillRate(double skill1Rate, double skill2Rate, double skill3Rate)
        {
            bool[] triggeredSkills = new bool[3];

            Random random1 = new Random();
            bool isSkill1Triggered = random1.NextDouble() <= skill1Rate;
            Random random2 = new Random();
            bool isSkill2Triggered = random2.NextDouble() <= skill2Rate;
            Random random3 = new Random();
            bool isSkill3Triggered = random3.NextDouble() <= skill3Rate;

            if (isSkill1Triggered)
            {
                triggeredSkills[0] = true;
            }
            if (isSkill2Triggered)
            {
                triggeredSkills[1] = true;
            }
            if (isSkill3Triggered)
            {
                triggeredSkills[2] = true;
            }
            return triggeredSkills;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            // Future Plan for multiple ant // 

            //string inputAnt;
            //string[] skillName = intputAnt.skillName;
            //double[] skillRate = inputAnt.skillRate;
            //double[] skillDamage = inputAnt.skillDamage;

            // // // // // // // // // // // /

            listBox1.Items.Clear();

            string[] skillName = shikaree_master.skillName;
            double[] skillRate = shikaree_master.skillRate;
            double[] skillDamage = shikaree_master.skillDamage; // Not added yet

            double skill1Rate = skillRate[0];
            double skill2Rate = skillRate[1];
            double skill3Rate = skillRate[2];

            string skillN1 = skillName[0] + "x0";
            string skillN2 = skillName[1] + "x0";
            string skillN3 = skillName[2] + "x0";

            int counterForSkill1 = 0;
            int counterForSkill2 = 0;
            int counterForSkill3 = 0;

            for (int i = 0; i < 8; i++) // 8 round
            {
                bool[] triggeredSkills = SkillRate(skill1Rate, skill2Rate, skill3Rate);

                if (triggeredSkills[0] == true)
                {
                    counterForSkill1++;
                    skillN1 = skillName[0] + " x" + counterForSkill1;
                    //skillN1 = skillName[0] + " x" + ++counterForSkill1;
                }
                if (triggeredSkills[1] == true)
                {
                    counterForSkill2++;
                    skillN2 = skillName[1] + " x" + counterForSkill2;
                }
                if (triggeredSkills[2] == true)
                {
                    counterForSkill3++;
                    skillN3 = skillName[2] + " x" + counterForSkill3;
                }
            }

            int SumSkill = counterForSkill1 + counterForSkill2 + counterForSkill3;
            listBox1.Items.Add(skillN1);
            listBox1.Items.Add(skillN2);
            listBox1.Items.Add(skillN3);
            listBox1.Items.Add(SumSkill);
        }
    }
}