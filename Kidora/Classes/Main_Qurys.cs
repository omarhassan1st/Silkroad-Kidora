using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kidora_Tool
{
    class Main_Qurys
    {
        public static string Server, ID, pw, acc, shard,proxy;
        public static string _Account = @"Data Source = " + Server + "; Initial Catalog = " + acc + "; User ID = " + ID + "; Password=" + pw;
        public static string _Shard   = @"Data Source = " + Server + "; Initial Catalog = " + shard + "; User ID = " + ID + "; Password=" + pw;
        public static string _Proxy  =  @"Data Source = " + Server + "; Initial Catalog = " + proxy + "; User ID = " + ID + "; Password=" + pw;

        public static string NonQuery(string Query,string Connection)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                return "true";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }      
        }

        public static string Reader(string Query, string Connection,byte row,byte coulm)
        {
            try
            {
                string txt;
                DataTable table = new DataTable();
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        conn.Open();
                        table.Load(cmd.ExecuteReader());
                        txt = table.Rows[row][coulm].ToString();
                        conn.Close();
                    }
                }
                return txt;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
