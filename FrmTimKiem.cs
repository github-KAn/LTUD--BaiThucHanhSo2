using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BaiThucHanhSo2
{
    public partial class FrmTimKiem: Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }
        KETNOI kn = new KETNOI();
        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("Select * from LOP");
            cboLOP.DataSource = dta;
            cboLOP.DisplayMember = "MALOP";

            DataTable dta1 = kn.Lay_DulieuBang("Select * from KHOAVIEN");
            cboKHOA.DataSource = dta1;
            cboKHOA.DisplayMember = "MAKHOA";
        }
        
        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            DataTable dta2 = new DataTable();
            string sqltk;
            //sqltk = "Select * From SINHVIEN where MASV like '" + txtMASV.Text+ "'AND HOTEN like'"+ txtTEN.Text + "'"+"AND MALOP like '"+cboLOP.Text+"' AND MAKHOA like '"+cboKHOA.Text+"'";
            if (optNHAPMASV.Checked == true)
            {
                //sqltk = "Select * From SINHVIEN where MASV like '" + txtMASV.Text + "'";
                sqltk = string.Format("Execute SP_TIM_MASV'{0}'", txtMASV.Text);
                dta2 = kn.Lay_DulieuBang(sqltk);
            }
            //if (optNHAPTEN.Checked == true)
            //{
            //    sqltk = "Select * From SINHVIEN where HOTEN like '" + txtTEN.Text + "'";
            //    dta2 = kn.Lay_DulieuBang(sqltk);
            //}
            if (optNHAPMAKHOA.Checked == true)
            {
                //sqltk = "Select * From SINHVIEN where MAKHOA = '" + cboKHOA.Text + "'";
                sqltk = string.Format("Execute SP_TIM_MAKHOA'{0}'", cboKHOA.Text);
                dta2 = kn.Lay_DulieuBang(sqltk);
            }
            if (optNHAPMALOP.Checked == true)
            {
                //sqltk = "Select * From SINHVIEN where MALOP = '" + cboLOP.Text + "'";
                sqltk = string.Format("Execute SP_TIM_LOP'{0}'", cboLOP.Text);
                dta2 = kn.Lay_DulieuBang(sqltk);
            }

            //sqltk = string.Format("Execute SP_TIM_LOP'{0}'", cboLOP.Text);
            //dta2 = kn.Lay_DulieuBang(sqltk);
            grid_KETQUATK.DataSource = dta2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTIMKIEM_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLOP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labeTITLE_TK_Click(object sender, EventArgs e)
        {

        }
    }
}
