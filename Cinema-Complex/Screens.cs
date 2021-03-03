using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Cinema_Complex
{
    public partial class Screens : Form
    {
        public Screens()
        {
            InitializeComponent();
        }

        private void screen1Button_Click(object sender, EventArgs e)
        {
            Screen1 newScreen1 = new Screen1();
            newScreen1.Show();
            this.Hide();
        }

        private void sceen2Button_Click(object sender, EventArgs e)
        {
            Screen2 newScreen2 = new Screen2();
            newScreen2.Show();
            this.Hide();
        }

        private void πΙΣΩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hall hall = new Hall();
            hall.Show();
            this.Hide();
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε μία άπό τις αίθουσες για να εισέλθετε.");
        }

        private void Screens_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }
    }
}
