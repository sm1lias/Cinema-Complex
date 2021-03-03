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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void barButton_Click(object sender, EventArgs e)
        {
            BarAdmin newBarAdmin = new BarAdmin();
            newBarAdmin.Show();
            this.Hide();
        }

        private void moviesButton_Click(object sender, EventArgs e)
        {
            MoviesAdmin moviesAdmin = new MoviesAdmin();
            moviesAdmin.Show();
            this.Hide();
        }

        private void robotButton_Click(object sender, EventArgs e)
        {
            Robot newRobot = new Robot();
            newRobot.Show();
            this.Hide();
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            Switches newSwitches = new Switches();
            newSwitches.Show();
            this.Hide();
        }

        private void Administration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Εδώ είναι το κέντρο διαχείρισης, επιλέξτε μια επιλογή από τις παρακάτω.");
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }

        private void αΠΟΣΥΝΔΕΣΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffLogin staffLogin = new StaffLogin();
            staffLogin.Show();
            this.Hide();
        }
    }
}
