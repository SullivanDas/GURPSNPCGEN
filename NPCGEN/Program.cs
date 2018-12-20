using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static NPCGEN.Enums;

namespace NPCGEN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
            NPC npc = new NPC("Bob", 43, 100);
            Skill s = new Skill("Fishing", Difficulty.Easy, npc.GetAttribute(AttributeNames.IQ));
            npc.AddSkill(s);
            List<Skill> skills = npc.GetSkills();

            foreach(Skill sk in skills)
            {
                Console.WriteLine(sk);
            }

            npc.SetAttribute(AttributeNames.IQ, 20);
            skills = npc.GetSkills();

            foreach (Skill sk in skills)
            {
                Console.WriteLine(sk);
            }
        }
    }
}
