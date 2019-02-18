using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VideoRentalSystemLatest
{
    //this use of single level inheritance i have connected the database class with the customer class
    class Customer: DataBaseClass
    {
        //this method is used to Add the  record to the table Customer
        public int AddCustomer(String sql) {
            int y=InsDelUpt(sql);
            if (y == 0)
            {
                return 0;
            }
            else {
                return 1;
            }
        }

        //this method is used to delete the  record to the table Customer
        public int DelCustomer(String sql) {
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
        //this method is used to Update the  record to the table Customer
        public int UpdtCustomer(String sql)
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

        //this method is used to view the whole record to the table Customer
        public DataTable AllCustomer() {
            //  get the whole record from the table calling the All record method and pass to the data table and then return to forward to main class
            String sql = "select * from CustomerTbl";
            DataTable tbl = AllRecords(sql);
            return tbl;
        }

    }
}
