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

            DataWriterReader dwr = new DataWriterReader();
            AdvantageContainer ac = dwr.GetAdvantageContainer();
            Console.WriteLine(ac);
        }

    }
}
