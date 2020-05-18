using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom
{
    public partial class frm_ChonBanAn : Form
    {
        string MaNV { get; set; }
        public frm_ChonBanAn(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void HienThiFrmPYC(string idBan)
        {
            frm_PhieuYeuCau frm = new frm_PhieuYeuCau(idBan, MaNV);
            frm.ShowDialog();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string id = btn.Name.Split('n')[1];
            HienThiFrmPYC(id);
        }
    }
}
