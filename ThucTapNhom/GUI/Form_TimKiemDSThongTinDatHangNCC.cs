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
    public partial class Form_TimKiemDSThongTinDatHangNCC : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAcessObject = new DbQuery();
        public Form_TimKiemDSThongTinDatHangNCC()
        {
            InitializeComponent();
        }
        public void HienThiNhanVienDatHang()
        {
            DataTable dt = DbAcessObject.HienThiNhanVienDatHangNhaCC(con);
            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "TenNV";
        }
        public void HienThiNCC()
        {
            DataTable dt = DbAcessObject.HienThiTenNCC(con);
            cboNCC.DataSource = dt;
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "TenNCC";
        }
        public void HienThi()
        {
            DataTable dt = DbAcessObject.QLNhaHang_DSTimKiemMUAHANGNCC(con);
            view_NCC.DataSource = dt;
        }
        private void Form_TimKiemDSThongTinDatHangNCC_Load(object sender, EventArgs e)
        {
            HienThiNhanVienDatHang();
            HienThiNCC();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiChiTietPhieuDatHanhNCC_TimKiem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNV", "%" + cboNhanVien.Text + "%");
            cmd.Parameters.AddWithValue("@TenNCC", "%" + cboNCC.Text + "%");
            cmd.Parameters.AddWithValue("@NgayNhap1", dtpkTuNgay.Value);
            cmd.Parameters.AddWithValue("@NgayNhap2", dtpkDenNgay.Value);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            view_NCC.DataSource = dt;
        }
    }
}
