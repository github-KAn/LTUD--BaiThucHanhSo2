using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhSo2
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }
        
        private void Frm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYSV123DataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qUANLYSV123DataSet.LOP);
            // TODO: This line of code loads data into the 'qUANLYSV123DataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qUANLYSV123DataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qUANLYSV123DataSet.HEDAOTAO' table. You can move, or remove it, as needed.
            this.hEDAOTAOTableAdapter.Fill(this.qUANLYSV123DataSet.HEDAOTAO);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
