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
    public partial class One_Day_Customer : UserControl
    {
        public One_Day_Customer()
        {
            InitializeComponent();
        }

        Conection obj = new Conection();
        private void Btn_PrintBill_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txt_OnedAddress.Text != "" && txt_Onedfname.Text != "" && txt_OnedMonileNo.Text != "" && txt_OnedNIC.Text != "")
                {
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();

                    string OnedName = txt_Onedfname.Text;
                    string OnedNIC = txt_OnedNIC.Text;
                    string OnedAddress = txt_OnedAddress.Text;
                    string OnedMobile = txt_OnedMonileNo.Text;




                    StringBuilder name = new StringBuilder();
                    foreach (Control cont in this.grp_OnedEvents.Controls)
                    {
                        if (cont is CheckBox)
                        {
                            if (((CheckBox)cont).Checked == true)
                            {
                                name.Append(((CheckBox)cont).Text.ToString() + ",");
                            }
                        }
                    }

                    SqlConnection con = obj.connect();

                    string insertquery = "insert into OneDay_Cus(Name,NIC,Address,Mobile,Events) values('" + OnedName + "','" + OnedNIC + "','" + OnedAddress + "','" + OnedMobile + "','" + name.ToString().Trim() + "')";

                    SqlCommand cmb = new SqlCommand(insertquery, con);
                    con.Open();
                    cmb.ExecuteNonQuery();
                    MessageBox.Show("Inserted Successfully");
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Please complete the form");
                }

                txt_OnedAddress.Text = "";
                txt_Onedfname.Text = "";
                txt_OnedMonileNo.Text = "";
                txt_OnedNIC.Text = "";
                txt_OneCharge.Text = "";

                chk_OnedBadminton.Checked = false;
                chk_OnedBiliard.Checked = false;
                chk_OnedGym.Checked = false;
                chk_OnedSwimm.Checked = false;
                chk_OnedTennis.Checked = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_OnedMonileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 43 && txt_OnedMonileNo.Text.IndexOf('+') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 43)
            {
                e.Handled = true;
            }
        }

        private void dtp_EndT_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime startTime = Convert.ToDateTime("7:00");
                DateTime endtime = Convert.ToDateTime("2:00");
                if (dtp_StartT.Value > dtp_EndT.Value)
                {
                    TimeSpan duration = DateTime.Parse(dtp_StartT.Text).Subtract(DateTime.Parse(dtp_EndT.Text));
                    lbl_Hours.Text = duration.ToString();
                }
                else
                {
                    TimeSpan duration = DateTime.Parse(dtp_EndT.Text).Subtract(DateTime.Parse(dtp_StartT.Text));
                    lbl_Hours.Text = duration.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtp_StartT_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime startTime = Convert.ToDateTime("7:00");
                DateTime endtime = Convert.ToDateTime("2:00");
                if (dtp_StartT.Value > dtp_EndT.Value)
                {
                    TimeSpan duration = DateTime.Parse(dtp_StartT.Text).Subtract(DateTime.Parse(dtp_EndT.Text));
                    lbl_Hours.Text = duration.ToString();
                }
                else
                {
                    TimeSpan duration = DateTime.Parse(dtp_EndT.Text).Subtract(DateTime.Parse(dtp_StartT.Text));
                    lbl_Hours.Text = duration.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                
                
                    string Bt = null;
                    string BilPo = null;
                    string Gym = null;
                    string Swim = null;
                    string Ten = null;


                    string price = Convert.ToDouble(txt_OneCharge.Text).ToString("0.00");

                    if (chk_OnedBadminton.Checked == true)
                    {
                        Bt = "Badminton";
                    }

                    if (chk_OnedBiliard.Checked == true)
                    {
                        BilPo = "Billiard pool";
                    }

                    if (chk_OnedGym.Checked == true)
                    {
                        Gym = "Gym";
                    }

                    if (chk_OnedSwimm.Checked == true)
                    {
                        Swim = "swimming";
                    }

                    if (chk_OnedTennis.Checked == true)
                    {
                        Ten = "Tennis";
                    }

                    e.Graphics.DrawString("WELCOME", new Font("Fake Receipt", 17, FontStyle.Regular), Brushes.Black, new PointF(330, 50));
                    e.Graphics.DrawString("Multisports Club", new Font("Fake Receipt", 25, FontStyle.Bold), Brushes.Black, new PointF(215, 89));
                    e.Graphics.DrawString("No.120,Kandy Road,Mawathagama,Kurunegala", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(130, 149));
                    e.Graphics.DrawString("0771234567,0371234567", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(260, 170));
                    e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 200));

                    e.Graphics.DrawString("customer detail", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 250));
                    e.Graphics.DrawString("Full Name: " + txt_Onedfname.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 289));
                    e.Graphics.DrawString("NIC Number: " + txt_OnedNIC.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 328));
                    e.Graphics.DrawString("Address: " + txt_OnedAddress.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 367));
                    e.Graphics.DrawString("Mobile No: " + txt_OnedMonileNo.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 406));
                    e.Graphics.DrawString("", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 445));
                    e.Graphics.DrawString("Events", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 484));
                    e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 523));

                    e.Graphics.DrawString(Bt + "\n" + BilPo + "\n" + Gym + "\n" + Swim + "\n" + Ten, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 601));



                    e.Graphics.DrawString("", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 640));
                    e.Graphics.DrawString("", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 679));
                    e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 718));
                    e.Graphics.DrawString("Price Rs: " + price, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 757));
                    e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 796));
                    e.Graphics.DrawString("Time", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 835));

                    e.Graphics.DrawString("Start: " + dtp_StartT.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 874));
                    e.Graphics.DrawString("End: " + dtp_EndT.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 913));
                    e.Graphics.DrawString("Hours: " + lbl_Hours.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 952));

                    e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 991));

                    e.Graphics.DrawString("Thank you.", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(330, 1030));
                    e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 1069));
                    e.Graphics.DrawString("System By Sinhalion Tel:0777978688", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(210, 1108));
                

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txt_OneCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_OneCharge.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
