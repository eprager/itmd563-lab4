using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace MortgageCalculator2
{
    public class IOHelper_Database : IDataHelper
    {

        readonly string ConnectionString;

        public IOHelper_Database()
        {
            try
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["mortgagedb"].ToString();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"IOHelper_Database exception {e.Message} \n {e.StackTrace}");
                throw e;
            }

        }

        public String ClearMortgages()
        {
            try
            {
                string deleteCommand = "delete from Loans";

                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(deleteCommand, sqlConnection))
                    {
                        sqlConnection.Open();

                        int result = sqlCommand.ExecuteNonQuery();

                        sqlConnection.Close();
                    }

                    return "Mortgages cleared successfully";
                }
            }
            catch (IOException e)
            {
                return "The database could not be read";
            }
        }

        public String GetAllMortgages()
        {
            String mortgages = "";
            float princ;
            float interest;
            float dur;
            float monthPay;
            
            try
            {
                string selectCommand = "Select * from Loans";

                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    using  (SqlCommand sqlCommand = new SqlCommand(selectCommand, sqlConnection))
                    {
                        sqlConnection.Open();
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                princ = (float)Convert.ToDouble(sqlDataReader["Principle"]);
                                interest = (float)Convert.ToDouble(sqlDataReader["InterestRate"]);
                                dur = (float)Convert.ToDouble(sqlDataReader["DurationYears"]);
                                monthPay = (float)Convert.ToDouble(sqlDataReader["MonthlyPayment"]);

                                mortgages = mortgages + "\n" + princ.ToString() + " " + interest.ToString() + " " + dur.ToString() + " " + monthPay.ToString();
                            }
                        }
                        sqlConnection.Close();
                    }
                }

                
                return mortgages;
            }
            catch (IOException e)
            {
                return "The database could not be read";
            }
        }

        public void WriteMortgage(string formattedMonthString, float princ, float interest, float duration, float monthly)
        {

            string insert = "insert into Loans (Principle, InterestRate, DurationYears, MonthlyPayment) values (@princ, @interest, @duration, @monthly)";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(insert, sqlConnection);
                //sqlCommand.Parameters.Add("@princ", sqlDbType);
                //sqlCommand.Parameters.Add("@interest",);
                //sqlCommand.Parameters.Add("@duration", );
                //sqlCommand.Parameters.Add("@monthly",);


            }

        public void WriteMortgage(string month)
        {
            
        }
    }
}