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
    public partial class MoviesAdmin : Form
    {
        
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Cinema.sqlite;Version=3;");
        public MoviesAdmin()
        {
            InitializeComponent();
        }

        private void MoviesAdmin_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
            SQLiteCommand cmd3 = new SQLiteCommand(m_dbConnection);
            SQLiteCommand cmd4 = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            cmd.CommandText = $"SELECT ID,Title,Screen,Day FROM SCREENS ORDER BY ID";
            SQLiteDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                comboBox1.Items.Add("ID: " + reader.GetInt32(0) + " Title: " + reader.GetString(1) + " Screen: " + reader.GetString(2)
                    + " Day: " + reader.GetString(3)); 
            }
            reader.Close();
            cmd3.CommandText = "SELECT Screen, DAY, ID FROM SCREENS";
            SQLiteDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                comboBox3.Items.Add("Αίθουσα: " + reader3.GetString(0) + " Ημερομηνία " + reader3.GetString(1) + " ID: " + reader3.GetInt32(2));
            }
            reader3.Close();
            cmd4.CommandText = $"SELECT Title FROM MOVIES";
            SQLiteDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
                comboBox4.Items.Add("Ταινία: " + reader4.GetString(0));
            reader4.Close();
            m_dbConnection.Close();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (comboBox1.SelectedIndex > -1)
            {
                string[] array = selected.Split(' ');

                SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
                SQLiteCommand cmd1 = new SQLiteCommand(m_dbConnection);
                SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
                m_dbConnection.Open();
                cmd2.CommandText = $"DELETE FROM SCREENS WHERE ID={array[1]}";
                cmd2.ExecuteNonQuery();
                cmd2.CommandText = $"DROP TABLE ID{array[1]}";
                cmd2.ExecuteNonQuery();
                comboBox1.Items.Clear();
                cmd.CommandText = $"SELECT ID,Title,Screen,Day FROM SCREENS ORDER BY ID";
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add("ID: " + reader.GetInt32(0) + " Title: " + reader.GetString(1) + " Screen: " + reader.GetString(2)
                   + " Day: " + reader.GetString(3));
                }
                reader.Close();

                comboBox3.Items.Clear();
                comboBox2.Items.Clear();
                cmd1.CommandText = "SELECT Screen, DAY, ID FROM SCREENS";
                SQLiteDataReader reader3 = cmd1.ExecuteReader();
                while (reader3.Read())
                {
                    comboBox3.Items.Add("Αίθουσα: " + reader3.GetString(0) + " Ημερομηνία " + reader3.GetString(1) + " ID: " + reader3.GetInt32(2));
                }
                reader3.Close();
                m_dbConnection.Close();
            }
        }

        private void checkTickets_Click(object sender, EventArgs e)
        {
            string selected = comboBox3.GetItemText(comboBox3.SelectedItem);
            string selected2 = comboBox2.GetItemText(comboBox2.SelectedItem);
            if (comboBox3.SelectedIndex > -1)
            {
                string[] array = selected.Split(' ');
                string[] array2 = selected2.Split(' ');

                SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
                SQLiteCommand cmd1 = new SQLiteCommand(m_dbConnection);
                SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
                m_dbConnection.Open();

                cmd2.Parameters.AddWithValue("@sold", "sold");
                cmd2.CommandText = $"UPDATE ID{array[6]} SET Name=@sold WHERE ROWID={array2[4]}";
                cmd2.ExecuteNonQuery();

                comboBox3.Items.Clear();
                comboBox2.Items.Clear();
                cmd1.CommandText = "SELECT Screen, DAY, ID FROM SCREENS";
                SQLiteDataReader reader3 = cmd1.ExecuteReader();
                while (reader3.Read())
                {
                    comboBox3.Items.Add("Αίθουσα: " + reader3.GetString(0) + " Ημερομηνία " + reader3.GetString(1) + " ID: " + reader3.GetInt32(2));
                }
                reader3.Close();
                m_dbConnection.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox3.GetItemText(comboBox3.SelectedItem);
            string[] array = selected.Split(' ');
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            comboBox2.Items.Clear();
            cmd.Parameters.AddWithValue("@empty", "empty");
            cmd.Parameters.AddWithValue("@sold", "sold");
            cmd.CommandText = $"SELECT Name,ROWID FROM ID{array[6]} WHERE Name!=@empty AND Name!=@sold ORDER BY Name";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                comboBox2.Items.Add("Όνομα: " + reader.GetString(0) + " Θέση " + reader.GetInt32(1));
            reader.Close();

            m_dbConnection.Close();
        }

        private void checkMovies_Click(object sender, EventArgs e)
        {
            string selected = comboBox4.GetItemText(comboBox4.SelectedItem);
            if (comboBox4.SelectedIndex > -1)
            {
                string[] array = selected.Split(' ');

                SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
                SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
                m_dbConnection.Open();
                cmd2.Parameters.AddWithValue("@Title", array[1]);
                cmd2.CommandText = $"DELETE FROM MOVIES WHERE Title=@Title";
                cmd2.ExecuteNonQuery();

                comboBox4.Items.Clear();
                cmd.CommandText = $"SELECT Title FROM MOVIES";
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox4.Items.Add("Ταινία: " + reader.GetString(0));
                }
                reader.Close();
                m_dbConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[4] { textBox1, textBox2, textBox3, textBox4 };            
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            SQLiteCommand cmd4 = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
            {
                
                                   
                cmd.Parameters.AddWithValue("@value0", array[0].Text);
                cmd.Parameters.AddWithValue("@value1", array[1].Text);
                cmd.Parameters.AddWithValue("@value2", array[2].Text);
                cmd.Parameters.AddWithValue("@value3", array[3].Text);
                cmd.CommandText = $"INSERT INTO MOVIES(Title, Score, Directors, Stars) VALUES (@value0, @value1, @value2, @value3)";
                cmd.ExecuteNonQuery();
                comboBox4.Items.Clear();
                cmd4.CommandText = $"SELECT Title FROM MOVIES";
                SQLiteDataReader reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                    comboBox4.Items.Add("Ταινία: " + reader4.GetString(0));
                reader4.Close();
            }
            m_dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[4] { textBox1, textBox5, textBox6, textBox7 };
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            SQLiteCommand cmd1 = new SQLiteCommand(m_dbConnection);
            SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox7.Text))
            {
                cmd.Parameters.AddWithValue("@value0", array[0].Text);
                cmd.Parameters.AddWithValue("@value1", array[1].Text);
                cmd.Parameters.AddWithValue("@value2", array[2].Text);
                cmd.Parameters.AddWithValue("@value3", array[3].Text);
                cmd.CommandText = "INSERT INTO SCREENS(ID, Title, Screen, DAY) VALUES (@value1, @value0, @value2, @value3)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS ID{array[1].Text} (Name TEXT)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"SELECT count(*) FROM ID{array[1].Text}";
                int count = Convert.ToInt32(cmd.ExecuteScalar());               
                if (count == 0)
                   
                {
                    for (int i = 0; i < 50; i++) {
                        cmd.CommandText = $"INSERT INTO ID{array[1].Text}(Name) VALUES ('empty')";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            comboBox1.Items.Clear();
            cmd2.CommandText = $"SELECT ID,Title,Screen,Day FROM SCREENS ORDER BY ID";
            SQLiteDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add("ID: " + reader.GetInt32(0) + " Title: " + reader.GetString(1) + " Screen: " + reader.GetString(2)
               + " Day: " + reader.GetString(3));
            }
            reader.Close();
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            cmd1.CommandText = "SELECT Screen, DAY, ID FROM SCREENS";
            SQLiteDataReader reader3 = cmd1.ExecuteReader();
            while (reader3.Read())
            {
                comboBox3.Items.Add("Αίθουσα: " + reader3.GetString(0) + " Ημερομηνία " + reader3.GetString(1) + " ID: " + reader3.GetInt32(2));
            }
            reader3.Close();
            m_dbConnection.Close();
        }

        private void πΙΣΩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration();
            administration.Show();
            this.Hide();
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Εδώ είναι το κέντρο διαχείρισης των ταινιών. Μπορείτε να προσθέσετε ταινίες, σε ποια αίθουσα θα προβληθούν και να τις διαγράψετε. Επίσης μπορείτε να παραδώσετε τα εισητήρια.");
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

        private void MoviesAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
