using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Sortring_Methods
{
    public partial class Help_Form : Form
    {
        public Help_Form()
        {
            InitializeComponent();
        }

        private void Help_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Main_Form Back = new Main_Form();
            Back.Show();
            this.Hide();
        }
    }
}
