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
    public partial class BarAdmin : Form
    {
        string[] values = new string[7] { "Coca", "Sprite", "Orange", "Chips", "Pop", "Doritos", "Water" };
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Cinema.sqlite;Version=3;");
        public BarAdmin()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (comboBox1.SelectedIndex > -1)
            {
                string[] array = selected.Split(' ');

                SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
                SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
                m_dbConnection.Open();
                cmd2.CommandText = $"DELETE FROM RESERVATIONS WHERE ROWID={array[1]}";
                cmd2.ExecuteNonQuery();

                comboBox1.Items.Clear();
                cmd.CommandText = $"SELECT Name,Coca,Sprite,Orange,Chips,Pop,Doritos,Water,ROWID FROM RESERVATIONS ORDER BY Name";
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add("ID: " + reader.GetInt32(8) + " Όνομα: " + reader.GetString(0) + " Coca Cola: " + reader.GetInt32(1).ToString()
                        + " Sprite: " + reader.GetInt32(2).ToString() + " Orange Juice: " + reader.GetInt32(3).ToString()
                        + " Chips: " + reader.GetInt32(4).ToString() + " Pop Corn: " + reader.GetInt32(5).ToString() + " Doritos: " + reader.GetInt32(6).ToString() + " Water: " + reader.GetInt32(7).ToString());                    
                }
                reader.Close();
                m_dbConnection.Close();
            }
        }

        private void BarAdmin_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            cmd.CommandText = $"SELECT Name,Coca,Sprite,Orange,Chips,Pop,Doritos,Water,ROWID FROM RESERVATIONS ORDER BY Name";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add("ID: "+ reader.GetInt32(8) + " Όνομα: " + reader.GetString(0) + " Coca Cola: " + reader.GetInt32(1).ToString()
                    + " Sprite: " + reader.GetInt32(2).ToString() + " Orange Juice: " + reader.GetInt32(3).ToString()
                    + " Chips: " + reader.GetInt32(4).ToString() + " Pop Corn: " + reader.GetInt32(5).ToString() + " Doritos: " + reader.GetInt32(6).ToString() + " Water: " + reader.GetInt32(7).ToString());
            }
            reader.Close();
            cmd.CommandText = $"SELECT Coca,Sprite,Orange,Chips,Pop,Doritos,Water FROM BAR";
            SQLiteDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                label1.Text=(" Coca Cola: " + reader2.GetInt32(0).ToString()
                    + " Sprite: " + reader2.GetInt32(1).ToString() + " Orange Juice: " + reader2.GetInt32(2).ToString()
                    + " Chips: " + reader2.GetInt32(3).ToString() + " Pop Corn: " + reader2.GetInt32(4).ToString() + " Doritos: " + reader2.GetInt32(5).ToString() + " Water: " + reader2.GetInt32(6).ToString());
            }
            reader2.Close();
            m_dbConnection.Close();
            //reader2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
            TextBox[] textbox_array = new TextBox[7] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            try
            {
                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox7.Text))
                {
                    for (int i = 0; i < 7; i++)
                    {
                        cmd2.CommandText = $"SELECT TOTAL({values[i]}) FROM RESERVATIONS";
                        cmd.Parameters.AddWithValue("@value", (Convert.ToInt32(textbox_array[i].Text) - Convert.ToInt32(cmd2.ExecuteScalar())).ToString());
                        cmd.CommandText = $"UPDATE BAR SET {values[i]}=@value";
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                    MessageBox.Show("Δεν έχεις σημπληρώσει όλα τα κουτάκια");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Δεν έχεις βάλει τη σωστή μορφή σε κάποιο κουτάκι");
            }
            cmd.CommandText = $"SELECT Coca,Sprite,Orange,Chips,Pop,Doritos,Water FROM BAR";
            SQLiteDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                label1.Text = (" Coca Cola: " + reader2.GetInt32(0).ToString()
                    + " Sprite: " + reader2.GetInt32(1).ToString() + " Orange Juice: " + reader2.GetInt32(2).ToString()
                    + " Chips: " + reader2.GetInt32(3).ToString() + " Pop Corn: " + reader2.GetInt32(4).ToString() + " Doritos: " + reader2.GetInt32(5).ToString() + " Water: " + reader2.GetInt32(6).ToString());
            }
            reader2.Close();
            m_dbConnection.Close();
        }

        private void BarAdmin_FormClosed(object sender, FormClosedEventArgs e)
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
            MessageBox.Show("Εδώ μπορείτε να δείτε τις παραγγελίες του μπαρ και να τις παραδώσετε, καθώς επίσης να αλλάξετε της πόσοτητες των προϊόντων του μπαρ στη βάση.");
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
