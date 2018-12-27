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

            RandomNPC npc = new RandomNPC();

            for(int i = 0; i < 20; i++)
            {
                NPC bob = npc.GetRandomNPC(100 , 3);

                Console.WriteLine(bob);
            }
            
        }

        public static int Mean(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum / arr.Length;
        }
    }
}
