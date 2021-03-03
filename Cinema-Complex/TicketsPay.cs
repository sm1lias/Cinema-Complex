using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Cinema_Complex
{
    public partial class TicketsPay : Form
    {
        int count;
        int[] iarray = new int[50];
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Cinema.sqlite;Version=3;");
        public TicketsPay()
        {
            InitializeComponent();
        }

        public TicketsPay(int[] array_int,int c)
        {
            count = c;
            iarray = array_int;
            InitializeComponent();
        }

        private void TicketsPay_Load(object sender, EventArgs e)
        {
            label1.Text = $"Συνολικό Ποσό = " + count*8 + " ευρώ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            string date = textBox2.Text;
            string ccv = textBox3.Text;
            string name = textBox4.Text;
            
            if (Globals.IsCreditCardInfoValid(number, date, ccv, name) == true)
            {
                SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
                m_dbConnection.Open();
                cmd.Parameters.AddWithValue("@name", name);
                for (int i=0; i<50; i++)
                {
                    if (iarray[i] == 1)
                    {
                        cmd.CommandText = $"UPDATE ID{Globals.id} SET Name=@name WHERE ROWID={i+1}";
                        cmd.ExecuteNonQuery();
                    }
                }
                SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
                SQLiteCommand cmd3 = new SQLiteCommand(m_dbConnection);
                SQLiteCommand cmd4 = new SQLiteCommand(m_dbConnection);
                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.CommandText = $"SELECT count(*) FROM ROBOTMESSAGE WHERE NAME=@name";
                int count = Convert.ToInt32(cmd2.ExecuteScalar());
                if (count == 1)
                {
                    cmd3.Parameters.AddWithValue("@name", name);
                    cmd3.CommandText = $"SELECT BARITEM FROM ROBOTMESSAGE WHERE NAME=@name";
                    string item = cmd3.ExecuteScalar().ToString();
                    MessageBox.Show("Πιθανόν να λερώσατε την προηγούμενη φορά με\n" + item + ", θα παρακαλούσαμε να είσαστε πιο προσεκτικός αυτή τη φόρα.\nΕυχαριστούμε για την αγοράς σας.");
                    cmd4.Parameters.AddWithValue("@name", name);
                    cmd4.CommandText = $"DELETE FROM ROBOTMESSAGE WHERE NAME=@name";
                    cmd4.ExecuteNonQuery();
                    this.Hide();
                    Hall hall = new Hall();
                    hall.Show();
                }
                else
                {
                    MessageBox.Show("Ευχαριστούμε για την αγοράς σας");
                    this.Hide();
                    Hall hall = new Hall();
                    hall.Show();
                }
                m_dbConnection.Close();
            }
        }

        private void πΙΣΩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seats seats = new Seats();
            seats.Show();
            this.Hide();
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πληκτρολογίστε τα στοιχεία της κάρτας σας και πατήστε πληρωμή.");
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }

        private void TicketsPay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
