using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Multisports
{
    public partial class Multisports_Club : Form
    {
        string name;
        public Multisports_Club(string User_Name)
        {
            InitializeComponent();
            name = User_Name;

        }
        Conection obj = new Conection();

        
        private void Multisports_Club_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = obj.connect();
                SqlCommand cmd;
                string sql = "select count(Reg_ID) from RegMembers";

                con.Open();
                cmd = new SqlCommand(sql, con);
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();
                lbl_count.Text = rows_count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //timer1.Start();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000; //Is
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            
            lbl_User.Text = name;
            uNew_Member_Registration1.Visible = false;
            one_Day_Customer1.Visible = false;
            page_Dashboard1.Visible = false;
            databaseAll1.Visible = false;
            schedule1.Visible = false;
            priceList1.Visible = false;
            test1.Visible = false;
            pnl_About.Visible = false;

            if (lbl_User.Text == "admin")
            {
                btn_Database.Enabled = true;
            }
            else
            {
                btn_Database.Enabled = false;
            }
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lblStatus.Text = DateTime.Now.ToString("T");
            }));
        }


        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();
        private void Toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void Toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void Toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            try
            {
                //panel3.Visible = false;
                
                this.WindowState = FormWindowState.Minimized;
                
            }
            catch(Exception)
            {

            }
           

            
            
            
        }
        

        private void btn_Collapse_Click(object sender, EventArgs e)
        {
            if(pnl_sideMenu.Width>= 238)
            {
                pic_Logo.Location = new Point(5,-25);
                pic_Logo.Size = new Size(50, 185);
                pnl_sideMenu.Width = 58;
            }
            else
            {
                pic_Logo.Location = new Point(56,-25);
                pic_Logo.Size = new Size(128, 209);
                pnl_sideMenu.Width = 238;
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            PanelDashB.Visible = true;
            uNew_Member_Registration1.Visible = false;
            one_Day_Customer1.Visible = false;
            page_Dashboard1.Visible = false;
            databaseAll1.Visible = false;
            schedule1.Visible = false;
            priceList1.Visible = false;
            test1.Visible = false;
            pnl_About.Visible = false;
            

        }

        private void btn_MemberReg_Click(object sender, EventArgs e)
        {
            uNew_Member_Registration1.Visible = true;
            uNew_Member_Registration1.BringToFront();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        private void btn_Onedaycus_Click(object sender, EventArgs e)
        {
            one_Day_Customer1.Visible = true;
            one_Day_Customer1.BringToFront();
        }

        private void btn_Regedmember_Click(object sender, EventArgs e)
        {
            page_Dashboard1.Visible = true;
            page_Dashboard1.BringToFront();
        }

        private void btn_Database_Click(object sender, EventArgs e)
        {
            databaseAll1.BringToFront();
            databaseAll1.Visible = true;
            PanelDashB.Visible = true;
            uNew_Member_Registration1.Visible = false;
            one_Day_Customer1.Visible = false;
            page_Dashboard1.Visible = false;
            schedule1.Visible = false;
            priceList1.Visible = false;
            test1.Visible = false;
            pnl_About.Visible = false;
            



        }

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            schedule1.BringToFront();
            schedule1.Visible = true;
            databaseAll1.Visible = false;
            test1.Visible = false;
            PanelDashB.Visible = true;
            uNew_Member_Registration1.Visible = false;
            one_Day_Customer1.Visible = false;
            page_Dashboard1.Visible = false;
            priceList1.Visible = false;
            pnl_About.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            priceList1.BringToFront();
            priceList1.Visible = true;
            test1.Visible = false;
            schedule1.Visible = false;
            databaseAll1.Visible = false;
            PanelDashB.Visible = true;
            uNew_Member_Registration1.Visible = false;
            one_Day_Customer1.Visible = false;
            page_Dashboard1.Visible = false;
            pnl_About.Visible = false;
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            test1.BringToFront();
            test1.Visible = true;
            priceList1.Visible = false;
            schedule1.Visible = false;
            databaseAll1.Visible = false;
            PanelDashB.Visible = true;
            uNew_Member_Registration1.Visible = false;
            one_Day_Customer1.Visible = false;
            page_Dashboard1.Visible = false;
            pnl_About.Visible = false;
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            pnl_About.BringToFront();
            pnl_About.Visible = true;
            test1.Visible = false;
            priceList1.Visible = false;
            schedule1.Visible = false;
            databaseAll1.Visible = false;
            PanelDashB.Visible = true;
            uNew_Member_Registration1.Visible = false;
            one_Day_Customer1.Visible = false;
            page_Dashboard1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString("T");
        }
    }
}
