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
using static System.Net.Mime.MediaTypeNames;

namespace BaiThucHanhSo2
{
    public partial class FrmSinhVien: Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
        }
        
        private KETNOI kn = new KETNOI();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            BANGSV();    
            DANHMUCKHOA();
            DANHMUCLOP();
            DANHMUCHE();
            HIENTHIDULIEU();
        }

        public void BANGSV()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From SINHVIEN");
            DataGrid_SinhVien.DataSource = dta;
        }
        
        public void DANHMUCKHOA() //Hien thi ComboBox
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From KHOAVIEN");
            CboMAKHOA.DataSource = dta;
            CboMAKHOA.DisplayMember = "MAKHOA";
        }
        public void DANHMUCLOP() //Hien thi ComboBox
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From LOP");
            CboMALOP.DataSource = dta;
            CboMALOP.DisplayMember = "MALOP";
        }
        public void DANHMUCHE() //Hien thi ComboBox
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From HEDAOTAO");
            CboMAHE.DataSource = dta;
            CboMAHE.DisplayMember = "MAHE";
        }
        private void HIENTHIDULIEU() 
        {

            txtMASINHVIEN.DataBindings.Clear();
            txtMASINHVIEN.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "MASV");
            
            txtHOTEN.DataBindings.Clear();
            txtHOTEN.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "HOTEN");
            
            datePickerNGAYSINH.DataBindings.Clear();
            datePickerNGAYSINH.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "NGAYSINH");
            
            txtNOISINH.DataBindings.Clear();
            txtNOISINH.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "NOISINH");

            CboMAKHOA.DataBindings.Clear();
            CboMAKHOA.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "MAKHOA");

            CboMALOP.DataBindings.Clear();
            CboMALOP.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "MALOP");

            CboMAHE.DataBindings.Clear();
            CboMAHE.DataBindings.Add("Text", DataGrid_SinhVien.DataSource, "MAHE");
        }
        private void BtnLUU_Click(object sender, EventArgs e)
        {
            string strKtra = "Select MASV from SINHVIEN where MASV= '" + txtMASINHVIEN.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();
            if (doc_DL.Read() == true)
            {
                MessageBox.Show("Mã Sinh Viên này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMASINHVIEN.Focus();
                doc_DL.Close();
                doc_DL.Dispose();
            }
            else {
                byte GIOITINH;
                if (optNam.Checked == true)
                {
                    GIOITINH = 1;
                }
                else
                {
                    GIOITINH = 0;
                }
                string sql_luu = "INSERT INTO SINHVIEN VALUES('" + txtMASINHVIEN.Text + "','" + txtHOTEN.Text + "','" + GIOITINH + "','" + datePickerNGAYSINH.Text +
                "','" + txtNOISINH.Text + "','" + CboMAKHOA.Text + "','" + CboMALOP.Text + "','" + CboMAHE.Text + "')";
                kn.ThucThi(sql_luu);
                BANGSV();
                HIENTHIDULIEU();
            }
            
        }
        private void BtnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSUA_Click(object sender, EventArgs e)
        {
            byte GIOITINH;
            if (optNam.Checked == true)
            {
                GIOITINH = 1;
            }
            else
            {
                GIOITINH = 0;
            }
            string sql_sua = "INSERT INTO SINHVIEN VALUES('" + txtMASINHVIEN.Text + "','" + txtHOTEN.Text + "','" + GIOITINH + "','" + datePickerNGAYSINH.Text +
            "','" + txtNOISINH.Text + "','" + CboMAKHOA.Text + "','" + CboMALOP.Text + "','" + CboMAHE.Text + "')";
            kn.ThucThi(sql_sua);
            BANGSV();
            HIENTHIDULIEU();

        }

        private void BtnXOA_Click(object sender, EventArgs e)
        {
            string sql_xoa = "DELETE FROM SINHVIEN WHERE MASV='" + txtMASINHVIEN.Text + "'";
            kn.ThucThi(sql_xoa);
            BANGSV();
            HIENTHIDULIEU();
        }
    }
}
