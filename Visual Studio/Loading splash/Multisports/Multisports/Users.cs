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
    public partial class Users : UserControl
    {
        //string LName;
        public Users(/*string userN*/)
        {
            InitializeComponent();
            //LName = userN;
        }
        Conection obj = new Conection();
        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
               /* LName = lbl_LogUN.Text;
                SqlConnection con = obj.connect();
                //string UName = txt_BPID.Text;
                string Select_Query = "select * from Users where User_Name='" + LName + "'";
                SqlCommand cmd = new SqlCommand(Select_Query, con);
                SqlDataReader rdr;
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    lbl_LogUN.Text = rdr.GetString(0);
                    lbl_LEmali.Text = rdr.GetString(2);
                }*/
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
