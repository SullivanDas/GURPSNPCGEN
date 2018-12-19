using System;
using System.Windows.Forms;

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
            Console.WriteLine(npc);
            npc.SetAttribute(NPC.AttributeNames.IQ, 20);
            Console.WriteLine(npc);
            npc.SetAttribute(NPC.AttributeNames.PER, 12);
            Console.WriteLine(npc);
        }
    }
}
