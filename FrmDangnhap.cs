using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhSo2
{
    public partial class FrmDangnhap: Form
    {
        KETNOI kn = new KETNOI();
        public FrmDangnhap()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtDANGNHAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDANGNHAP_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();

            string dn = txtDANGNHAP.Text;
            string mk = txtMATKHAU.Text;
            string sql_login = "Select TENDN,MATKHAU FROM HETHONG where TENDN ='" + dn + "' and MATKHAU='" + mk + "'";

            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();

            if (datRed.Read()==true)
            {
                MessageBox.Show("Đăng nhập thành công");
                //Hiển thị một frm Main thì làm như nào
                FrmLop frmLop= new FrmLop();
                frmLop.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Hãy kiểm tra lại thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
