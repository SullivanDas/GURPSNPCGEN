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
            Skill Fishing = new Skill("Fishing", Difficulty.Easy, npc.GetAttribute(AttributeNames.IQ));
            Skill Brawling = new Skill("Brawling", Difficulty.Average, npc.GetAttribute(AttributeNames.DX));
            npc.SetAttribute(AttributeNames.IQ, 20);

            SkillContainer sc = new SkillContainer();

            sc.AddSkill(AttributeNames.IQ, Fishing);
            sc.AddSkill(AttributeNames.DX, Brawling);
            Console.WriteLine(sc);
        }
    }
}
