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

            Advantage chronicDepression = new Advantage("chronic depression", "lkasdjfl;kdasjflasdkjfdaslkfjdsal;f ", -15 );
            AdvantageContainer ac = new AdvantageContainer();

            ac.AddAdvantage(AdvantageCategory.Mental ,chronicDepression);
            Console.WriteLine(ac);
        }
    }
}
