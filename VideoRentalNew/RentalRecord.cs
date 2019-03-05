using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace VideoRentalNew
{
    class RentalRecord
    {

        SqlConnection con;
        String Constr = "Data Source=LAPTOP-NI9FNBTG\\SQLEXPRESS02;Initial Catalog=VideoRental;Integrated Security=True";
        SqlCommand command;
        SqlDataReader reader;
        public void RentalInsDelUpdt(String qry)
        {
            con = new SqlConnection(Constr);
            con.Open();
            command = new SqlCommand(qry, con);
            int y = command.ExecuteNonQuery();

            con.Close();

        }

        public DataTable rentalfetchRecord(String qry)
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



        public void addRentalVideo(String qry)
        {
            RentalInsDelUpdt(qry);
        }


        public void delRentalVideo(int id)
        {
            String qry = "delete from RentalTable where id=" + id + " && ReturnedDate!='Rent'";
            RentalInsDelUpdt(qry);

        }

        public DataTable showRentalRecord()
        {
            String qry = "select * from RentalTable";
            DataTable tblCustomer = new DataTable();
            tblCustomer = rentalfetchRecord(qry);
            return tblCustomer;

        }
    }
}
