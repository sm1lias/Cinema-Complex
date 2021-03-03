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
    public partial class Bar : Form
    {

        
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Cinema.sqlite;Version=3;");
        string[] values = new string[7] {"Coca Cola", "Sprite", "Orange Juice", "Chips", "Pop Corn", "Doritos", "Water" };
        public Bar()
        {
            InitializeComponent();
        }

        private void Bar_Load(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(numericUpDown1.Value);
            label8.Text = "";
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            SQLiteCommand cmd2 = new SQLiteCommand(m_dbConnection);
            m_dbConnection.Open();
            NumericUpDown[] numeric_array = new NumericUpDown[7] { numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7};
            Label[] label_array = new Label[7] { label1, label2, label3, label4, label5, label6, label7 };
            for (int i = 0; i <7; i++)
            {
                cmd.CommandText =$"SELECT {values[i]} FROM BAR WHERE ID=1";
                cmd.ExecuteScalar();
                cmd2.CommandText = $"SELECT {"P"}{values[i]} FROM BARPRICE WHERE ID=1";
                cmd2.ExecuteScalar();
                label_array[i].Text = values[i] + " τιμή:" + cmd2.ExecuteScalar().ToString() + " ευρώ";
                numeric_array[i].Maximum = Convert.ToInt32(cmd.ExecuteScalar());
            }
            m_dbConnection.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            cmd.CommandText = $"SELECT PCoca Cola FROM BARPRICE WHERE ID=1";
            cmd.ExecuteScalar();
            if (Globals.value1 > Convert.ToDouble(numericUpDown1.Value) * Convert.ToDouble(cmd.ExecuteScalar()))
            {
                Globals.value -= Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value1 = Convert.ToDouble(numericUpDown1.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            else
            {
                Globals.value += Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text ="Σύνολο: "+ Globals.value.ToString()+" ευρώ";
                Globals.value1 = Convert.ToDouble(numericUpDown1.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            m_dbConnection.Close();

        }
        
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            cmd.CommandText = $"SELECT PSprite FROM BARPRICE WHERE ID=1";
            cmd.ExecuteScalar();
            if (Globals.value2 > Convert.ToDouble(numericUpDown2.Value) * Convert.ToDouble(cmd.ExecuteScalar()))
            {
                Globals.value -= Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value2 = Convert.ToDouble(numericUpDown2.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            else
            {
                Globals.value += Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value2 = Convert.ToDouble(numericUpDown2.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            m_dbConnection.Close();

        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            cmd.CommandText = $"SELECT POrange Juice FROM BARPRICE WHERE ID=1";
            cmd.ExecuteScalar();
            if (Globals.value3 > Convert.ToDouble(numericUpDown3.Value) * Convert.ToDouble(cmd.ExecuteScalar()))
            {
                Globals.value -= Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value3 = Convert.ToDouble(numericUpDown3.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            else
            {
                Globals.value += Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value3 = Convert.ToDouble(numericUpDown3.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            m_dbConnection.Close();

        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            cmd.CommandText = $"SELECT PChips FROM BARPRICE WHERE ID=1";
            cmd.ExecuteScalar();
            if (Globals.value4 > Convert.ToDouble(numericUpDown4.Value) * Convert.ToDouble(cmd.ExecuteScalar()))
            {
                Globals.value -= Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value4 = Convert.ToDouble(numericUpDown4.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            else
            {
                Globals.value += Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value4 = Convert.ToDouble(numericUpDown4.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            m_dbConnection.Close();

        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            cmd.CommandText = $"SELECT PPop Corn FROM BARPRICE WHERE ID=1";
            cmd.ExecuteScalar();
            if (Globals.value5 > Convert.ToDouble(numericUpDown5.Value) * Convert.ToDouble(cmd.ExecuteScalar()))
            {
                Globals.value -= Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value5 = Convert.ToDouble(numericUpDown5.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            else
            {
                Globals.value += Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value5 = Convert.ToDouble(numericUpDown5.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            m_dbConnection.Close();

        }
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            cmd.CommandText = $"SELECT PDoritos FROM BARPRICE WHERE ID=1";
            cmd.ExecuteScalar();
            if (Globals.value6 > Convert.ToDouble(numericUpDown6.Value) * Convert.ToDouble(cmd.ExecuteScalar()))
            {
                Globals.value -= Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value6 = Convert.ToDouble(numericUpDown6.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            else
            {
                Globals.value += Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value6 = Convert.ToDouble(numericUpDown6.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            m_dbConnection.Close();

        }
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
            cmd.CommandText = $"SELECT PWater FROM BARPRICE WHERE ID=1";
            cmd.ExecuteScalar();
            if (Globals.value7 > Convert.ToDouble(numericUpDown7.Value) * Convert.ToDouble(cmd.ExecuteScalar()))
            {
                Globals.value -= Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value7 = Convert.ToDouble(numericUpDown7.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            else
            {
                Globals.value += Convert.ToDouble(cmd.ExecuteScalar());
                label8.Text = "Σύνολο: " + Globals.value.ToString() + " ευρώ";
                Globals.value7 = Convert.ToDouble(numericUpDown7.Value) * Convert.ToDouble(cmd.ExecuteScalar());
            }
            m_dbConnection.Close();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (Globals.value == 0)
            {
                MessageBox.Show("Δεν έχετε επιλέξει κάποιο προϊόν για αγορά");
            }
            else
            {
                BarPay barPay = new BarPay(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value), Convert.ToInt32(numericUpDown6.Value), Convert.ToInt32(numericUpDown7.Value));
                barPay.Show();
                this.Hide();
            }
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
            Hall hall = new Hall();
            hall.Show();
            this.Hide();
            
        }

        private void βΟΗΘΕΙΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε την ποσότητα που επιθυμείτε από το κάθε προϊόν του μπαρ και πάτηστε οκ.");
        }

        private void σΧΕΤΙΚΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Δημιούργηθηκε από τους Μπούντα Γεώργιο και Μηλιαρέση Σπύριδων.");
        }

        private void Bar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }        
    }
}
