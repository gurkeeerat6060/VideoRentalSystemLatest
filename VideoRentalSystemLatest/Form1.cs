using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystemLatest
{
    public partial class Form1 : Form 
    {
        // object declaration of other classes that are used to call the method of that class
        Customer CustomerObj = new Customer();

        VideoRecord videoObj = new VideoRecord();

        RentalReord rentalObj = new RentalReord();

        //global  variables
        int video = 0, customer = 0, rental = 0;


        public Form1()
        {
            InitializeComponent();
        }

        
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            try {
                //verify the contact Number is Numeric or Not and also check textbox are not empty
                if (PhoneBox.Text.ToString().All(char.IsNumber) && !NameBox.Text.ToString().Equals("") && !PhoneBox.Text.ToString().Equals("") && !AdressBox.Text.ToString().Equals(""))
                {
                    String sql = "insert into  CustomerTbl(CustomerName,CustomerPh,CustomerAddress) values('" + NameBox.Text.ToString() + "','" + PhoneBox.Text.ToString() + "','" + AdressBox.Text.ToString() + "') ";

                    if (CustomerObj.AddCustomer(sql) != 0)
                    {
                        MessageBox.Show("Customer Record is Saved");
                        NameBox.Text = "";
                        PhoneBox.Text = "";
                        AdressBox.Text = "";
                        delUpdtCustomerBox.Text = "";


                        DataTable tbl = CustomerObj.AllCustomer();

                        RecordBox.Refresh();

                        RecordBox.DataSource = tbl;


                    }
                    else
                    {
                        MessageBox.Show("Customer Record is not Saved please Verify ");
                    }



                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error Message "+ex.Message);
            }
            

        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            try {
                // check the Customer Id is NUmeric or not
                if (delUpdtCustomerBox.Text.ToString().All(Char.IsNumber))
                {
                    // query to delete the Record from the Customer Table 
                    String sql = "delete from CustomerTbl where CustomerID=" + Convert.ToInt32(delUpdtCustomerBox.Text.ToString()) + "";
                    if (CustomerObj.DelCustomer(sql) != 0)
                    {
                        MessageBox.Show("Customer Record Is Deleted");
                        NameBox.Text = "";
                        PhoneBox.Text = "";
                        AdressBox.Text = "";
                        delUpdtCustomerBox.Text = "";

                        DataTable tbl = CustomerObj.AllCustomer();

                        RecordBox.Refresh();

                        RecordBox.DataSource = tbl;

                    }
                    else
                    {
                        MessageBox.Show("Customer Record Verify");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error " + ex.Message);
            }
            




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // calling the method from Customer Class to view the Whole Record of the Customer and pass the record to Table Class
            DataTable tbl = CustomerObj.AllCustomer();
            // after saving the record in the DataTable Class then pass the record to Data Grid View
            RecordBox.DataSource = tbl;
            
        }

        private void RecordBox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (video==1) {

                delUpdtVideoBox.Text= RecordBox.CurrentRow.Cells[0].Value.ToString();
                RatingBox.Text = RecordBox.CurrentRow.Cells[1].Value.ToString();
                TitleBox.Text = RecordBox.CurrentRow.Cells[2].Value.ToString();
                YearBox.Text = RecordBox.CurrentRow.Cells[3].Value.ToString();
                CostBox.Text = RecordBox.CurrentRow.Cells[4].Value.ToString();
                CopiesBox.Text = RecordBox.CurrentRow.Cells[5].Value.ToString();
                PlotBox.Text = RecordBox.CurrentRow.Cells[6].Value.ToString();
                GenreBox.Text = RecordBox.CurrentRow.Cells[7].Value.ToString();
                MovieIDBox.Text = RecordBox.CurrentRow.Cells[0].Value.ToString(); 
                video = 0;
            }
            if (customer==1) {
                //after double clicking  on the Data Grid View The Id is passed to Lable for modification and deleting the record 
                delUpdtCustomerBox.Text = RecordBox.CurrentRow.Cells[0].Value.ToString();
                NameBox.Text = RecordBox.CurrentRow.Cells[1].Value.ToString();
                PhoneBox.Text = RecordBox.CurrentRow.Cells[2].Value.ToString();
                AdressBox.Text = RecordBox.CurrentRow.Cells[3].Value.ToString();

                CustomerIDBox.Text = RecordBox.CurrentRow.Cells[0].Value.ToString();

                customer = 0;
            }
            if (rental==1) {

                RentalIDBox.Text = RecordBox.CurrentRow.Cells[0].Value.ToString();
                MovieIDBox.Text = RecordBox.CurrentRow.Cells[1].Value.ToString();
                CustomerIDBox.Text = RecordBox.CurrentRow.Cells[2].Value.ToString();
                DateOfIssueDTP.Text = RecordBox.CurrentRow.Cells[3].Value.ToString();

                rental = 0;


            }
            
        }
    
        private void CustomerRecordBtn_Click(object sender, EventArgs e)
        {
            // calling the method from Customer Class to view the Whole Record of the Customer and pass the record to Table Class
            DataTable tbl = CustomerObj.AllCustomer();
            // after saving the record in the DataTable Class then pass the record to Data Grid View
            RecordBox.DataSource = tbl;
            
            customer = 1;
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //verify the contact Number is Numeric or Not and also check textbox are not empty
                if (PhoneBox.Text.ToString().All(char.IsNumber) && !NameBox.Text.ToString().Equals("") && !PhoneBox.Text.ToString().Equals("") && !AdressBox.Text.ToString().Equals("") && delUpdtCustomerBox.Text.ToString().All(Char.IsNumber))
                {
                    String sql = "update CustomerTbl set CustomerName='" + NameBox.Text.ToString() + "',CustomerPh='" + PhoneBox.Text.ToString() + "',CustomerAddress='" + AdressBox.Text.ToString() + "' where CustomerID=" + Convert.ToInt32(delUpdtCustomerBox.Text.ToString()) + "";
                    //calling the update method of Customer
                    if (CustomerObj.UpdtCustomer(sql) != 0)
                    {
                        MessageBox.Show("Customer Record is Updated ");
                        NameBox.Text = "";
                        PhoneBox.Text = "";
                        AdressBox.Text = "";
                        delUpdtCustomerBox.Text = "";
                        DataTable tbl = CustomerObj.AllCustomer();

                        RecordBox.Refresh();

                        RecordBox.DataSource = tbl;


                    }
                    else
                    {
                        //display the error message
                        MessageBox.Show("Customer Record is not Updated please Verify ");
                    }
                }
                else {
                    //display the error message
                    MessageBox.Show("Fill all the Values");
                }
            }
            catch (Exception ex)
            {
                //display the error message
                MessageBox.Show("Error Message " + ex.Message);
            }


        }

        private void DeleteVideoButton_Click(object sender, EventArgs e)
        {
            // delete the video record after double clicking on the Video Grid
            if (delUpdtVideoBox.Text.ToString().All(Char.IsNumber))
            {
                // delete query to delete the record from the video table
                String sql = "delete from VideoTbl where VideoID=" + Convert.ToInt32(delUpdtVideoBox.Text.ToString()) + "";

                //calling the method of the del video to delete the record from the table
                if (videoObj.DelVideo(sql) != 0)
                {
                    MessageBox.Show("Video Record is Deleted");
                    RatingBox.Text = "";
                    TitleBox.Text = "";
                    YearBox.Text = "";
                    CostBox.Text = "";
                    CopiesBox.Text = "";
                    PlotBox.Text = "";
                    GenreBox.Text = "";
                    delUpdtVideoBox.Text = "";
                    DataTable tbl = videoObj.AllVideo();
                    RecordBox.Refresh();
                    RecordBox.DataSource = tbl;

                }
                else
                {
                    //display the error message
                    MessageBox.Show("Video Record is Not Deleted");
                }

            }
            else {
                //display the error message
                MessageBox.Show("Please check the Record");
            }
        }

        private void UpdateVideoButton_Click(object sender, EventArgs e)
        {
            //insert the record to the table after filling the record in the table 
            if (!RatingBox.Text.ToString().Equals("") && !TitleBox.Text.ToString().Equals("") && !YearBox.Text.ToString().Equals("") && YearBox.Text.ToString().All(Char.IsNumber) && CostBox.Text.ToString().All(Char.IsNumber) && CopiesBox.Text.ToString().All(Char.IsNumber) && !PlotBox.Text.ToString().Equals("") && !GenreBox.Text.ToString().Equals(""))
            {
                // update query is used to update the video record after verifying it properly
                String sql = "update VideoTbl set Ratting='" + RatingBox.Text.ToString() + "',Title='" + TitleBox.Text.ToString() + "',Year='" + YearBox.Text.ToString() + "',Cost=" + Convert.ToInt32(CostBox.Text.ToString()) + ",Copies=" + Convert.ToInt32(CopiesBox.Text.ToString()) + ",Plot='" + PlotBox.Text.ToString() + "',Genre='" + GenreBox.Text.ToString() + "' where VideoID=" + Convert.ToInt32(delUpdtVideoBox.Text.ToString()) + "";
                //calling the update method using the polymorphism 
                if (videoObj.UpdtVideo(sql) != 0)
                {
                    MessageBox.Show("Video Record is Saved ");
                    RatingBox.Text = "";
                    TitleBox.Text = "";
                    YearBox.Text = "";
                    CostBox.Text = "";
                    CopiesBox.Text = "";
                    PlotBox.Text = "";
                    GenreBox.Text = "";
                    delUpdtVideoBox.Text = "";

                    DataTable tbl = videoObj.AllVideo();
                    RecordBox.Refresh();
                    RecordBox.DataSource = tbl;

                }
                else
                {
                    //display the error message
                    MessageBox.Show("Video Record is not Saved Verify First");
                }
            }
            else
            {
                //display the error message
                MessageBox.Show("Check the Whole Record First and then Insert");
            }


        }

        private void YearBox_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void YearBox_TextChanged(object sender, EventArgs e)
        {
            try {
                //get theCurrent Date for calculating the Price of the Video 
                DateTime now = DateTime.Now;
                //get the Year from the Current Date
                int yr = now.Year;
                //calcualte the differnce between the Current year and Video Year for Getting the differnce between them
                int diff = yr - Convert.ToInt32(YearBox.Text.ToString());

                //if difference is greater than 5 then the cost price is 2 dollar other wise 5 dollar
                if (diff >= 5)
                {
                    CostBox.Text = "2";
                }
                if (diff >= 0 && diff < 5)
                {
                    CostBox.Text = "5";
                }
            }
            catch (Exception ex) {

            }
            
        }

        private void IssuedButton_Click(object sender, EventArgs e)
        {
            //verify the record before saving the data in the Rental Video
            if (MovieIDBox.Text.ToString().All(Char.IsNumber) && CustomerIDBox.Text.ToString().All(Char.IsNumber)) {

                int count = 1;
                String qry = "select * from MovieCount where MovieID="+ Convert.ToInt32(MovieIDBox.Text.ToString()) + "";
                DataTable tbl = rentalObj.AllRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    count =Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["cunt"].ToString());
                    count++;

                    qry = "update MovieCount set Cunt=" + count + " where MovieID=" + Convert.ToInt32(MovieIDBox.Text.ToString()) + "";
                    rentalObj.UpdtRentalVideo(qry);


                }
                else {
                    qry = "insert into MovieCount(MovieID,Cunt)values("+ Convert.ToInt32(MovieIDBox.Text.ToString()) + ","+count+")";
                    rentalObj.AddRentalVideo(qry);
              
                }


                qry = "select * from CustomerCount where CustomerID=" + Convert.ToInt32(CustomerIDBox.Text.ToString()) + "";
                tbl=rentalObj.AllRecords(qry);
                count = 1;
                if (tbl.Rows.Count > 0)
                {
                    count = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["cunt"].ToString());
                    count++;

                    qry = "update CustomerCount set Cunt=" + count + " where CustomerID=" + Convert.ToInt32(CustomerIDBox.Text.ToString()) + "";
                    rentalObj.UpdtRentalVideo(qry);

                }
                else {
                    qry = "insert into CustomerCount (CustomerID,Cunt) values(" + Convert.ToInt32(CustomerIDBox.Text.ToString()) + ","+count+")";
                    rentalObj.AddRentalVideo(qry);

                }





                // insert query to save the record in the table
                String sql = "insert into RentalTbl(MovieId,CustomerID,IssuedDate,ReturnDate) values("+Convert.ToInt32(MovieIDBox.Text.ToString())+","+Convert.ToInt32(CustomerIDBox.Text.ToString())+",'"+DateOfIssueDTP.Text.ToString()+"','Issued on Rent')";

                // calling the method using polymorphism concept call the method of AddRentalVideo 
                if (rentalObj.AddRentalVideo(sql) != 0)
                {
                    MessageBox.Show("Movie is Issued on Rental");

                    MovieIDBox.Text = "";
                    CustomerIDBox.Text = "";
                    RentalIDBox.Text = "";
                     tbl = rentalObj.AllRentalVideo();
                    RecordBox.Refresh();
                    RecordBox.DataSource = tbl;


                }
                else {

                    // display error message
                    MessageBox.Show("Check the Record ");
                }
            }


        }

        private void RentalRecordButton_Click(object sender, EventArgs e)
        {
            // calling the method from Video Class to view the Whole Record of the Customer and pass the record to Table Class
            DataTable tbl = rentalObj.AllRentalVideo();
            // after saving the record in the DataTable Class then pass the record to Data Grid View
            RecordBox.DataSource = tbl;

            rental = 1;

        }

        private void DeleteRentalButton_Click(object sender, EventArgs e)
        {
            // firstly verify the Rental id is Numeric or not then delete the record
            if (RentalIDBox.Text.ToString().All(Char.IsNumber))
            {
                String sql = "select * from RentalTbl where RentalID=" + Convert.ToInt32(RentalIDBox.Text.ToString()) + "";
                DataTable tbl = rentalObj.AllRecords(sql);
                if (tbl.Rows.Count > 0)
                {
                    if (!tbl.Rows[tbl.Rows.Count - 1]["ReturnDate"].ToString().Equals("Issued on Rent"))
                    {
                        //call the method of the rental class using the concept of polymorphism
                        sql = "delete from RentalTbl where RentalID=" + Convert.ToInt32(RentalIDBox.Text.ToString()) + "";
                        if (rentalObj.DelRentalVideo(sql) != 0)
                        {
                            MessageBox.Show(" Rental Record Is deleted");

                            MovieIDBox.Text = "";
                            CustomerIDBox.Text = "";
                            RentalIDBox.Text = "";
                            tbl = rentalObj.AllRentalVideo();
                            RecordBox.Refresh();
                            RecordBox.DataSource = tbl;
                        }
                        else
                        {
                            //display the Error Message
                            MessageBox.Show("Rental Record is Not Deleted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Movie is Already Issued on Rent first return and then u can delete it");
                    }
                }


            }
            else {
                MessageBox.Show("miyyi");
            }
        }

        private void ReturnedButton_Click(object sender, EventArgs e)
        {
            if (!MovieIDBox.Text.ToString().Equals("") && !CustomerIDBox.Text.ToString().Equals("")) {

                // get the Current Date 
                DateTime Current_date = DateTime.Now;
                //Get the Date of Issued Video
                DateTime Old_date = Convert.ToDateTime(DateOfIssueDTP.Value.ToString());
                 //Calculate the Difference  between the both days               
                String  diff = (Current_date - Old_date).TotalDays.ToString();
                //Convert the date in the Roundoff and interger also for calculation                                
                Double dif = Math.Round(Convert.ToDouble(diff));

                //query to get the cost from the video table for finding the cost
                String qry = "select * from VideoTbl where VideoID="+Convert.ToInt32(MovieIDBox.Text.ToString())+"";
                //get the records from the class using polymorphism concept
                DataTable tbl = videoObj.AllRecords(qry);

                int cost = 0,bill=0;
                
                if (tbl.Rows.Count > 0)
                {
                    //pass the value to local variable of the cost of rental video
                    cost = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["Cost"].ToString());

                }
                //calculate the bill of the video to display
                bill = cost * Convert.ToInt32(dif);


                // insert query to save the record in the table
                String sql = "update RentalTbl set MovieId=" + Convert.ToInt32(MovieIDBox.Text.ToString()) + ",CustomerID=" + Convert.ToInt32(CustomerIDBox.Text.ToString()) + ",IssuedDate='" + DateOfIssueDTP.Text.ToString() + "',ReturnDate='"+ReturnDateDTP.Text.ToString()+ "' where RentalID=" + Convert.ToInt32(RentalIDBox.Text.ToString()) + "";

                // calling the method using polymorphism concept call the method of AddRentalVideo 
                if (rentalObj.UpdtRentalVideo(sql) != 0)
                {
                    MessageBox.Show("Your Total Cost is ==$" + bill + " of the Rental Video");

                    MovieIDBox.Text = "";
                    CustomerIDBox.Text = "";
                    RentalIDBox.Text = "";
                     tbl = rentalObj.AllRentalVideo();
                    RecordBox.Refresh();
                    RecordBox.DataSource = tbl;
                }
                else
                {

                    // display error message
                    MessageBox.Show("Check the Record before Returning");
                }

      



            }




        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MostViewedMovieBUtton_Click(object sender, EventArgs e)
        {
            //query to find the movie id which is top reated or mostly issued on rent 
            String qry = "Select * from MovieCount ORDER BY Cunt DESC";
            DataTable tbl = videoObj.AllRecords(qry);
            int id = 0;
            id =Convert.ToInt32( tbl.Rows[tbl.Rows.Count - 1]["MovieID"].ToString());

            //get the name of the movie which is issued on the rent 
            qry = "select * from VideoTbl where VideoID="+id+"";
            tbl = videoObj.AllRecords(qry);
            String Movie = "";
            Movie = tbl.Rows[tbl.Rows.Count - 1]["Title"].ToString();
            MessageBox.Show(Movie + " Movie is most Viewed");


        }

        private void MostRatedCustomerButton_Click(object sender, EventArgs e)
        {
            //find the id of the customer who issued movie more then the others
            String qry = "Select * from CustomerCount ORDER BY Cunt DESC";
            DataTable tbl = videoObj.AllRecords(qry);
            int id = 0;
            id = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["CustomerID"].ToString());

            //get the name of the customer who issued the more movies
            qry = "select * from CustomerTbl where CustomerID=" + id + "";
            tbl = videoObj.AllRecords(qry);
            String Movie = "";
            Movie = tbl.Rows[tbl.Rows.Count - 1]["CustomerName"].ToString();
            MessageBox.Show(Movie + " Issued More Videos");

        }

        private void AddVideoButton_Click(object sender, EventArgs e)
        {
            //insert the record to the table after filling the record in the table 
            if (!RatingBox.Text.ToString().Equals("") && !TitleBox.Text.ToString().Equals("") && !YearBox.Text.ToString().Equals("") && YearBox.Text.ToString().All(Char.IsNumber) && CostBox.Text.ToString().All(Char.IsNumber) && CopiesBox.Text.ToString().All(Char.IsNumber) && !PlotBox.Text.ToString().Equals("") && !GenreBox.Text.ToString().Equals(""))
            {
                //insert query to insert the record for in the video table 
                String sql = "insert into VideoTbl(Ratting,Title,Year,Cost,Copies,Plot,Genre) values('" + RatingBox.Text.ToString() + "','" + TitleBox.Text.ToString() + "','" + YearBox.Text.ToString() + "'," + Convert.ToInt32(CostBox.Text.ToString()) + "," + Convert.ToInt32(CopiesBox.Text.ToString()) + ",'" + PlotBox.Text.ToString() + "','" + GenreBox.Text.ToString() + "')";
                //calling the mehtod of the video class using the polymorphism concept 
                if (videoObj.AddVideo(sql) != 0)
                {
                    MessageBox.Show("Video Record is Saved ");
                    RatingBox.Text = "";
                    TitleBox.Text = "";
                    YearBox.Text = "";
                    CostBox.Text = "";
                    CopiesBox.Text = "";
                    PlotBox.Text = "";
                    GenreBox.Text = "";
                    delUpdtVideoBox.Text = "";
                    DataTable tbl = videoObj.AllVideo();
                    RecordBox.Refresh();
                    RecordBox.DataSource = tbl;



                }
                else
                {
                    //display the error message 
                    MessageBox.Show("Video Record is not Saved Verify First");
                }
            }
            else {
                //display the error message
                MessageBox.Show("Check the Whole Record First and then Insert");
            }


        }

        private void VideosRecordButton_Click(object sender, EventArgs e)
        {
            // calling the method from Video Class to view the Whole Record of the Customer and pass the record to Table Class
            DataTable tbl =videoObj.AllVideo();
            // after saving the record in the DataTable Class then pass the record to Data Grid View
            RecordBox.DataSource = tbl;
            video = 1;
        }
    }
}


