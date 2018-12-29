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
    public partial class NPCSheet : Form
    {
        public NPCSheet()
        {
            InitializeComponent();
            NPCText.Text = OutputOne;
        }

        private string _outputOne;
        public string OutputOne { get { return _outputOne; } set { _outputOne = value; NPCText.Text = _outputOne; } }
        private string _outputTwo;
        public string OutputTwo { get { return _outputTwo; } set { _outputTwo = value; NPCTextTwo.Text = _outputTwo; } }

        private void NPCText_Click(object sender, EventArgs e)
        {

        }
    }
}
