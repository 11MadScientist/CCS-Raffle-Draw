using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCS_Raffle_Draw.connection
{

    class connection
    {
        public static SqlConnection con;
        private static string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\+Crazy+\Visual Studio\CCS Raffle Draw\Students.mdf;Integrated Security=True";
        public static void DB()
        {
            try
            {
                con = new SqlConnection(db);
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
