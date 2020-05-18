using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom.GUI;

namespace ThucTapNhom
{
    public partial class frm_MenuChucNang : Form
    {
        public string MaNV { get; set; }
        private int QuyenTruyCap { get; set; }
        public frm_MenuChucNang(string MaNV, int QuyenTruyCap)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.QuyenTruyCap = QuyenTruyCap;
        }

        private void frm_MenuChucNang_Load(object sender, EventArgs e)
        {
            if(QuyenTruyCap != 1)
            {
                foreach (var picbox in this.Controls.OfType<PictureBox>())
                {
                    picbox.Visible = false;
                }
                foreach (var lb in this.Controls.OfType<Label>())
                {
                    lb.Visible = false;
                }
                switch (QuyenTruyCap)
                {
                    case 2:
                        {
                            picQLNV.Visible = true;
                            lbQLNV.Visible = true;
                            break;
                        }
                    case 3:
                        {
                            picQLOrder.Visible = true;
                            lbQLOrder.Visible = true;
                            break;
                        }
                    case 4:
                        {
                            picQLMonAn.Visible = true;
                            lbQLMonAn.Visible = true;
                            break;
                        }
                    case 5:
                        {
                            picQLTP.Visible = true;
                            lbQLTP.Visible = true;
                            break;
                        }
                    case 6:
                        {
                            picDatHangNCC.Visible = true;
                            lbDatHangNCC.Visible = true;
                            break;
                        }
                    default:
                        break;
                }
            }  
        }

        private void picQLOrder_Click(object sender, EventArgs e)
        {
            frm_ChonBanAn frmBanAn = new frm_ChonBanAn(MaNV);
            frmBanAn.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms.OfType<frm_DangNhap>().ToList()[0].Show();        
        }

        private void picQLNV_Click(object sender, EventArgs e)
        {
            frm_QLNV frmQLNV = new frm_QLNV(MaNV);
            frmQLNV.ShowDialog();
        }

        private void picQLTP_Click(object sender, EventArgs e)
        {
            frm_QuanLyThucPham frmQLTP = new frm_QuanLyThucPham(MaNV);
            frmQLTP.ShowDialog();
        }

        private void picQLMonAn_Click(object sender, EventArgs e)
        {
            frm_QLMonAn frmQLMonAn = new frm_QLMonAn();
            frmQLMonAn.ShowDialog();
        }

        private void picQLKH_Click(object sender, EventArgs e)
        {
            frm_QLKH frmQLKH = new frm_QLKH(MaNV);
            frmQLKH.ShowDialog();
        }
        private void picDatHangNCC_Click(object sender, EventArgs e)
        {
            Form_QuanLyDonDatHangNCC DatHangNCC = new Form_QuanLyDonDatHangNCC();
            DatHangNCC.ShowDialog();
        }
    }
}
