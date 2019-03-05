using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VideoRentalNew
{
    class Record
    {
        SqlConnection con;
        String Constr = "Data Source=LAPTOP-NI9FNBTG\\SQLEXPRESS02;Initial Catalog=VideoRental;Integrated Security=True";
        SqlCommand command;
        SqlDataReader reader;

        public Boolean InsDelUpdt(String qry) {
            con = new SqlConnection(Constr);
            con.Open();
            command = new SqlCommand(qry,con);
            int y = command.ExecuteNonQuery();
            
            con.Close();
            if (y == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public DataTable fetchRecord(String qry) {

            con = new SqlConnection(Constr);

            con.Open();
            command = new SqlCommand(qry, con);

            reader = command.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            con.Close();

            return dt;

        }
        public void addVideo(String qry) {
            InsDelUpdt(qry);
        }

        public void delVideo(int id) {
            String qry = "delete from VideosTable where id=" + id + "";
            InsDelUpdt(qry);
        }



        public DataTable videoRecord() {
            String qry = "select * from VideosTable";
            DataTable tbl = new DataTable();
            tbl = fetchRecord(qry);
            return tbl;
        }
    }
}
