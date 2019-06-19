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
    public partial class DatabaseAll : UserControl
    {
        public DatabaseAll()
        {
            InitializeComponent();
        }
        Conection obj = new Conection();

        private void DatabaseAll_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = obj.connect();
                string select_Query = "select * from RegMembers";
                SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dgv_Redmem.DataSource = dt;


                
                string select_QueryOne = "select * from OneDay_Cus";
                SqlDataAdapter sda1 = new SqlDataAdapter(select_QueryOne, con);
                DataTable dt1 = new DataTable();
                con.Open();
                sda1.Fill(dt1);
                con.Close();
                dgv_OneDCus.DataSource = dt1;


                
                string select1_Query = "select * from PriceList";
                SqlDataAdapter sda2 = new SqlDataAdapter(select1_Query, con);
                DataTable dt2 = new DataTable();
                con.Open();
                sda2.Fill(dt2);
                con.Close();
                dgv_PriceL.DataSource = dt2;



            }


        
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txt_ID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txt_ID.Text != "")
                {
                    SqlConnection con = obj.connect();
                    string RID = txt_ID.Text;
                    string Select_Query = "select * from RegMembers where Reg_ID='" + RID + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(Select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_Redmem.DataSource = dt;
                }
                else if (txt_ID.Text == "")
                {
                    SqlConnection con = obj.connect();
                    string select_Query = "select * from RegMembers";
                    SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_Redmem.DataSource = dt;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_NIC_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txt_NIC.Text != "")
                {
                    SqlConnection con = obj.connect();
                    string OneNIC = txt_NIC.Text;
                    string Select_Query = "select * from OneDay_Cus where NIC='" + OneNIC + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(Select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_OneDCus.DataSource = dt;
                }
                else if (txt_ID.Text == "")
                {
                    SqlConnection con = obj.connect();
                    string select_Query = "select * from OneDay_Cus";
                    SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_OneDCus.DataSource = dt;
                }

                




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_price_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txt_price.Text != "")
                {
                    SqlConnection con = obj.connect();
                    string evqty = txt_price.Text;
                    string Select_Query = "select * from PriceList where event_qty='" + evqty + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(Select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_PriceL.DataSource = dt;
                }
                else if (txt_price.Text == "")
                {
                    SqlConnection con = obj.connect();
                    string select_Query = "select * from PriceList";
                    SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_PriceL.DataSource = dt;
                }






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
