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
    public partial class GetHelp : Form
    {
        public GetHelp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mform = new MainMenu();
            mform.Show();
            this.Hide();
        }
    }
}
