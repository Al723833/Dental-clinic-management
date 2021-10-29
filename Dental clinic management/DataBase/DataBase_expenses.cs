using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_clinic_management
{
    class DataBase_expenses
    {

        SqlConnection con = new SqlConnection(@DataBaseAdmin.url_data_servar);
        SqlCommand cmd;
        SqlDataReader dr;

        public List<expenses> expensesCRUD(int expenses_id,
            String expenses_name,
            double price,
            String Expense_date,
            string StatementType)
        {
            List<expenses> expensesList = new List<expenses>();
            try
            {
                con.Open();
                cmd = new SqlCommand(
                    "expensesCRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@expenses_id", expenses_id));
                cmd.Parameters.Add(
                    new SqlParameter("@expenses_name", expenses_name));
                cmd.Parameters.Add(
                new SqlParameter("@price", price));
                cmd.Parameters.Add(
               new SqlParameter("@Expense_date", Expense_date));
               
                cmd.Parameters.Add(
               new SqlParameter("@StatementType", StatementType));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    expenses expenses = new expenses(Convert.ToInt32(dr["expenses_id"].ToString()),
                        dr["expenses_name"].ToString(),
                        Convert.ToDouble(dr["price"].ToString()),
                        dr["Expense_date"].ToString()
                        );
                    expensesList.Add(expenses);
                }
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (dr != null)
                {
                    dr.Close();
                }
            }
            return expensesList;
        }
    }
}
