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
    public partial class StaffLogin : Form
    {
        bool check = false;
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] users = { "Admin", "Admin1", "Admin2" };
            string[] password = { "0", "1", "2" };
            {
                for (int i = 0; i < 3; i++)
                {
                    if (users[i] == textBox1.Text && password[i] == textBox2.Text)
                    {
                        check = true;
                        Administration administration = new Administration();
                        administration.Show();
                        this.Hide();
                    }
                }
                if (check == false)
                    MessageBox.Show("Λάθος Στοιχεία");

            }
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πληκτρολογήστε τα στοιχεία σας και πατήστε LogIn για να συνδεθείτε.");
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }

        private void StaffLogin_FormClosed(object sender, FormClosedEventArgs e)
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
