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
    public partial class FrmLop: Form
    {
        public FrmLop()
        {
            InitializeComponent();
        }
        private KETNOI kn = new KETNOI();
        private void FrmLop_Load(object sender, EventArgs e)
        {
            BANGLOP();    
            KHOAVIEN();
            MALOP();
            TENLOP();

        }
        public void BANGLOP()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From LOP");
            DataGrid_Lop.DataSource = dta;
        }
        
        public void KHOAVIEN() //Hien thi ComboBox
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From KHOAVIEN");
            CboKHOAVIEN.DataSource = dta;
            CboKHOAVIEN.DisplayMember = "MAKHOA";
        }
        public void MALOP() //Hien thi ComboBox
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From LOP");
            CboMALOP.DataSource = dta;
            CboMALOP.DisplayMember = "MALOP";
        }
        public void TENLOP() //Hien thi ComboBox
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From LOP");
            CboTENLOP.DataSource = dta;
            CboTENLOP.DisplayMember = "TENLOP";
        }
        private void cboKhoaVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelMALOP_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            string sql_xoa = "Delete LOP where MALOP='" + txtMALOP.Text + "'";
            kn.ThucThi(sql_xoa);
            BANGLOP();
        }

        private void btnMOI_Click(object sender, EventArgs e)
        {
            txtMALOP.Text = "";
            txtTENLOP.Text = "";
            txtKHOAVIEN.Text = "";
            txtGHICHU.Text = "";
            //new text
        }
        private void HIENTHI_DULIEU()
        {
            txtMALOP.DataBindings.Clear();
            txtMALOP.DataBindings.Add("Text", DataGrid_Lop.DataSource,"MALOP");

            txtKHOAVIEN.DataBindings.Clear();
            txtKHOAVIEN.DataBindings.Add("Text", DataGrid_Lop.DataSource, "MAKHOA");

            txtTENLOP.DataBindings.Clear();
            txtTENLOP.DataBindings.Add("Text", DataGrid_Lop.DataSource, "TENLOP");

            txtCVHT.DataBindings.Clear();
            txtCVHT.DataBindings.Add("Text", DataGrid_Lop.DataSource, "CVHT");

            txtGHICHU.DataBindings.Clear();
            txtGHICHU.DataBindings.Add("Text", DataGrid_Lop.DataSource, "GHICHU");
        }


        private void btnLUU_Click(object sender, EventArgs e)
        {
            string strKtra = "Select MALOP from LOP where MALOP= '" + txtMALOP.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();
            if (doc_DL.Read() == true)
            {
                MessageBox.Show("Mã Lớp này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMALOP.Focus();
                doc_DL.Close();
                doc_DL.Dispose();
            }
            else
            {
                string sql_luu = "Insert into LOP Values('" + txtMALOP.Text + "'," + txtTENLOP.Text + "'," +
                    "'," + CboKHOAVIEN.Text + "'," + txtCVHT.Text + "'," + txtGHICHU.Text + "')";
                kn.ThucThi(sql_luu);
                BANGLOP();
                HIENTHI_DULIEU();
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            string sql_Sua = "UPDATE LOP SET TENLOP='" + txtTENLOP.Text + "'," + "MAKHOA='" + CboKHOAVIEN.Text + "'";
        }
    }
}
