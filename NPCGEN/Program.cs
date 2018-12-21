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
            
            int capacity = 100;
            int[] pointDistribution = new int[capacity];
            for (int j = 0; j < 20; j++)
            {


                for (int i = 0; i < capacity; i++)
                {
                    int points = randomNPC.GetDisadPoints(100);
                    pointDistribution[i] = points;
                }


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
