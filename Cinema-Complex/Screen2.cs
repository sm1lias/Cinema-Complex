using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Complex
{
    public partial class Screen2 : Form
    {
        public Screen2()
        {
            InitializeComponent();
        }

        private void Screen2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void πΙΣΩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Screens screens = new Screens();
            screens.Show();
            this.Hide();
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }
    }
}
