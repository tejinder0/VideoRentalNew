using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalNew
{
    public partial class Form1 : Form
    {
        Record objVideo = new Record();
        customerRecord objCustomer = new customerRecord();
        RentalRecord objRental = new RentalRecord();

        int videoId = 0,CustomerId=0,RentalId=0;

        int Videoct = 0, CustCt = 0, RentCt = 0;

        public Form1()
        {
            InitializeComponent();
            DataTable tblCustomer = new DataTable();
            tblCustomer = objCustomer.showCustomerRecord();
            Record.DataSource = tblCustomer;
        }

        private void videoAddBtn_Click(object sender, EventArgs e)
        {
            try {
                String qry = "insert into VideosTable (VideoRating,VideoTitle,VideoYear,VideoCost,VideoCopies,VideoPlot,VideoGenre) values('" + ratingTxtBox.Text.ToString() + "','" + titleTxtBox.Text.ToString() + "','" + yearNmBox.Value.ToString() + "','" + costNmBox.Value.ToString() + "'," + Convert.ToInt32(copiesTxtBox.Text.ToString()) + ",'" + plotTxtBox.Text.ToString() + "','" + genreTxtBox.Text.ToString() + "')";
                objVideo.addVideo(qry);

                
                /*
                qry = "";
                qry = "select * from  VideosTable ORDER BY id DESC";
                DataTable tbl = new DataTable();
                tbl=objVideo.fetchRecord(qry);
                int MovieId = 0;

                if (tbl.Rows.Count > 0) {
                    MovieId =Convert.ToInt32( tbl.Rows[0]["id"].ToString());
                }

                qry = "";
                qry = "insert into VideoCopy(MovieId,Moviecount) values("+MovieId+","+Convert.ToInt32(copiesTxtBox.Text.ToString())+")";
                objVideo.addVideo(qry);


    */






                MessageBox.Show("Video is Saved");
                DataTable tblRecord = new DataTable();
                tblRecord = objVideo.videoRecord();
                Record.DataSource = tblRecord;

            }
            catch (Exception ex){
                MessageBox.Show("Please Check the Record ");
            }
            
        }

        private void yearNmBox_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            int yr = now.Year;
            int diff = yr - Convert.ToInt32(yearNmBox.Value);
            
            if (diff >= 5)
            {
                costNmBox.Value = 2;
               // MessageBox.Show(diff.ToString());
            }
            if (diff >= 0 && diff < 5)
            {
                costNmBox.Value =5;
            }
        }

        private void videoBtn_Click(object sender, EventArgs e)
        {
            Videoct = 1;

            DataTable tblRecord = new DataTable();
            tblRecord=objVideo.videoRecord();
            Record.DataSource = tblRecord;


        }

        private void Record_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Record_DoubleClick(object sender, EventArgs e)
        {

            if (Videoct==1) {
                videoId = Convert.ToInt32(Record.CurrentRow.Cells[0].Value.ToString());
                ratingTxtBox.Text = Record.CurrentRow.Cells[1].Value.ToString();
                titleTxtBox.Text = Record.CurrentRow.Cells[2].Value.ToString();
                yearNmBox.Value = Convert.ToInt32(Record.CurrentRow.Cells[3].Value.ToString());
                costNmBox.Value = Convert.ToInt32(Record.CurrentRow.Cells[4].Value.ToString());
                copiesTxtBox.Text = Record.CurrentRow.Cells[5].Value.ToString();
                plotTxtBox.Text = Record.CurrentRow.Cells[6].Value.ToString();
                genreTxtBox.Text = Record.CurrentRow.Cells[7].Value.ToString();
                MovieIDLbl.Text= Record.CurrentRow.Cells[0].Value.ToString();

                Videoct = 0;

            }
            if (CustCt == 1) {
                    customerIDLbl.Text= Record.CurrentRow.Cells[0].Value.ToString();
                CustomerId = Convert.ToInt32(Record.CurrentRow.Cells[0].Value.ToString());
                    CustomerNameTxtBox.Text= Record.CurrentRow.Cells[1].Value.ToString();
                    phoneNmBox.Text = Record.CurrentRow.Cells[2].Value.ToString();
                    addressTxtBox.Text= Record.CurrentRow.Cells[3].Value.ToString();
                CustCt = 0;
                
            }
            if (RentCt==1) {
                RentalId= Convert.ToInt32(Record.CurrentRow.Cells[0].Value.ToString());
                customerIDLbl.Text= Record.CurrentRow.Cells[1].Value.ToString();
                MovieIDLbl.Text= Record.CurrentRow.Cells[2].Value.ToString();
                IssuedDateDtp.Text= Record.CurrentRow.Cells[3].Value.ToString();
                returnedDateDtp.Enabled = true;
                RentCt = 0;
            }

        }

        private void videoDeleteBtn_Click(object sender, EventArgs e)
        {
            if (videoId > 0)
            {
                objVideo.delVideo(videoId);

                String qry = "delete from VideoCopy where MovieId=" + videoId + "";
                objVideo.InsDelUpdt(qry);


                DataTable tblRecord = new DataTable();
                tblRecord = objVideo.videoRecord();
                Record.DataSource = tblRecord;

            }
            else {
                MessageBox.Show("First of all Select the Video to Delete");
            }



        }

        private void videoUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoId > 0)
                {
                    String qry = "update VideosTable set VideoRating='" + ratingTxtBox.Text.ToString() + "',VideoTitle='" + titleTxtBox.Text.ToString() + "',VideoYear='" + yearNmBox.Value.ToString() + "',VideoCost='" + costNmBox.Value.ToString() + "',VideoCopies=" + Convert.ToInt32(copiesTxtBox.Text.ToString()) + ",VideoPlot='" + plotTxtBox.Text.ToString() + "',VideoGenre='" + genreTxtBox.Text.ToString() + "' where id=" + videoId + "";
                    objVideo.InsDelUpdt(qry);



                    qry = "";
                    qry = "update VideoCopy set   Moviecount=" + Convert.ToInt32(copiesTxtBox.Text.ToString()) + " where MovieId=" + videoId + "";
                    objVideo.InsDelUpdt(qry);



                    MessageBox.Show("Record is Updated ");


                    DataTable tblRecord = new DataTable();
                    tblRecord = objVideo.videoRecord();
                    Record.DataSource = tblRecord;

                }
                else
                {
                    MessageBox.Show("Select the Record First");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Check the Record First");
            }
        }

        private void rentalBtn_Click(object sender, EventArgs e)
        {
            DataTable tblRental = new DataTable();
            tblRental = objRental.showRentalRecord();
            Record.DataSource = tblRental;
            RentCt = 1;
        }

        private void movieIssueBtn_Click(object sender, EventArgs e)
        {
            if (!customerIDLbl.Text.Equals("") && !MovieIDLbl.Text.Equals(""))
            {
                String qry = "insert into RentalTable(Customer_Id,Movie_Id,IssuedDate,returnedDate)values('" + customerIDLbl.Text.ToString() + "','" + MovieIDLbl.Text.ToString() + "','" + IssuedDateDtp.Value.ToShortDateString() + "','Rent')";
                objRental.addRentalVideo(qry);

                MessageBox.Show("Movie is Issued on Rent");
                DataTable tblRental = new DataTable();
                tblRental = objRental.showRentalRecord();
                Record.DataSource = tblRental;



            }
            else {
                MessageBox.Show("Check the Record Before Issue movie on rent");
            }

        }

        private void movieDeletebtn_Click(object sender, EventArgs e)
        {
            if (RentalId > 0)
            {
                objRental.delRentalVideo(RentalId);
                MessageBox.Show("Video is Deleted");

                DataTable tblRental = new DataTable();
                tblRental = objRental.showRentalRecord();
                Record.DataSource = tblRental;



            }
            else {
                MessageBox.Show("Select the Record Before Deleting it");
            }


        }

        private void movieReturnbtn_Click(object sender, EventArgs e)
        {
            int bill, Cost = 0;
            DataTable tbl = new DataTable();

            String qry = "";
            qry = "select * from VideosTable where id=" + Convert.ToInt32(MovieIDLbl.Text.ToString()) + "";
            tbl = objRental.rentalfetchRecord(qry);

            if (tbl.Rows.Count > 0)
            {
                Cost = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["VideoCost"].ToString());

            }

            qry = "update RentalTable set Customer_Id="+customerIDLbl.Text.ToString()+",Movie_id="+MovieIDLbl.Text.ToString()+",IssuedDate='"+IssuedDateDtp.Value.ToShortDateString()+"',ReturnedDate='"+returnedDateDtp.Value.ToShortDateString()+"'";
            objRental.RentalInsDelUpdt(qry);


            DateTime Current_date = DateTime.Now;


            DateTime Old_date = Convert.ToDateTime(IssuedDateDtp.Value.ToString());



            String diff = (Current_date - Old_date).TotalDays.ToString();



            Double dif = Math.Round(Convert.ToDouble(diff));


            bill = Cost * Convert.ToInt32(dif);

            MessageBox.Show("Your Total Charges is==$" + bill);

            DataTable tblRental = new DataTable();
            tblRental = objRental.showRentalRecord();
            Record.DataSource = tblRental;

        }

        private void customerUpdateBtn_Click(object sender, EventArgs e)
        {
            if (CustomerId > 0)
            {
                String qry = "update CustomerTable set CustomerName='" + CustomerNameTxtBox.Text.ToString() + "', CustomerPhone='" + phoneNmBox.Text.ToString() + "',CustomerAddress='" + addressTxtBox.Text.ToString() + "' where id=" + CustomerId+ "";
                objCustomer.customerInsDelUpdt(qry);
                MessageBox.Show("Customer Record is Updated");

                DataTable tblCustomer = new DataTable();
                tblCustomer = objCustomer.showCustomerRecord();
                Record.DataSource = tblCustomer;

            }
            else
            {
                MessageBox.Show("You have to select the Customer First");
            }

        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String qry = "insert into CustomerTable(CustomerName,CustomerPhone,CustomerAddress)values('" + CustomerNameTxtBox.Text.ToString() + "','" + phoneNmBox.Text.ToString() + "','" + addressTxtBox.Text.ToString() + "')";
                objCustomer.addCustomer(qry);
                MessageBox.Show("Customer Record is Saved");
                DataTable tblCustomer = new DataTable();
                tblCustomer = objCustomer.showCustomerRecord();
                Record.DataSource = tblCustomer;
            }
            catch (Exception ex) {
                MessageBox.Show("Check the Record First");
            }


        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustCt = 1;

            DataTable tblCustomer = new DataTable();
            tblCustomer = objCustomer.showCustomerRecord();
            Record.DataSource = tblCustomer;
        }

        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {
            if (CustomerId > 0)
            {
                objCustomer.delCustomer(CustomerId);
                MessageBox.Show("Customer Record is Deleted");

                DataTable tblCustomer = new DataTable();
                tblCustomer = objCustomer.showCustomerRecord();
                Record.DataSource = tblCustomer;

            }
            else {
                MessageBox.Show("First of all Select the Customer then You can Delete");
            }
        }
    }
}
