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
    public partial class Hall : Form
    {
        public Hall()
        {
            InitializeComponent();
        }

        private void Hall_Load(object sender, EventArgs e)
        {
           
        }

        private void screensButton_Click(object sender, EventArgs e)
        {
            Screens newScreens = new Screens();
            newScreens.Show();
            this.Hide();
        }

        private void barButton_Click(object sender, EventArgs e)
        {
            Bar newBar = new Bar();
            newBar.Show();
            this.Hide();
        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            this.Hide();
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε έναν από τους χώρους του μπαρ, των εισητηρίων ή των\nαιθουσών.");
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }

        private void Hall_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void πΙΣΩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
