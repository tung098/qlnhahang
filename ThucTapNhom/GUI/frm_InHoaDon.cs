using Microsoft.Reporting.WinForms;
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
using ThucTapNhom.BLL;

namespace ThucTapNhom.GUI
{
    public partial class frm_InHoaDon : Form
    {
        SqlConnection con = Program.con;
        private DbQuery DbAccessObject = null;
        int MaPYC { get; set; }
        public frm_InHoaDon(int MaPYC)
        {
            InitializeComponent();
            DbAccessObject = new DbQuery();
            this.MaPYC = MaPYC;
        }

        private void frm_InHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = DbAccessObject.HienThiHoaDon(con, MaPYC);
            //rpViewer.LocalReport.ReportPath = "RpHoaDon.rdlc";
            rpViewer.LocalReport.DataSources.Clear();
            rpViewer.LocalReport.DataSources.Add(new ReportDataSource("DsHoaDon", dt));
            this.rpViewer.RefreshReport();
        }
    }
}
