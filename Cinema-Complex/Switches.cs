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
    public partial class Switches : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Cinema.sqlite;Version=3;");
        int central, screen1, screen2, coffee, popcorn;

        private void Switches_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            cmd.CommandText = $"SELECT CENTRAL,SCREEN1,SCREEN2,POPCORN,COFFEE FROM SWITCHES WHERE ROWID=1";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                central = reader.GetInt32(0);
                screen1 = reader.GetInt32(1);
                screen2 = reader.GetInt32(2);
                popcorn = reader.GetInt32(3);
                coffee = reader.GetInt32(4);
            }
            reader.Close();

            if (central == 1)
                centralButton.BackColor = Color.Yellow;
            else
                centralButton.BackColor = Color.Gray;
            if (screen1 == 1)
                button1.BackColor = Color.Yellow;
            else
                button1.BackColor = Color.Gray;
            if (screen2 == 1)
                button2.BackColor = Color.Yellow;
            else
                button2.BackColor = Color.Gray;
            if (coffee == 1)
                coffeeButton.BackColor = Color.Yellow;
            else
                coffeeButton.BackColor = Color.Gray;
            if (popcorn == 1)
                popcornButton.BackColor = Color.Yellow;
            else
                popcornButton.BackColor = Color.Gray;
            m_dbConnection.Close();
        }

        public Switches()
        {
            InitializeComponent();
        }

        private void centralButton_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            if (central == 1)
            {
                central = 0;
                centralButton.BackColor = Color.Gray;
            }
            else
            {
                central = 1;
                centralButton.BackColor = Color.Yellow;
            }
            cmd.Parameters.AddWithValue("@central", central);
            cmd.CommandText = $"UPDATE SWITCHES SET CENTRAL=@central WHERE ROWID=1";
            cmd.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        private void Switches_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void πΙΣΩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration();
            administration.Show();
            this.Hide();
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πατήστε τους διακόπτες για να ανάψετε ή να κλείσετε τα φώτα.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            if (screen1 == 1)
            {
                screen1 = 0;
                button1.BackColor = Color.Gray;
            }
            else
            {
                screen1 = 1;
                button1.BackColor = Color.Yellow;
            }
            cmd.Parameters.AddWithValue("@screen1", screen1);
            cmd.CommandText = $"UPDATE SWITCHES SET SCREEN1=@screen1 WHERE ROWID=1";
            cmd.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            if (screen2 == 1)
            {
                screen2 = 0;
                button2.BackColor = Color.Gray;
            }
            else
            {
                screen2 = 1;
                button2.BackColor = Color.Yellow;
            }
            cmd.Parameters.AddWithValue("@screen2", screen2);
            cmd.CommandText = $"UPDATE SWITCHES SET SCREEN2=@screen2 WHERE ROWID=1";
            cmd.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        private void coffeeButton_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            if (coffee == 1)
            {
                coffee = 0;
                coffeeButton.BackColor = Color.Gray;
            }
            else
            {
                coffee = 1;
                coffeeButton.BackColor = Color.Yellow;
            }
            cmd.Parameters.AddWithValue("@coffee", coffee);
            cmd.CommandText = $"UPDATE SWITCHES SET COFFEE=@coffee WHERE ROWID=1";
            cmd.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        private void popcornButton_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            if (popcorn == 1)
            {
                popcorn = 0;
                popcornButton.BackColor = Color.Gray;
            }
            else
            {
                popcorn = 1;
                popcornButton.BackColor = Color.Yellow;
            }
            cmd.Parameters.AddWithValue("@popcorn", popcorn);
            cmd.CommandText = $"UPDATE SWITCHES SET POPCORN=@popcorn WHERE ROWID=1";
            cmd.ExecuteNonQuery();
            m_dbConnection.Close();
        }

    }
}
