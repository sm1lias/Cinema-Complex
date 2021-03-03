using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Complex
{
    class Globals
    {        
        public static int id = 0;
        public static double value = 0;
        public static double value1 = 0;
        public static double value2 = 0;
        public static double value3 = 0;
        public static double value4 = 0;
        public static double value5 = 0;
        public static double value6 = 0;
        public static double value7 = 0;
        public static bool IsCreditCardInfoValid(string cardNo, string expiryDate, string cvv, string name)
        {
            var cardCheck = new Regex(@"^([0-9]{4})([\-\s]?[0-9]{4}){3}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");
            var cname = new Regex(@"^([A-Z]*)\040([A-Z]*)");


            if (!cardCheck.IsMatch(cardNo))
            {
                MessageBox.Show("Λάθος αριθμός κάρτας");
                return false;
            }
            if (!cvvCheck.IsMatch(cvv))
            {
                MessageBox.Show("Λάθος αριθμός ccv");
                return false;
            }
            if (!cname.IsMatch(name))
            {
                MessageBox.Show("Λάθος όνομα");
                return false;
            }



            var dateParts = expiryDate.Split('/'); //expiry date in from MM/yyyy            
            if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1]))
            {
                MessageBox.Show("Λάθος αριθμός λήξης");
                return false;
            }

            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);

            //check expiry greater than today & within next 6 years <7, 8>>

            if ((cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6)) == false)
                MessageBox.Show("Λάθος αριθμός λήξης");
            return (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6));
        }
    }
}
