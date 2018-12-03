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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click_1(object sender, EventArgs e)
        {

            try
            {
                string myconnect = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myconn = new MySqlConnection(myconnect);

                MySqlCommand SelectCommand = new MySqlCommand("select * from carsale.users where username='" + this.Username_txt.Text + "' and password = '" + this.Password_txt.Text + " ' ; ", myconn);


                MySqlDataReader myReader;
                myconn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0; //users
                while (myReader.Read())
                {
                    count = count + 1;//duplicate users
                }
                if (count == 1)// if correct
                {
                    MessageBox.Show("Welcome to Charles Oliver Motors Management System..");
                    this.Hide();//hide current form
                   MainMenu login = new MainMenu();
                    login.ShowDialog();//open the second form

                }

                else if (count > 1)//if wrong
                {
                    MessageBox.Show("Duplicate username and password");
                }
                else
                    MessageBox.Show("username or password is incorrect");
                myconn.Close();// close connection
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit the car management system?",
                "Exit car Management System", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
