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
    public partial class Schedule : UserControl
    {
        
        public Schedule()
        {
            InitializeComponent();
            
        }
        Conection obj = new Conection();
        private void btn_ScheInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = obj.connect();

                string SRed_ID = txt_SchID.Text;
                

                string insertquery = "insert into Schedule(SReg_ID,in_time,out_time,time_span,date) values('" + SRed_ID + "',convert(datetime,'" + dtp_in.Text + "'),convert(datetime,'" + dtp_out.Text + "'),'" + lbl_TimeSpan.Text + "',convert(datetime,'" + dtp_date.Text + "',101))";

                SqlCommand cmb = new SqlCommand(insertquery, con);
                con.Open();
                cmb.ExecuteNonQuery();
                MessageBox.Show("Successfully Registered ");
                con.Close();

                txt_SchID.Text = "";
                txt_SchIDserch.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_TimeSpan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtp_in_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime startTime = Convert.ToDateTime("7:00");
                DateTime endtime = Convert.ToDateTime("2:00");
                if (dtp_in.Value > dtp_out.Value)
                {
                    TimeSpan duration = DateTime.Parse(dtp_in.Text).Subtract(DateTime.Parse(dtp_out.Text));
                    lbl_TimeSpan.Text = duration.ToString();
                }
                else
                {
                    TimeSpan duration = DateTime.Parse(dtp_out.Text).Subtract(DateTime.Parse(dtp_in.Text));
                    lbl_TimeSpan.Text = duration.ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dtp_out_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                
               DateTime startTime = Convert.ToDateTime("7:00");
                DateTime endtime = Convert.ToDateTime("2:00");
                if(dtp_in.Value>dtp_out.Value)
                {
                    TimeSpan duration = DateTime.Parse(dtp_in.Text).Subtract(DateTime.Parse(dtp_out.Text));
                    lbl_TimeSpan.Text = duration.ToString();
                }
                else
                {
                    TimeSpan duration = DateTime.Parse(dtp_out.Text).Subtract(DateTime.Parse(dtp_in.Text));
                    lbl_TimeSpan.Text = duration.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_SchSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SchIDserch.Text != "")
                {
                    SqlConnection con = obj.connect();
                    string SRegID = txt_SchIDserch.Text;
                    string Select_Query = "select * from Schedule where SReg_ID='" + SRegID + "'or date= convert(datetime, '" + dtp_dateserch.Text + "', 101)";
                    SqlDataAdapter sda = new SqlDataAdapter(Select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_Schedule.DataSource = dt;
                }
                else
                {
                    SqlConnection con = obj.connect();
                    string select_Query = "select * from Schedule";
                    SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv_Schedule.DataSource = dt;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            
            
            try
            {

                SqlConnection con = obj.connect();
                string select_Query = "select * from Schedule";
                SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dgv_Schedule.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgv_Schedule_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                

                if (dgv_Schedule.CurrentRow.Index != -1)
                {

                    txt_SchID.Text= dgv_Schedule.CurrentRow.Cells[1].Value.ToString(); 
                    dtp_date.Text = dgv_Schedule.CurrentRow.Cells[5].Value.ToString();
                    dtp_in.Text = dgv_Schedule.CurrentRow.Cells[2].Value.ToString();
                    dtp_out.Text = dgv_Schedule.CurrentRow.Cells[3].Value.ToString();
                    lbl_TimeSpan.Text= dgv_Schedule.CurrentRow.Cells[4].Value.ToString();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_RUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string SRed_ID = txt_SchID.Text;
                string update_Query = "update Schedule set in_time= convert(datetime,'" + dtp_in.Text + "'),out_time=convert(datetime,'" + dtp_out.Text + "'),time_span='" + lbl_TimeSpan.Text + "',date=convert(datetime,'" + dtp_date.Text + "',101) where SReg_ID = '" + SRed_ID + "'";
                SqlConnection con1 = obj.connect();
                SqlDataAdapter dad = new SqlDataAdapter(update_Query, con1);
                SqlCommand cmd = new SqlCommand(update_Query, con1);
                SqlDataReader rdr;
                con1.Open();
                rdr = cmd.ExecuteReader();
                MessageBox.Show("Data Updated");
                con1.Close();

                txt_SchID.Text = "";
                txt_SchIDserch.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_RDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SchID.Text != "")
                {
                    string SRed_ID = txt_SchID.Text;
                    SqlConnection con1 = obj.connect();

                    string delete_Query = "delete from Schedule where SReg_ID='" + SRed_ID + "' and date=convert(datetime,'" + dtp_date.Text + "',101)";
                    SqlCommand cmd = new SqlCommand(delete_Query, con1);
                    con1.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully");
                    con1.Close();
                }
                else
                {
                    MessageBox.Show("Please insert the Registration ID");
                }
                SqlConnection con = obj.connect();
                string select_Query = "select * from Schedule";
                SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dgv_Schedule.DataSource = dt;

                txt_SchID.Text = "";
                txt_SchIDserch.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
