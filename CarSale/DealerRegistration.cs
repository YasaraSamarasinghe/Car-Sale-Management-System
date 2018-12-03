﻿using System;
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
    public partial class DealerRegistration : Form
    {
        public DealerRegistration()
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

        private void dAddress_txt_TextChanged(object sender, EventArgs e)
        {

        }

        
        string Gender;




        private void DealerRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult dialog = MessageBox.Show("Do you want to exit the car management system?",
            //   "Exit car Management System", MessageBoxButtons.YesNo);
            //if (dialog == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else if (dialog == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}

        }


        private void male_rdo_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "male";
        }

        private void fmale_rdo_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "female";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

       


        private void DealerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();//open the main form
        }

        private void submit_btn_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            string query = "insert into carsale.dealerregistration(DealerID,FirstName,Sername,DateOfBirth,Gender,Address,PhoneNo,Email) values('" + this.dID_txt.Text + "','" + this.dfname_txt.Text + "','" + this.dSname_txt.Text + "','" + this.dateTimePickerdealer.Text + "','" + Gender + "','" + this.dAddress_txt.Text + "','" + this.dPhone_txt.Text + "','" + this.dmail_txt.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Dealer Registration Details saved");// confirm data is saved
                while (myReader.Read())
                {

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            string query = "update carsale.dealerregistration set DealerID='" + this.dID_txt.Text + "',FirstName='" + this.dfname_txt.Text + "',Sername='" + this.dSname_txt.Text + "',DateOfBirth='" + this.dateTimePickerdealer.Text + "',Address='" + this.dAddress_txt.Text + "',PhoneNo='" + this.dPhone_txt.Text + "',Email='" + this.dmail_txt.Text + "' where DealerID='" + this.dID_txt.Text + "'  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Dealer Details Updated");// confirm data is saved
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
            string query = "delete from carsale.dealerregistration where DealerID='" + this.dID_txt.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Dealer Details Updated");// confirm data is saved
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from carsale.dealerregistration where DealerID='" + this.dID_txt.Text + "';", conDatabase);

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

        private void ldTable_btn_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from carsale.dealerregistration;", conDatabase);

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
