using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Multisports
{
    public partial class test : UserControl
    {
        
        public test()
        {
            InitializeComponent();
            
        }
        Conection obj = new Conection();
        private void test_Load(object sender, EventArgs e)
        {
            try
            {
                
                lbl_LogUN.Text = Login.SetValueForUsername;
                string name = lbl_LogUN.Text;
                SqlConnection con = obj.connect();
              
                 string Select_Query = "select * from Users where User_Name='" + name + "'";
                 SqlCommand cmd = new SqlCommand(Select_Query, con);
                 SqlDataReader rdr;
                 con.Open();
                 rdr = cmd.ExecuteReader();
                 if (rdr.Read())
                 {
                     //lbl_LogUN.Text = rdr.GetString(0);
                     lbl_LEmali.Text = rdr.GetString(2);
                 }
                con.Close();

                if (lbl_LogUN.Text == "admin")
                {
                    pic_Admin.Visible = true;
                    grb_CreateA.Visible = true;

                }

                
                else
                {
                    pic_Admin.Visible = false;
                    grb_CreateA.Visible = false;

                }

                string select_Queryuser = "select * from Users";
                SqlDataAdapter sda2 = new SqlDataAdapter(select_Queryuser, con);
                DataTable dt2 = new DataTable();
                con.Open();
                sda2.Fill(dt2);
                con.Close();
                dgv_Users.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_UserN_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txt_UserN.Text != "")
                {
                    SqlConnection con = obj.connect();
                    string Uname = txt_UserN.Text;
                    string Select_Query = "select * from Users where User_Name='" + Uname + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(Select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_Users.DataSource = dt;
                }
                else if (txt_UserN.Text == "")
                {
                    SqlConnection con = obj.connect();
                    string select_Query = "select * from Users";
                    SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_Users.DataSource = dt;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Users_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(dgv_Users.CurrentRow.Index!=-1)
                {
                    txt_UUsername.Text = dgv_Users.CurrentRow.Cells[0].Value.ToString();
                    txt_UPassword.Text = dgv_Users.CurrentRow.Cells[1].Value.ToString();
                    txt_URePassword.Text= dgv_Users.CurrentRow.Cells[1].Value.ToString();
                    txt_UEmail.Text = dgv_Users.CurrentRow.Cells[2].Value.ToString();
                    txt_UserN.Text= dgv_Users.CurrentRow.Cells[0].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_UserN.Text == "admin")
                {
                    MessageBox.Show("cannot update username in admin ");
                }
                else if(txt_UUsername.Text!="" && txt_UEmail.Text!="" && txt_UPassword.Text!="" && txt_URePassword.Text!="" && txt_UPassword.Text==txt_URePassword.Text)
                {
                    string UName = txt_UUsername.Text;
                    string UEmail = txt_UEmail.Text;
                    string UPaassword = txt_UPassword.Text;
                    string UREPassword = txt_URePassword.Text;

                    
                    string update_Query = "update Users set Password='" + UPaassword + "',Email='" + UEmail + "' where User_Name = '" + UName + "'";
                    SqlConnection con1 = obj.connect();
                    SqlDataAdapter dad = new SqlDataAdapter(update_Query, con1);
                    SqlCommand cmd = new SqlCommand(update_Query, con1);
                    SqlDataReader rdr;
                    con1.Open();
                    rdr = cmd.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    con1.Close();
                }
                else if(txt_UPassword.Text != txt_URePassword.Text)
                {
                    MessageBox.Show("Re-Enter password is not matching");
                }

                
                else
                {
                    MessageBox.Show("please select account details in the table");
                }

                SqlConnection con = obj.connect();
                string select_Query = "select * from Users";
                SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dgv_Users.DataSource = dt;

                txt_UEmail.Text = "";
                txt_UPassword.Text = "";
                txt_URePassword.Text = "";
                txt_UserN.Text = "";
                txt_UUsername.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_UserN.Text == "admin")
                {
                    MessageBox.Show("cannot delete admin account");
                }
                else if (txt_UserN.Text != "")
                {
                    string username = txt_UserN.Text;
                    SqlConnection con1 = obj.connect();

                    string delete_Query = "delete from Users where User_Name='" + username + "'";
                    SqlCommand cmd = new SqlCommand(delete_Query, con1);
                    con1.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully");
                    con1.Close();
                }
                else
                {
                    MessageBox.Show("Please enter user name");
                }

                SqlConnection con = obj.connect();
                string select_Query = "select * from Users";
                SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dgv_Users.DataSource = dt;

                txt_UEmail.Text = "";
                txt_UPassword.Text = "";
                txt_URePassword.Text = "";
                txt_UserN.Text = "";
                txt_UUsername.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string User_Name = txt_UUsername.Text;
                string Password = txt_URePassword.Text;
                string Email = txt_UEmail.Text;
                string Password1 = txt_UPassword.Text;

                if (User_Name != "" && Password != "" && Password1 != "" && Email != "" && Password== Password1)
                {
                    SqlConnection con1 = obj.connect();
                    con1.Open();
                    string sqlinsert = "insert into Users values('" + User_Name + "','" + Password + "','" + Email + "')";
                    SqlCommand cmb = new SqlCommand(sqlinsert, con1);
                    cmb.ExecuteNonQuery();
                    MessageBox.Show("Account created");
                    con1.Close();
                    
                }

                else if(Password != Password1)
                {
                    MessageBox.Show("Re-Enter password is not matching");
                }

                else
                {
                    MessageBox.Show("Please complete sign up form");
                }

                txt_UEmail.Text = "";
                txt_UPassword.Text = "";
                txt_URePassword.Text = "";
                txt_UserN.Text = "";
                txt_UUsername.Text = "";

                SqlConnection con = obj.connect();
                string select_Query = "select * from Users";
                SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dgv_Users.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
