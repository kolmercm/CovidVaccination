using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidVaccination
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login lform = new Login();
            lform.Show();
            this.Hide();
        }

        private void GetHelp_Click(object sender, EventArgs e)
        {
            GetHelp Hform = new GetHelp();
            Hform.Show();
            this.Hide();
        }
    }
}
