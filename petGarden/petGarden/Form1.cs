using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petGarden
{
    public partial class frmNewOrLoad : Form
    {
        private bool enableDebugMode = true;
        private bool loadFlag = false;
        
        public frmNewOrLoad()
        {
            InitializeComponent();
            if (enableDebugMode == true)
            {
                lblWelcome.Text = "Debug mode enabled.\nMake your selection below:";
            }
            else
            {
                lblWelcome.Text = "Welcome to Pet Garden: C# Edition!\nMake your selection below:";
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
