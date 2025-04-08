using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ReportApp
{
    internal class KETNOI
    {
        public SqlConnection cnn;
        SqlCommand cmd;
        DataTable dta;
        SqlDataAdapter ada;

        public void KetNoi_Dulieu()
        {
            string strKetNoi = @"Data Source=DESKTOP-RON79SN;Database=master;Initial Catalog=QUANLYSV123;Integrated Security=True;Trusted_Connection=True;";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }
        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public DataTable Lay_DulieuBang(string Sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public void ThucThi(string Sql)
        {
            KetNoi_Dulieu();
            cmd=new SqlCommand(Sql, cnn);   
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }

}
