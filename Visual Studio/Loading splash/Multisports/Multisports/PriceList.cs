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
    public partial class PriceList : UserControl
    {
        public PriceList()
        {
            InitializeComponent();
        }
        Conection obj = new Conection();
        string Package;
        private void btn_priceSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Eventqty.Text != "" && txt_Price.Text != "" && rad_PMonthly.Checked == true || rad_POneYear.Checked == true || rad_PsixMonth.Checked == true)
                {
                    string Eventsqty = txt_Eventqty.Text;
                    string Price = txt_Price.Text;

                    if (rad_PMonthly.Checked)
                    {
                        Package = "Monthly";
                    }
                    if (rad_POneYear.Checked)
                    {
                        Package = "One Year";
                    }
                    if (rad_PsixMonth.Checked)
                    {
                        Package = "Six Month";
                    }

                    SqlConnection con = obj.connect();

                    string insertquery = "insert into PriceList(package,event_qty,price) values('" + Package + "','" + Eventsqty + "','" + Price + "')";

                    SqlCommand cmb = new SqlCommand(insertquery, con);
                    con.Open();
                    cmb.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved ");
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Please complete the form");
                }

                txt_Eventqty.Text = "";
                txt_Price.Text = "";
                rad_PsixMonth.Checked = false;
                rad_POneYear.Checked = false;
                rad_PMonthly.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pricepdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Eventqty.Text != "" && txt_Price.Text != "" && rad_PMonthly.Checked == true || rad_POneYear.Checked == true || rad_PsixMonth.Checked == true)
                {
                    string Eventsqty = txt_Eventqty.Text;
                    string Price = txt_Price.Text;

                    if (rad_PMonthly.Checked)
                    {
                        Package = "Monthly";
                    }
                    if (rad_POneYear.Checked)
                    {
                        Package = "One Year";
                    }
                    if (rad_PsixMonth.Checked)
                    {
                        Package = "Six Month";
                    }

                    string update_Query = "update PriceList set price='" + Price + "',package='" + Package + "' where event_qty = '" + Eventsqty + "'";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
