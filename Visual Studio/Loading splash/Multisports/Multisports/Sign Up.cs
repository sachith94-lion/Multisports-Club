using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Multisports
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool allcorrect = false;
        Conection obj = new Conection();
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string User_Name = txt_UN.Text;
                string Password = txt_RePassword.Text;
                string Email = txt_Email.Text;
                string Password1 = txt_Password.Text;

                if(User_Name !="" && Password !="" && Password1 !="" && Email !="" && txt_AdminPW.Text=="c#@123.Nibm" && txt_Password.Text==txt_RePassword.Text && allcorrect == true)
                {

                    SqlConnection con = obj.connect();
                    con.Open();
                    string sqlinsert = "insert into Users values('"+ User_Name + "','" + Password + "','" + Email + "')";
                    SqlCommand cmb = new SqlCommand(sqlinsert, con);
                    cmb.ExecuteNonQuery();
                    MessageBox.Show("Signed up successfully");
                    con.Close();
                    this.Hide();
                    Login ss = new Login();
                    ss.Show();
                }

                
                else 
                {
                    MessageBox.Show("Please complete sign up the form correctly");
                }

                EPW_un.Clear();
                EPC_un.Clear();
                EPW_pass.Clear();
                EPC_pass.Clear();
                EPW_pass.Clear();
                EPC_pass.Clear();
                EPC_email.Clear();
                EPW_email.Clear();
                EPC_email.Clear();
                EPW_email.Clear();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lob = new Login();
            lob.Show();
            EPW_un.Clear();
            EPC_un.Clear();
            EPW_pass.Clear();
            EPC_pass.Clear();
            EPW_pass.Clear();
            EPC_pass.Clear();
            EPC_email.Clear();
            EPW_email.Clear();
            EPC_email.Clear();
            EPW_email.Clear();
        }

        private void txt_UN_Leave(object sender, EventArgs e)
        {
            if (txt_UN.Text != "")
            {
                EPC_un.SetError(txt_UN, "correct");
                EPW_un.Clear();
                allcorrect = true;
            }
            else if (txt_UN.Text == "")
            {
                EPW_un.SetError(txt_UN, "Cannot keep Username blank");
                EPC_un.Clear();
                allcorrect = false;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text != "")
            {
                EPC_pass.SetError(txt_Password, "correct");
                EPW_pass.Clear();
                allcorrect = true;
            }
            else if (txt_Password.Text == "")
            {
                EPW_pass.SetError(txt_Password, "Cannot keep password blank");
                EPC_pass.Clear();
                allcorrect = false;
            }
        }

        private void txt_RePassword_Leave(object sender, EventArgs e)
        {
            if (txt_RePassword.Text != "" && txt_Password.Text==txt_RePassword.Text)
            {
                EPC_pass.SetError(txt_RePassword, "correct");
                EPW_pass.Clear();
                allcorrect = true;
            }
            else if (txt_RePassword.Text == "" || txt_Password.Text != txt_RePassword.Text)
            {

                EPW_pass.SetError(txt_RePassword, "Cannot keep password blank and passwords should be a match");
                EPC_pass.Clear();
                allcorrect = false;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text != "")
            {
                EPC_email.SetError(txt_Email, "correct");
                EPW_email.Clear();
                allcorrect = true;
            }
            else if (txt_Email.Text == "")
            {
                EPW_email.SetError(txt_Email, "Cannot keep email blank");
                EPC_email.Clear();
                allcorrect = false;
            }
        }

        private void txt_AdminPW_Leave(object sender, EventArgs e)
        {
            if (txt_AdminPW.Text != "" && txt_AdminPW.Text == "c#@123.Nibm")
            {
                EPC_email.SetError(txt_AdminPW, "correct");
                EPW_email.Clear();
                allcorrect = true;
            }
            else if (txt_AdminPW.Text == "")
            {
                EPW_email.SetError(txt_AdminPW, "Cannot keep admin password blank");
                EPC_email.Clear();
                allcorrect = false;
            }
        }
    }
}
