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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            Help_Form Help = new Help_Form();
            Help.Show();
            this.Hide();
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void About_Button_Click(object sender, EventArgs e)
        {
            About_Form About = new About_Form();
            About.Show();
            this.Hide();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            Sort_Form Start = new Sort_Form();
            Start.Show();
            this.Hide();
        }
    }
}
