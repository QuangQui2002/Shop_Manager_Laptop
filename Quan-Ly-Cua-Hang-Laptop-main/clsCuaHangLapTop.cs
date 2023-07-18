using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace _174_182_QLCHLAPTOP
{
    class clsCuaHangLapTop
    {
        SqlConnection con = new SqlConnection();
        
        void KetNoi()
        {
            /// LAPTOP-I13TGSE2\SQLEXPRESS
            //  DESKTOP-U8EOD4B\SQLEXPRESS
            con.ConnectionString = @"Data source= LAPTOP-I13TGSE2\SQLEXPRESS;Initial Catalog= QUANLYCUAHANGLAPTOP;integrated Security =True";
            if(con.State==ConnectionState.Closed)
                con.Open();
        }
        public clsCuaHangLapTop()
        {
            KetNoi();
        }
        public DataSet LayDuLieu(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            return ds;
        }
        public int CapNhatDuLieu(String sql) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();

        }
        void dongketnoi() {
            con.Close();   
        }
    }
}
