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

            RandomNPC randomNPC = new RandomNPC();
            
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
