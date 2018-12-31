using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPCGEN
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void GenerateNPC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PointsTextBox.Text) || !int.TryParse(PointsTextBox.Text, out int number))
            {
                MessageBox.Show("Enter a valid point value", "Point value error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TLTextBox.Text) || !int.TryParse(TLTextBox.Text, out int n))
            {
                MessageBox.Show("Enter a valid Tech level value", "Tech level value error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RandomNPC randomNPC = new RandomNPC();
                bool exotic = ExoticCheckbox.Checked;
                bool supernatural = SupernaturalCheckbox.Checked;

                int points;
                if (int.Parse(PointsTextBox.Text) > 7250)
                    points = 7250;
                else
                    points = int.Parse(PointsTextBox.Text);

                NPC npc = randomNPC.GetRandomNPC(points, int.Parse(TLTextBox.Text), exotic, supernatural);
                NPCSheet sheet = new NPCSheet();
                string output = "";
                string outputTwo = "";
                output += "Name: " + npc.Name + " \nAge: " + npc.Age + " \nTL: " + npc.TechLevel + "\n\n";
 
                foreach(Attribute a in npc.GetAttributes())
                {
                    output += a.Name + " : " + a.Level + "\n" ;
                }
                outputTwo += "Advantages\n";
                foreach(Advantage a in npc.GetAdvantages())
                {
                    outputTwo += a.Name + " " + a.Points + "\n";
                }
                outputTwo += "\nSkills\n";
                foreach(Skill s in npc.GetSkills())
                {
                    outputTwo += s.Name + " " + s.SkillLevel + "\n";
                }

    
                sheet.OutputOne = output;
                sheet.OutputTwo = outputTwo;

                sheet.Show();
                
                
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
