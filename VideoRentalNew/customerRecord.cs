using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace VideoRentalNew
{
    class customerRecord
    {
        SqlConnection con;
        String Constr = "Data Source=LAPTOP-NI9FNBTG\\SQLEXPRESS02;Initial Catalog=VideoRental;Integrated Security=True";
        SqlCommand command;
        SqlDataReader reader;
        public void customerInsDelUpdt(String qry)
        {
            con = new SqlConnection(Constr);
            con.Open();
            command = new SqlCommand(qry, con);
            int y = command.ExecuteNonQuery();

            con.Close();
            
        }

        public DataTable customerfetchRecord(String qry)
        {

            con = new SqlConnection(Constr);

            con.Open();
            command = new SqlCommand(qry, con);

            reader = command.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            con.Close();

            return dt;

        }

        public void addCustomer(String qry) {
            customerInsDelUpdt(qry);
        }


        public void delCustomer(int id) {
            String qry = "delete from CustomerTable where id=" + id + "";
            customerInsDelUpdt(qry);

        }

        public DataTable showCustomerRecord() {
            String qry = "select * from CustomerTable";
            DataTable tblCustomer = new DataTable();
            tblCustomer = customerfetchRecord(qry);
            return tblCustomer;

        }
    }
}
