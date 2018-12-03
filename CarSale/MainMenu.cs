using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSale
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
           //DateTime datee = new DateTime.Now;
           // this.time.Text= datee.ToString();

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();//hide main menu form
            CustomerRegistration customer = new CustomerRegistration();
            customer.ShowDialog();//open the second form
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Billingdetails bill = new Billingdetails();
            bill.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();//hide main menu form
            EmployeeRegistration employee = new EmployeeRegistration();
            employee.ShowDialog();//open the employee form
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();//hide main menu form
            DealerRegistration dealer = new DealerRegistration();
            dealer.ShowDialog();//open the dealer form
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CustomeResponse customerR = new CustomeResponse();
            customerR.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CustomerComplaints customerC = new CustomerComplaints();
            customerC.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ServiceDetails service = new ServiceDetails();
            service.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SubmissionDetails submit = new SubmissionDetails();
            submit.ShowDialog();
        }

        private void vehReg_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            VehicleReg vehicle = new VehicleReg();
            vehicle.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Users user = new Users();
            user.ShowDialog();//open the  form
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
