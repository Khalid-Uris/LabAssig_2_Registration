using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LabAssig_2_Registration
{
    public partial class Form1 : Form
    {
        string value = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string value = "";

            value += txtFname.Text + "\n";
            value += txtLname.Text + "\n";
            value += txtMathor.Text + "\n";
            value += txtdate.Value.ToString("dd/MM/yyyy")+"\n";
            value += cmbCountry.Text + "\n";
            value += rbMale.Checked ? "Male" : "Female" + "\n";
            value += txtemail.Text + "\n";
            value += txtpassword.Text + "\n";
            value += txtConfirmpassword.Text + "\n";
            value += txtMobileNo.Text + "\n";
            value += txtCapt.Text + "\n";

            
            if(txtFname.Text=="")
            {
                txtFname.BackColor = Color.IndianRed;
            }
            else
            {
                txtFname.BackColor = Color.White;
            }
            if (txtLname.Text == "")
            {
                txtLname.BackColor = Color.IndianRed;
            }
            else
            {
                txtLname.BackColor = Color.White;
            }
            if (txtMathor.Text == "")
            {
                txtMathor.BackColor = Color.IndianRed;
            }
            else
            {
                txtMathor.BackColor = Color.White;
            }
            if (txtemail.Text == "")
            {
                txtemail.BackColor = Color.IndianRed;
            }
            else
            {
                txtemail.BackColor = Color.White;
            }
            if (txtpassword.Text == "")
            {
                txtpassword.BackColor = Color.IndianRed;
            }
            else
            {
                txtpassword.BackColor = Color.White;
            }
            if (txtConfirmpassword.Text == "")
            {
                txtConfirmpassword.BackColor = Color.IndianRed;
            }
            else
            {
                txtConfirmpassword.BackColor = Color.White;
            }
            if(txtMobileNo.Text=="")
            {
                txtMobileNo.BackColor = Color.IndianRed;
            }
            else
            {
                txtMobileNo.BackColor = Color.White;
            }
            if (txtCapt.Text == "")
            {
                txtCapt.BackColor = Color.IndianRed;
            }
            else
            {
                txtCapt.BackColor = Color.White;
                MessageBox.Show(value);


                txtFname.Clear();
                txtLname.Clear();
                txtMathor.Clear();
                cmbCountry.Text = "";
                txtemail.Clear();
                txtpassword.Clear();
                txtConfirmpassword.Clear();
                txtMobileNo.Clear();
                txtCapt.Clear();

                MessageBox.Show("Registered Successfull", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //txtFname.BackColor = Color.White;
                //txtLname.BackColor = Color.White;


            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                //MessageBox.Show(value);
                //MessageBox.Show("Registered Successfull", "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

       /* //First name Test Change 110
        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            if(txtFname==null)
            {
                MessageBox.Show("Enter First Name", "Registration Form", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }*/

        private void txtFname_Validating(object sender, CancelEventArgs e)
        {
            Regex rg_name = new Regex(@"^[a-zA-Z0-9]{6,}$");

            if (!rg_name.IsMatch(txtFname.Text))
            {
                errmsg.SetError(txtFname, "Invalid Input");
            }
            else
            {
                errmsg.Clear();
            }

        }

        private void txtLname_Validating(object sender, CancelEventArgs e)
        {
            Regex rg_Lname = new Regex(@"^[a-zA-Z0-9]{7,}$");

            if(!rg_Lname.IsMatch(txtLname.Text))
            {
                errmsg.SetError(txtLname, "Invalid Input");
            }
            else
            {
                errmsg.Clear();
            }

        }

        private void txtMathor_Validating(object sender, CancelEventArgs e)
        {
            Regex rg_Mothor = new Regex(@"^[a-zA-Z0-9]{8,}$");

            if (!rg_Mothor.IsMatch(txtMathor.Text))
            {
                errmsg.SetError(txtMathor, "Invalid Input");
            }
            else
            {
                errmsg.Clear();
            }
        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            Regex rg_email = new Regex(@"^[\w_\.]+@[a-z]{5,7}\.[a-z]{2,3}$");
            if (!rg_email.IsMatch(txtemail.Text))
            {
                errmsg.SetError(txtemail, "Invalid Email");
            }
            else
            {
                errmsg.Clear();
            }
        }

        private void txtConfirmpassword_TextChanged(object sender, EventArgs e)
        {
            if(txtpassword.Text != txtConfirmpassword.Text)
            {
                errmsg.SetError(txtConfirmpassword, "Password is not matched");
            }
            else
            {
                errmsg.Clear();
            }
        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(System.DateTime.Now.Year - txtdate.Value.Year);

            if(age<=18)
            {
                errmsg.SetError(txtdate, age + " you are below 18");
            }
            else
            {
                errmsg.Clear();
            }
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCountry.Text.Equals("Pakistan"))
            {
                listBox1.Visible = true;
                listBox1.Items.Add("Karachi");
                listBox1.Items.Add("Hyderabad");
                listBox1.Items.Add("Lahore");
                listBox1.Items.Add("Peshawar");
                
            }
            else if(cmbCountry.Text.Equals("India"))
            {
                listBox1.Visible = true;
                listBox1.Items.Add("Mumbai");
                listBox1.Items.Add("Kolkata");
                listBox1.Items.Add("New Delhi");
                listBox1.Items.Add("Chennai");
               
            }
            else if(cmbCountry.Text.Equals("England"))
            {
                listBox1.Visible = true;
                listBox1.Items.Add("London");
                listBox1.Items.Add("Manchester");
                listBox1.Items.Add("Bristol");
                listBox1.Items.Add("Cambridge");

            }
            else if(cmbCountry.Text.Equals("USA"))
            {
                listBox1.Visible = true;
                listBox1.Items.Add("New York");
                listBox1.Items.Add("Los Angeles");
                listBox1.Items.Add("Chicago");
                listBox1.Items.Add("Houston");
            }
            else
            {
                listBox1.Visible = false;
            }
            
        }

        private void txtMobileNo_Validating(object sender, CancelEventArgs e)
        {
            Regex rg_mobile = new Regex(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$");

            if(!rg_mobile.IsMatch(txtMobileNo.Text))
            {
                errmsg.SetError(txtMobileNo, "Number is Invalid");
            }
            else
            {
                errmsg.Clear();
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                errmsg.SetError(txtMobileNo, " only numbers allowed");
            }
            else
            {
                errmsg.Clear();
            }
        }

        //Conforms Password 175
        /*private void txtConfirmpassword_TextChanged(object sender, EventArgs e)
        {
            if(txtpassword==txtConfirmpassword)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Right Password";
            }
            else
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Wrong Password";
            }
        }*/
    }
}
