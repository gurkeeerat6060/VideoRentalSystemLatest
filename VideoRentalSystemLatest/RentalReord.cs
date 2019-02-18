using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace VideoRentalSystemLatest
{
    // using the concept of inheritance database class is connect with the rental Class to use all the method and use the queries
    public class RentalReord: DataBaseClass
    {
        // this method is used to add the rental record in the table
        public int AddRentalVideo(String sql)
        {
            int y = InsDelUpt(sql);
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        //this method is used to delete the rental video record 
        public int DelRentalVideo(String sql)
        {
            int y = InsDelUpt(sql);
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        //this method is used to update the rental video record
        public int UpdtRentalVideo(String sql)
        {
            int y = InsDelUpt(sql);
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        //this method is used to view the whole record from the table
        public DataTable AllRentalVideo()
        {
            //  get the whole record from the table calling the All record method and pass to the data table and then return to forward to main class
            String sql = "select * from RentalTbl";
            DataTable tbl = AllRecords(sql);
            return tbl;
        }


    }
}
