using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_clinic_management
{
    class expenses
    {
        public int expenses_id { get; set; }
        public String expenses_name { get; set; }
        public double price { get; set; }
        public String Expense_date { get; set; }

        public expenses(int expenses_id, String expenses_name, double price, String Expense_date)
        {
            this.expenses_id = expenses_id;
            this.expenses_name = expenses_name;
            this.price = price;
            this.Expense_date = Expense_date;
        }
    }
}
