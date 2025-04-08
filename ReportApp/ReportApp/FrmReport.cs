using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportApp
{
    public partial class FrmReport: Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        KETNOI kn = new KETNOI();
        private void crv1_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from V_THONGTIN");
            CrystalReport1 report1 = new CrystalReport1();
            report1.SetDataSource(dta);
            crv1.ReportSource = report1;
        }
    }
}