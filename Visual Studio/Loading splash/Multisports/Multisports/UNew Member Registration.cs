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
using System.Drawing.Printing;



namespace Multisports
{
    public partial class UNew_Member_Registration : UserControl
    {
        public UNew_Member_Registration()
        {
            InitializeComponent();
        }
        Conection obj = new Conection();
        
        
        string Package;
        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_regID.Text != "" && txt_regfname.Text != "" && txt_regNIC.Text != "" && txt_regAddress.Text != "" && txt_regMonileNo.Text != "" && txt_regFee.Text != "")
                {
                    string Reg_ID = txt_regID.Text;
                    string Name = txt_regfname.Text;
                    string NIC = txt_regNIC.Text;
                    string Address = txt_regAddress.Text;
                    string Mobile = txt_regMonileNo.Text;
                    string Reg_Fee = txt_regFee.Text;

                    StringBuilder name = new StringBuilder();
                    foreach (Control cont in this.grp_Enents.Controls)
                    {
                        if (cont is CheckBox)
                        {
                            if (((CheckBox)cont).Checked == true)
                            {
                                name.Append(((CheckBox)cont).Text.ToString() + ",");
                            }
                        }
                    }

                    if (rad_regMonthly.Checked)
                    {
                        Package = "Monthly";
                    }
                    if (rad_regOneYear.Checked)
                    {
                        Package = "One Year";
                    }
                    if (rad_regsixMonth.Checked)
                    {
                        Package = "Six Month";
                    }

                    SqlConnection con = obj.connect();

                    string insertquery = "insert into RegMembers(Reg_ID,Name,NIC,Address,Mobile,Birthday,Reg_Date,Reg_Fee,Package,Events) values('" + Reg_ID + "','" + Name + "','" + NIC + "','" + Address + "','" + Mobile + "',convert(datetime,'" + dtp_regBitthDay.Text + "',101),convert(datetime,'" + dtp_regDate.Text + "',101),'" + Reg_Fee + "','" + Package + "','" + name + "')";

                    SqlCommand cmb = new SqlCommand(insertquery, con);
                    con.Open();
                    cmb.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered ");
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Please complete the form");
                }

                txt_regAddress.Text = "";
                txt_regFee.Text = "";
                txt_regfname.Text = "";
                txt_regID.Text = "";
                txt_regMonileNo.Text = "";
                txt_regNIC.Text = "";

                rad_regMonthly.Checked = false;
                rad_regOneYear.Checked = false;
                rad_regsixMonth.Checked = false;
                chk_regBadminton.Checked = false;
                chk_regBiliard.Checked = false;
                chk_regGym.Checked = false;
                chk_regSwimm.Checked = false;
                chk_regTennis.Checked = false;
                EPC_regid.Clear();
                EPW_regid.Clear();
                EPC_regfee.Clear();
                EPW_regfee.Clear();
                EPC_mobile.Clear();
                EPW_mobile.Clear();
                EPC_address.Clear();
                EPW_Address.Clear();
                EP_niccorrect.Clear();
                EP_nicworng.Clear();
                NameEPcorrect.Clear();
                NameEPwrong.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_regFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_regFee.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_regMonileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 43 && txt_regMonileNo.Text.IndexOf('+') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 43)
            {
                e.Handled = true;
            }
        }

        private void UNew_Member_Registration_Load(object sender, EventArgs e)
        {
            pnl_mem_reg.BringToFront();
            pnl_mem_reg.Visible = true;
            pnl_PrintBill.Visible = true;
            pnl_Mmcard.Visible = false;
            dtp_regDate.MinDate = DateTime.Today;
            dtp_regBitthDay.Value = DateTime.Now;



        }

        private void Btn_PrintBill_Click(object sender, EventArgs e)
        {
            EPC_regid.Clear();
            EPW_regid.Clear();
            EPC_regfee.Clear();
            EPW_regfee.Clear();
            EPC_mobile.Clear();
            EPW_mobile.Clear();
            EPC_address.Clear();
            EPW_Address.Clear();
            EP_niccorrect.Clear();
            EP_nicworng.Clear();
            NameEPcorrect.Clear();
            NameEPwrong.Clear();
            pnl_mem_reg.Hide();
            pnl_Mmcard.Hide();
            pnl_PrintBill.Show();





        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            txt_BPEventqty.Text = "";
            txt_BPEvents.Text = "";
            txt_BPID.Text = "";
            txt_BPPrice.Text = "";
            txt_BPRegFee.Text = "";
            txt_BPtotal.Text = "";
            txt_BPChange.Text = "";
            txt_BPCash.Text = "";
            rad_BPMonthly.Checked = false;
            rad_BPOneYear.Checked = false;
            rad_BPsixMonth.Checked = false;

            pnl_mem_reg.Show();

        }

        private void txt_BPID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txt_BPID.Text != "")
                {

                    SqlConnection con = obj.connect();
                    string RegID = txt_BPID.Text;
                    string Select_Query = "select * from RegMembers where Reg_ID='" + RegID + "'";
                    SqlCommand cmd = new SqlCommand(Select_Query, con);
                    SqlDataReader rdr;
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        
                        
                        txt_BPRegFee.Text = rdr.GetString(7);
                        txt_BPEvents.Text = rdr.GetString(9);
                        string Package = rdr.GetString(8);

                        if (Package == "Monthly")
                        {
                            rad_BPMonthly.Checked = true;
                        }
                        if (Package == "One Year")
                        {
                            rad_BPOneYear.Checked = true;
                        }
                        if (Package == "Six Month")
                        {
                            rad_BPsixMonth.Checked = true;
                        }

                        string Events = rdr.GetString(9);
                        string whole_text = txt_BPEvents.Text;
                        string trimmed_text = whole_text.Trim();
                        string[] split_text = trimmed_text.Split(',');
                        int space_count = 0;
                        string new_text = "";

                        foreach (string av in split_text)
                        {
                            if (av == "")
                            {
                                space_count++;
                            }
                            else
                            {
                                new_text = new_text + av + ",";
                            }
                        }

                        new_text = new_text.TrimEnd(',');
                        split_text = new_text.Split(',');
                        txt_BPEventqty.Text = (split_text.Length.ToString());



                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_BPEventqty_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_BPEventqty_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_BPID.Text != "")
                {

                    SqlConnection con = obj.connect();
                    string eventqty = txt_BPEventqty.Text;
                    string regfe = txt_BPRegFee.Text;
                    string Select_Query = "select * from PriceList where event_qty='" + eventqty + "'";
                    SqlCommand cmd = new SqlCommand(Select_Query, con);
                    SqlDataReader rdr;
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {

                        txt_BPPrice.Text = rdr.GetValue(3).ToString();


                        txt_BPtotal.Text = (Convert.ToDouble(txt_BPPrice.Text) + Convert.ToDouble(txt_BPRegFee.Text)).ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_PrintRec_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_BPCash.Text!="" && txt_BPChange.Text!="" && txt_BPEventqty.Text!="" && txt_BPEvents.Text!="" && txt_BPID.Text!="" && txt_BPPrice.Text!=""&& txt_BPtotal.Text!="")
                {
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();
                }
                else
                {
                    MessageBox.Show("Please fill the form correctly");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string results=null;
           
            string cash=Convert.ToDouble(txt_BPCash.Text).ToString("0.00");
            string Totpay = Convert.ToDouble(txt_BPtotal.Text).ToString("0.00");
            string price = Convert.ToDouble(txt_BPPrice.Text).ToString("0.00");

            if (rad_BPMonthly.Checked)
            {
                results = "Monthly";
            }

            if(rad_BPOneYear.Checked)
            {
                results = "One Year";
            }

            if(rad_BPsixMonth.Checked)
            {
                results = "Six Month";
            }
            e.Graphics.DrawString("WELCOME", new Font("Fake Receipt", 17, FontStyle.Regular), Brushes.Black, new PointF(330, 50));
            e.Graphics.DrawString("Multisports Club", new Font("Fake Receipt", 25, FontStyle.Bold), Brushes.Black, new PointF(215, 89));
            e.Graphics.DrawString("No.120,Kandy Road,Mawathagama,Kurunegala", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(130, 149));
            e.Graphics.DrawString("0771234567,0371234567", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(260, 170));
            e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 200));


            e.Graphics.DrawString("Registration ID ------------------------------"+ txt_BPID.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 250));
            e.Graphics.DrawString("Package --------------------------------------" + results, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 289));
            e.Graphics.DrawString("" , new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 328));
            e.Graphics.DrawString("Events\t\t\t\t\t\t\tPrice(RS)", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 367));
            e.Graphics.DrawString("-------------------------------------------------------" , new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 406));
            e.Graphics.DrawString(txt_BPEvents.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 445));
            e.Graphics.DrawString("\t\t\t\t\t\t\t\t" + price, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 445));

            e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 523));
            e.Graphics.DrawString("", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 562));

            e.Graphics.DrawString("Registration Fee\t\t\t\t\t\t" + txt_BPRegFee.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 601));
            e.Graphics.DrawString("", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 640));
            e.Graphics.DrawString("Total to pay\t\t\t\t\t\t" + Totpay, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 679));
            e.Graphics.DrawString("", new Font("Fake Receipt", 14, FontStyle.Bold), Brushes.Black, new PointF(39, 718));
            e.Graphics.DrawString("Cash\t\t\t\t\t\t\t\t" + cash, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 757));

            e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 796));
            e.Graphics.DrawString("Change\t\t\t\t\t\t\t" + txt_BPChange.Text, new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 835));
            
            e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 874));
            
            e.Graphics.DrawString("Thank you.", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(330, 913));
            e.Graphics.DrawString("-------------------------------------------------------", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(39, 952));
            e.Graphics.DrawString("System By Sinhalion Tel:0777978688", new Font("Fake Receipt", 14, FontStyle.Regular), Brushes.Black, new PointF(210, 991));




        }

        private void txt_BPCash_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_BPCash.Text) > Convert.ToDouble(txt_BPtotal.Text))
                {
                    txt_BPChange.Text = (Convert.ToDouble(txt_BPCash.Text) - Convert.ToDouble(txt_BPtotal.Text)).ToString("0.00");
                }
                else if(Convert.ToDouble(txt_BPCash.Text) == Convert.ToDouble(txt_BPtotal.Text))
                {
                    txt_BPChange.Text = txt_BPtotal.Text;
                }
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btn_CPPrint_Click(object sender, EventArgs e)
        {
            if(txt_CPregid.Text!="")
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += Doc_PrintPage;
                pd.Document = doc;
                if (pd.ShowDialog() == DialogResult.OK)
                    doc.Print();
            }

            else
            {
                MessageBox.Show("Please enter Registration ID");
            }

            

        }


        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            /*string name = txt_CPName.Text;
            int space1 = name.IndexOf(' ');

            int space2 = name.IndexOf(' ', space1 + 1);

            int space3 = name.IndexOf(' ', space2 + 1);

            int space4 = name.IndexOf(' ', space3 + 1); 

            string firstPart = name.Substring(0, space2);

            firstPart = name.Substring(0, name.IndexOf(' ', name.IndexOf(' ') + 1));


            

            string secondpart = name.Substring(0, space4);


            secondpart = name.Substring(0, name.IndexOf(' ',name.IndexOf(' ')+1));*/

            








            Bitmap bm = new Bitmap(pic_ID.Width, pic_ID.Height);
            pic_ID.DrawToBitmap(bm, new Rectangle(0, 0, pic_ID.Width, pic_ID.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
            e.Graphics.DrawString(lbl_CPID.Text, new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new PointF(350, 83));
            e.Graphics.DrawString(txt_CPName.Text+("\n"), new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new PointF(227, 134));
            
            e.Graphics.DrawString(txt_CPADDRESS.Text, new Font("Fake Receipt", 9, FontStyle.Regular), Brushes.Black, new PointF(227, 203));
        }


        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                /*Bitmap bm = new Bitmap(pic_ID.Width, pic_ID.Height);
                pic_ID.DrawToBitmap(bm, new Rectangle(0, 0, pic_ID.Width, pic_ID.Height));
                e.Graphics.DrawImage(bm, 0, 0);
                bm.Dispose();
                e.Graphics.DrawString("WELCOME", new Font("Fake Receipt", 17, FontStyle.Regular), Brushes.Black, new PointF(330, 50));*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txt_CPregid_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txt_CPregid.Text != "")
                {

                    SqlConnection con = obj.connect();
                    string RegID = txt_CPregid.Text;
                    string Select_Query = "select * from RegMembers where Reg_ID='" + RegID + "'";
                    SqlCommand cmd = new SqlCommand(Select_Query, con);
                    SqlDataReader rdr;
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        lbl_CPID.Text= rdr.GetString(0);
                        txt_CPName.Text= rdr.GetString(1);
                        txt_CPADDRESS.Text=rdr.GetString(3);                      
                    }
                    con.Close();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_IDPrint_Click(object sender, EventArgs e)
        {
            EPC_regid.Clear();
            EPW_regid.Clear();
            EPC_regfee.Clear();
            EPW_regfee.Clear();
            EPC_mobile.Clear();
            EPW_mobile.Clear();
            EPC_address.Clear();
            EPW_Address.Clear();
            EP_niccorrect.Clear();
            EP_nicworng.Clear();
            NameEPcorrect.Clear();
            NameEPwrong.Clear();
            pnl_Mmcard.BringToFront();
            
            pnl_Mmcard.Show();
            
        }

        private void btn_PCBack_Click(object sender, EventArgs e)
        {
            txt_CPregid.Text = "";
            txt_CPADDRESS.Text = "";
            lbl_CPID.Text = "";
            txt_CPName.Text = "";

            pnl_mem_reg.Show();
            pnl_Mmcard.Hide();
        }

        private void txt_regfname_Leave(object sender, EventArgs e)
        {
            if(txt_regfname.Text!="")
            {
                NameEPcorrect.SetError(txt_regfname, "correct");
                NameEPwrong.Clear();
            }
            else if(txt_regfname.Text == "")
            {
                NameEPwrong.SetError(txt_regfname, "Cannot keep Name blank");
                NameEPcorrect.Clear();
            }
        
        }

        private void txt_regNIC_Leave(object sender, EventArgs e)
        {
            if (txt_regNIC.Text != "")
            {
                EP_niccorrect.SetError(txt_regNIC, "correct");
                EP_nicworng.Clear();
            }
            else if (txt_regNIC.Text == "")
            {
                EP_nicworng.SetError(txt_regNIC, "Cannot keep NIC blank");
                EP_niccorrect.Clear();
            }
        }

        private void txt_regAddress_Leave(object sender, EventArgs e)
        {
            if (txt_regAddress.Text != "")
            {
                EPC_address.SetError(txt_regAddress, "correct");
                EPW_Address.Clear();
            }
            else if (txt_regAddress.Text == "")
            {
                EPW_Address.SetError(txt_regAddress, "Cannot keep Address blank");
                EPC_address.Clear();
            }
        }

        private void txt_regMonileNo_Leave(object sender, EventArgs e)
        {
            if (txt_regMonileNo.Text != "")
            {
                EPC_mobile.SetError(txt_regMonileNo, "correct");
                EPW_mobile.Clear();
            }
            else if (txt_regMonileNo.Text == "")
            {
                EPW_mobile.SetError(txt_regMonileNo, "Cannot keep mobile no blank");
                EPC_mobile.Clear();
            }
        }

        private void txt_regFee_Leave(object sender, EventArgs e)
        {
            if (txt_regFee.Text != "")
            {
                EPC_regfee.SetError(txt_regFee, "correct");
                EPW_regfee.Clear();
            }
            else if (txt_regFee.Text == "")
            {
                EPW_regfee.SetError(txt_regFee, "Cannot keep registration Fee blank");
                EPC_regfee.Clear();
            }
        }

        private void txt_regID_Leave(object sender, EventArgs e)
        {
            if (txt_regID.Text != "")
            {
                EPC_regid.SetError(txt_regID, "correct");
                EPW_regid.Clear();
            }
            else if (txt_regID.Text == "")
            {
                EPW_regid.SetError(txt_regID, "Cannot keep registration ID blank");
                EPC_regid.Clear();
            }
        }

        private void txt_BPCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_BPCash.Text.IndexOf('.') != -1)
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

