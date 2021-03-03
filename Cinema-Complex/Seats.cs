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
    public partial class Seats : Form
    {
        int c = 0;
        int count = 0;
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Cinema.sqlite;Version=3;");
        public Seats()
        {
            InitializeComponent();
        }


        private void Seats_Load(object sender, EventArgs e)
        {
            Button[] array_button = new Button[50] {button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
            button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
            button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
            button31, button32, button33, button34, button35, button36, button37, button38, button39, button40,
            button41, button42, button43, button44, button45, button46, button47, button48, button49, button50};

            for (int i = 0; i < 50; i++)
            {
                array_button[i].Click += Button_Click;
            }

            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();

            for (int i = 0; i < 50; i++)
            {
                cmd.CommandText = $"SELECT Name FROM ID{Globals.id} WHERE ROWID={i + 1}";
                if (cmd.ExecuteScalar().ToString() != "empty")
                {
                    array_button[i].BackColor = Color.Red;
                    array_button[i].Enabled = false;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Green;
                count++;
            }
            else
            {
                button.BackColor = Color.White;
                count--;
            }
            label1.Text =$"Έχετε επιλέξει {count.ToString()} θέσεις";
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            Button[] array_button = new Button[50] {button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
            button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
            button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
            button31, button32, button33, button34, button35, button36, button37, button38, button39, button40,
            button41, button42, button43, button44, button45, button46, button47, button48, button49, button50};

            int[] array_int = new int[50];

            
            for(int i=0; i<50; i++)
            {
                if (array_button[i].BackColor != Color.Green)
                    array_int[i] = 0;
                else
                {
                    array_int[i] = 1;
                    c++;
                }
            }
            if (c == 0)
                MessageBox.Show("Δεν έχετε επιλέξει κάποια θέση");
            else
            {
                TicketsPay ticketsPay = new TicketsPay(array_int, c);
                ticketsPay.Show();
                this.Hide();
            }
        }

        private void Seats_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void πΙΣΩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            this.Hide();
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε ποιες θέσεις θέλετε και πατήστε οκ.");
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }
    }
}
