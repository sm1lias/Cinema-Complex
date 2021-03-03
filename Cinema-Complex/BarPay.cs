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
    public partial class BarPay : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Cinema.sqlite;Version=3;");
        int CocaCola, Sprite, OrangeJuice, Chips, PopCorn, Doritos, Water;

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιουργήθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπυρίδων.");
        }

        private void BarPay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πληκτρολογίστε τα στοιχεία της κάρτας σας και πατήστε πληρωμή.");
        }

        private void πΙΣΩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.value = 0;
            Globals.value1 = 0;
            Globals.value2 = 0;
            Globals.value3 = 0;
            Globals.value4 = 0;
            Globals.value5 = 0;
            Globals.value6 = 0;
            Globals.value7 = 0;
            Bar bar = new Bar();
            bar.Show();
            this.Hide();
            
        }

        public BarPay()
        {
            InitializeComponent();
        }

        public BarPay(int CocaCola1,int Sprite1, int OrangeJuice1, int Chips1, int PopCorn1, int Doritos1, int Water1)
        {
            InitializeComponent();
            CocaCola = CocaCola1;
            Sprite = Sprite1;
            OrangeJuice = OrangeJuice1;
            Chips = Chips1;
            PopCorn = PopCorn1;
            Doritos = Doritos1;
            Water = Water1;
        }

        private void BarPay_Load(object sender, EventArgs e)
        {
            label1.Text = $"Συνολικό Ποσό = {Globals.value} ευρώ";
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
                cmd.Parameters.AddWithValue("@CocaCola", CocaCola);
                cmd.Parameters.AddWithValue("@Sprite", Sprite);
                cmd.Parameters.AddWithValue("@OrangeJuice", OrangeJuice);
                cmd.Parameters.AddWithValue("@Chips", Chips);
                cmd.Parameters.AddWithValue("@PopCorn", PopCorn);
                cmd.Parameters.AddWithValue("@Doritos", Doritos);
                cmd.Parameters.AddWithValue("@Water", Water);
                cmd.CommandText = $"UPDATE BAR SET Coca=Coca-@CocaCola, Sprite=Sprite-@Sprite, Orange=Orange-@OrangeJuice, Chips=Chips-@Chips, Pop=Pop-@PopCorn, Doritos=Doritos-@Doritos, Water=Water-@Water WHERE ID=1";
                cmd.ExecuteNonQuery();
                cmd.CommandText="INSERT INTO RESERVATIONS(name, Coca, Sprite, Orange, Chips, Pop, Doritos, Water) VALUES (@name, @CocaCola, @Sprite, @OrangeJuice, @Chips, @PopCorn, @Doritos, @Water)";
                cmd.ExecuteNonQuery();
                m_dbConnection.Close();
                MessageBox.Show("Ευχαριστούμε για την αγοράς σας");
                this.Hide();
                Hall hall = new Hall();
                hall.Show();
            }
        }
        
    }
}
