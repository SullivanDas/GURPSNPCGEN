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

            Attribute ST = new Attribute("ST", Attribute.PointScale.Ten, 6);
            Console.WriteLine(ST);
        }
    }
}
