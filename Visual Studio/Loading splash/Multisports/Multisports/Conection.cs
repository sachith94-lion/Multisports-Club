using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Multisports
{
    class Conection
    {
        SqlConnection con = null;
        public SqlConnection connect()
        {
            con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sachith\\Desktop\\C# Assignment project\\Database files\\MultisportsClub.mdf;Integrated Security = True; Connect Timeout = 30");
            return con;
        }
    }
}
