using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace VideoRentalSystemLatest
{
    //using the concept of single level inheritance database class is connected with the video class so the queries can be executed
    public class VideoRecord: DataBaseClass
    {
        //this method is used to add the record to the table videos
        public int AddVideo(String sql)
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
        //this method is used to delete the record to the table videos
        public int DelVideo(String sql)
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
        //this method is used to Update the record to the table videos
        public int UpdtVideo(String sql)
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

        //this method is used to view  the whole record to the table videos
        public DataTable AllVideo()
        {
            //  get the whole record from the table calling the All record method and pass to the data table and then return to forward to main class
            String sql = "select * from VideoTbl";
            DataTable tbl = AllRecords(sql);
            return tbl;
        }
        

    }
}
