using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace VideoRentalSystemLatest
{
   public class DataBaseClass 
    {
        SqlConnection con;
        String Constr = "Data Source=DESKTOP-M9OQP50;Initial Catalog=KiratDB;Integrated Security=True";
        SqlCommand command;
        SqlDataReader reader;

        public int InsDelUpt(String qry) {
            
            con = new SqlConnection(Constr);
            con.Open();
            command = new SqlCommand(qry, con);
            int y = command.ExecuteNonQuery();

            con.Close();
            return y;
        }


        public DataTable AllRecords(String qry)
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



    }

}
