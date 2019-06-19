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
    public partial class Page_Dashboard : UserControl
    {
        public Page_Dashboard()
        {
            InitializeComponent();
        }
        
        string Package;
        Conection obj = new Conection();
        private void btn_MemberReg_Click(object sender, EventArgs e)
        {

        }

        private void Page_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                dtp_BitthDay.Value = DateTime.Now;
                dtp_Date.Value = DateTime.Now;
                txt_Address.Text = txt_Fee.Text = txt_fname.Text = txt_ID.Text = txt_MonileNo.Text = txt_NIC.Text = "";
                rad_Monthly.Checked = false;
                rad_OneYear.Checked = false;
                rad_sixMonth.Checked = false;
                chk_Badminton.Checked = chk_Biliard.Checked = chk_Gym.Checked = chk_Swimm.Checked = chk_Tennis.Checked = false;
                SqlConnection con = obj.connect();
                string select_Query = "select * from RegMembers";
                SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
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
                    dgv1.DataSource = dt;
                }
                else
                {
                    SqlConnection con = obj.connect();
                    string select_Query = "select * from RegMembers";
                    SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    con.Close();
                    dgv1.DataSource = dt;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (dgv1.CurrentRow.Index != -1)
                {
                    //Code = Convert.ToInt32(dgv1.CurrentRow.Cells[0].Value.ToString());
                    txt_ID.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                    txt_fname.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                    txt_NIC.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                    txt_Address.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                    txt_MonileNo.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                    dtp_BitthDay.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                    dtp_Date.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
                    txt_Fee.Text = dgv1.CurrentRow.Cells[7].Value.ToString();
                    string result = dgv1.CurrentRow.Cells[8].Value.ToString();
                    if (result == "Monthly")
                    {
                        rad_Monthly.Checked = true;
                    }

                    else if (result == "One Year")
                    {
                        rad_OneYear.Checked = true;
                    }

                    else if (result == "Six Month")
                    {
                        rad_sixMonth.Checked = true;
                    }



                    string Events = dgv1.CurrentRow.Cells[9].Value.ToString();
                    chk_Badminton.Checked = false;
                    chk_Biliard.Checked = false;
                    chk_Gym.Checked = false;
                    chk_Swimm.Checked = false;
                    chk_Tennis.Checked = false;



                    string[] words = Events.Split(',');
                    foreach (string word in words)
                    {

                        if (word == "Gym")
                        {
                            chk_Gym.Checked = true;

                        }
                        if (word == "swimming")
                        {
                            chk_Swimm.Checked = true;
                        }
                        if (word == "Tennis")
                        {
                            chk_Tennis.Checked = true;
                        }
                        if (word == "Badminton")
                        {
                            chk_Badminton.Checked = true;
                        }
                        if (word == "Billiard pool")
                        {
                            chk_Biliard.Checked = true;
                        }
                    }

                    //btnSave.Text = "update";
                    //btnDelete.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_RReset_Click(object sender, EventArgs e)
        {
            txt_Address.Text = txt_Fee.Text = txt_fname.Text = txt_ID.Text = txt_MonileNo.Text = txt_NIC.Text = "";
            rad_Monthly.Checked = false;
            rad_OneYear.Checked = false;
            rad_sixMonth.Checked = false;
            chk_Badminton.Checked = chk_Biliard.Checked = chk_Gym.Checked = chk_Swimm.Checked = chk_Tennis.Checked = false;
        }
        Conection obj1 = new Conection();
        private void btn_RUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ID.Text != "" && txt_fname.Text != "" && txt_NIC.Text != "" && txt_Address.Text != "" && txt_MonileNo.Text != "" && txt_Fee.Text != "")
                {
                    string Reg_ID = txt_ID.Text;
                    string Name = txt_fname.Text;
                    string NIC = txt_NIC.Text;
                    string Address = txt_Address.Text;
                    string Mobile = txt_MonileNo.Text;
                    string Reg_Fee = txt_Fee.Text;
                    //string Gym = "", swimming = "", Tennis = "", Badminton = "", Billiard_pool = "";

                    /*if (chk_Gym.Checked == true)
                    {
                        Gym = chk_Gym.Text;
                    }
                    if (chk_Swimm.Checked == true)
                    {
                        swimming = chk_Swimm.Text;
                    }
                    if (chk_Tennis.Checked == true)
                    {
                        Tennis = chk_Tennis.Text;
                    }
                    if (chk_Biliard.Checked == true)
                    {
                        Billiard_pool = chk_Biliard.Text;
                    }
                    if (chk_Badminton.Checked == true)
                    {
                        Badminton = chk_Badminton.Text;
                    }*/

                    StringBuilder name = new StringBuilder();
                    foreach (Control cont in this.grp_RdEvents.Controls)
                    {
                        if (cont is CheckBox)
                        {
                            if (((CheckBox)cont).Checked == true)
                            {
                                name.Append(((CheckBox)cont).Text.ToString() + ",");
                            }
                        }
                    }

                    if (rad_Monthly.Checked)
                    {
                        Package = "Monthly";
                    }
                    if (rad_OneYear.Checked)
                    {
                        Package = "One Year";
                    }
                    if (rad_sixMonth.Checked)
                    {
                        Package = "Six Month";
                    }
                    string update_Query = "update RegMembers set Reg_ID='" + Reg_ID + "',Name='" + Name + "',NIC='" + NIC + "',Address='" + Address + "',Mobile='" + Mobile + "',Birthday=convert(datetime,'" + dtp_BitthDay.Text + "',101),Reg_Date=convert(datetime,'" + dtp_Date.Text + "',101),Reg_Fee='" + Reg_Fee + "',Package='" + Package + "',Events='" + name + "' where Reg_ID = '" + Reg_ID + "'";
                    SqlConnection con1 = obj.connect();
                    SqlDataAdapter dad = new SqlDataAdapter(update_Query, con1);
                    SqlCommand cmd = new SqlCommand(update_Query, con1);
                    SqlDataReader rdr;
                    con1.Open();
                    rdr = cmd.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    con1.Close();
                }

                else
                {
                    MessageBox.Show("You have entered details invalid. please check again.");
                }
                SqlConnection con = obj.connect();
                string select_Query = "select * from RegMembers";
                SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dgv1.DataSource = dt;


                txt_Address.Text = txt_Fee.Text = txt_fname.Text = txt_ID.Text = txt_MonileNo.Text = txt_NIC.Text = "";
                rad_Monthly.Checked = false;
                rad_OneYear.Checked = false;
                rad_sixMonth.Checked = false;
                chk_Badminton.Checked = chk_Biliard.Checked = chk_Gym.Checked = chk_Swimm.Checked = chk_Tennis.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_RDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ID.Text != "")
                {
                    string Reg_ID = txt_ID.Text;
                    SqlConnection con1 = obj.connect();

                    string delete_Query = "delete from RegMembers where Reg_ID='" + Reg_ID + "'";
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
                string select_Query = "select * from RegMembers";
                SqlDataAdapter sda = new SqlDataAdapter(select_Query, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                con.Close();
                dgv1.DataSource = dt;

                txt_Address.Text = txt_Fee.Text = txt_fname.Text = txt_ID.Text = txt_MonileNo.Text = txt_NIC.Text = "";
                rad_Monthly.Checked = false;
                rad_OneYear.Checked = false;
                rad_sixMonth.Checked = false;
                chk_Badminton.Checked = chk_Biliard.Checked = chk_Gym.Checked = chk_Swimm.Checked = chk_Tennis.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Fee_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_Fee.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_MonileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 43 && txt_MonileNo.Text.IndexOf('+') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 43)
            {
                e.Handled = true;
            }
        }

        private void txt_ID_KeyUp(object sender, KeyEventArgs e)
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
                dgv1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
