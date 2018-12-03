using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarSale
{
    public partial class VehicleReg : Form
    {
        public VehicleReg()
        {
            InitializeComponent();
        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }


        private void VehicleReg_Load(object sender, EventArgs e)
        {

        }

        private void vCondition_txt_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();

        }

       

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

    

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from carsale.vehicles where VehicleID='" + this.vID_txt.Text + "';", conDatabase);

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();
        }

        private void SAVE_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            string query = "insert into carsale.Vehicles(VehicleID,VehicleType,VehicleModel,Color,Status,Transmission,CarCondition,CarCapacity,Payment) values('" + this.vID_txt.Text + "','" + this.vType_cmbo.Text + "','" + this.vModel_cmbo.Text + "','" + this.vColor_txt.Text + "','" + this.vStatus_cmbo.Text + "','" + this.vTransmission_cmbo.Text + "','" + this.vCond_cmbo.Text + "','" + this.vCapacity_txt.Text + "','" + this.vPayment_cmbo.Text + "')";
            //MySqlConnection conDataBase = new MySqlConnection (constring);
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Customer Details saved");// confirm data is saved
                while (myReader.Read())
                {

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            string query = "update carsale.vehicles set  VehicleID='" + this.vID_txt.Text + "',VehicleType='" + this.vType_cmbo.Text + "',VehicleModel='" + this.vModel_cmbo.Text + "',Color='" + this.vColor_txt.Text + "',Status='" + this.vStatus_cmbo.Text + "',Transmission='" + this.vTransmission_cmbo.Text + "',CarCondition='" + this.vCond_cmbo.Text + "',CarCapacity='" + this.vCapacity_txt.Text + "',Payment='" + this.vPayment_cmbo.Text + "'where VehicleID='" + this.vID_txt.Text + "' ;";
            //MySqlConnection conDataBase = new MySqlConnection (constring);
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Customer Details Updated");// confirm data is saved
                while (myReader.Read())
                {

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.ShowDialog();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from carsale.Vehicles where SubmissionNumber='" + this.vID_txt.Text + "';", conDatabase);

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void showtable_btn_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from carsale.vehicles;", conDatabase);

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
