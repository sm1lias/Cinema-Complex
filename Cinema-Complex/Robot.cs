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
    public partial class Robot : Form
    {
        int screen1, screen2;
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Cinema.sqlite;Version=3;");
        public Robot()
        {
            InitializeComponent();
        }

        private void Robot_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            cmd.CommandText = $"SELECT SCREEN1,SCREEN2 FROM ROBOTCLEAN WHERE ROWID=1";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                screen1 = reader.GetInt32(0);
                screen2 = reader.GetInt32(1);
            }
            reader.Close();
            
            if (screen1 == 1)
                button1.BackColor = Color.Green;
            else
                button1.BackColor = Color.Red;
            if (screen2 == 1)
                button2.BackColor = Color.Green;
            else
                button2.BackColor = Color.Red;

            cmd2.CommandText = $"SELECT ITEMS,SCREEN,SEAT FROM ROBOTFIND";
            SQLiteDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
                comboBox1.Items.Add("Αντικείμενο: " + reader2.GetString(0) + " Αίθουσα: " + reader2.GetInt32(1) + " Θέση: " + reader2.GetInt32(2));
            reader2.Close();
            m_dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            if (screen1 == 1)
            {
                screen1 = 0;
                button1.BackColor = Color.Red;
            }
            else
            {
                screen1 = 1;
                button1.BackColor = Color.Green;
            }
            cmd.Parameters.AddWithValue("@screen1", screen1);
            cmd.CommandText = $"UPDATE ROBOTCLEAN SET SCREEN1=@screen1 WHERE ROWID=1";
            cmd.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (comboBox1.SelectedIndex > -1)
            {
                string[] array = selected.Split(' ');

                SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
                SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
                m_dbConnection.Open();
                cmd2.Parameters.AddWithValue("@ITEMS", array[1]);
                cmd2.CommandText = $"DELETE FROM ROBOTFIND WHERE ITEMS=@ITEMS";
                cmd2.ExecuteNonQuery();

                comboBox1.Items.Clear();
                cmd2.CommandText = $"SELECT ITEMS,SCREEN,SEAT FROM ROBOTFIND";
                SQLiteDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                    comboBox1.Items.Add("Αντικείμενο: " + reader.GetString(0) + " Αίθουσα: " + reader.GetInt32(1) + " Θέση: " + reader.GetInt32(2));
                reader.Close();
                m_dbConnection.Close();
            }
        }

        private void Robot_FormClosed(object sender, FormClosedEventArgs e)
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
            MessageBox.Show("Εδώ μπορείτε να ενεργοποιήσετε τη σκούπα ρομπότ να καθαρίσει αφού τελιώσει η προβολή, καθώς επίσης να δείτε τι αντικείμενα έχει εντοπίσει και να τα παραδώσετε.");
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            if (screen2 == 1)
            {
                screen2 = 0;
                button2.BackColor = Color.Red;
            }
            else
            {
                screen2 = 1;
                button2.BackColor = Color.Green;
            }
            cmd.Parameters.AddWithValue("@screen2", screen2);
            cmd.CommandText = $"UPDATE ROBOTCLEAN SET SCREEN2=@screen2 WHERE ROWID=1";
            cmd.ExecuteNonQuery();
            m_dbConnection.Close();
        }

    }
}
