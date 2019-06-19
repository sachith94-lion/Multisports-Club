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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        public static string SetValueForUsername = "";
        private void lbl_LExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        Conection obj = new Conection();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            try
            {
                SetValueForUsername = txt_LUN.Text;
                test us = new test();

                SqlConnection con = obj.connect();
                con.Open();
                 string User_Name = txt_LUN.Text;
                 string Password = txt_LPassword.Text;

                 string sqlselect = "select count (*) from Users where user_name='" + User_Name + "' and Password= '"+Password+"'";
                SqlDataAdapter sda = new SqlDataAdapter(sqlselect, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                 // MessageBox.Show("Loged in successfully");
                    this.Hide();
                    Multisports_Club ss = new Multisports_Club(txt_LUN.Text);
                    

                    ss.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }

                txt_LPassword_KeyDown(sender, new KeyEventArgs(Keys.Enter));

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up obj = new Sign_Up();
            obj.Show();
        }

        private void txt_LPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
    }
}
