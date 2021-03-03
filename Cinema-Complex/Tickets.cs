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
    public partial class Tickets : Form
    {
        public string k;
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Cinema.sqlite;Version=3;");
        public Tickets()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            cmd.CommandText = "SELECT count(*) FROM MOVIES";
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            for (int i = 1; i < count + 1; i++)
            {
                cmd.CommandText = $"SELECT Title FROM MOVIES WHERE ROWID={i}";
                
                comboBox1.Items.Add(cmd.ExecuteScalar().ToString());
            }
        
            m_dbConnection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "ΒΑΘΜΟΛΟΓΙΑ:";
            label5.Text = "ΣΚΗΝΟΘΕΣΙΑ:";
            label6.Text = "ΗΘΟΠΟΙΟΙ:";
            string[] info = new string[3] { "Score", "Directors", "Stars" };
            Label[] label_array = new Label[3] { label1, label2, label3 };
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            string movie = comboBox1.GetItemText(comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@movie", movie);

            for (int i = 0; i < 3; i++)
            {
                cmd.CommandText = $"SELECT {info[i]} FROM MOVIES WHERE Title=@movie";
                label_array[i].Text = cmd.ExecuteScalar().ToString();

            }

            cmd.CommandText = "SELECT count(*) FROM SCREENS WHERE Title=@movie";
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            comboBox2.Items.Clear();
            cmd.CommandText = $"SELECT Screen,DAY,ID FROM SCREENS WHERE Title=@movie ORDER BY DAY";
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add("Αίθουσα: " + reader.GetString(0) + " ημερομηνία: " + reader.GetString(1));
            }

            m_dbConnection.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            string selected2 = comboBox2.GetItemText(comboBox2.SelectedItem);
            string[] array = selected2.Split(' ');
            cmd.Parameters.AddWithValue("@screen", array[1]);
            cmd.Parameters.AddWithValue("@day", array[3]+" "+array[4]);
            cmd.CommandText = $"SELECT ID FROM SCREENS WHERE Screen=@screen AND DAY=@day";
            Globals.id = Convert.ToInt32(cmd.ExecuteScalar());
            m_dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1)
            {
                Seats seats = new Seats();
                seats.Show();
                this.Hide();
            }
        }

        private void πΙΣΩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hall hall = new Hall();
            hall.Show();
            this.Hide();
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε ταινία, αιθουσα-ημερομηνία-ώρα και πατήστε οκ.");
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }

        private void Tickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

