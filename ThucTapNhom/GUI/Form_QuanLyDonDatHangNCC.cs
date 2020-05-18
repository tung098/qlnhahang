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
    public partial class Form_QuanLyDonDatHangNCC : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAcessObject = new DbQuery();
        public Form_QuanLyDonDatHangNCC()
        {
            InitializeComponent();
        }
        public void HienThiNCC()
        {
            DataTable dt = DbAcessObject.HienThiTenNCC(con);
            cboNCC.DataSource = dt;
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "TenNCC";
        }
        public void HienThiMaNCC1()
        {
            DataTable dt = DbAcessObject.HienThiMaNCC(con);
            cboMaNCC1.DataSource = dt;
            cboMaNCC1.DisplayMember = "MaNCC";
            cboMaNCC1.ValueMember = "MaNCC";
        }
        public void HienThiMaNCC()
        {
            DataTable dt = DbAcessObject.HienThiMaNCC(con);
            cboMaNCC.DataSource = dt;
            cboMaNCC.DisplayMember = "MaNCC";
            cboMaNCC.ValueMember = "MaNCC";
        }
        public void HienThiDiaChiNCC()
        {
            DataTable dt = DbAcessObject.HienThiDiaChiNCC(con);
            cboDiaChi.DataSource = dt;
            cboDiaChi.DisplayMember = "DiaChi";
            cboDiaChi.ValueMember = "DiaChi";
        }
        public void HienThiDienThoaiNCC()
        {
            DataTable dt = DbAcessObject.HienThiDienThoaiNCC(con);
            cboSĐT.DataSource = dt;
            cboSĐT.DisplayMember = "DienThoai";
            cboSĐT.ValueMember = "DienThoai";
        }
        public void HienThiMaNV()
        {
            DataTable dt = DbAcessObject.HienThiMaNV(con);
            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
        }

        private void Form_QuanLyDonDatHangNCC_Load(object sender, EventArgs e)
        {
            HienThiMaNCC();
            HienThiMaNCC1();
            HienThiNCC();
            HienThiDiaChiNCC();
            HienThiDienThoaiNCC();
            HienThiMaNV();
        }

        private void btnNhapTP_Click(object sender, EventArgs e)
        {
            frm_NhapThucPhamVaoPhieuNhap NhapThucPham = new frm_NhapThucPhamVaoPhieuNhap(txtMaPhieuNhap.Text);
            NhapThucPham.ShowDialog();
        }

        private void btnHienThiPN_Click(object sender, EventArgs e)
        {
            DataTable dt = DbAcessObject.HienThiDanhSachPhieuNhap(con);
            View_DSPN.DataSource = dt;
        }

        private void btnTaoMoiPN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemPhieuNhap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuNhap  ", txtMaPhieuNhap.Text);
            cmd.Parameters.AddWithValue("@NgayNhap      ", dtpNgayNhap.Value);
            cmd.Parameters.AddWithValue("@MaNV          ", cboMaNV.Text);
            cmd.Parameters.AddWithValue("@MaNCC         ", cboMaNCC.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Lưu thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thực sự muốn xóa bản ghi hay không ?", "Chú ý?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("QLNhaHang_XoaPhieuNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuNhap", txtMaPhieuNhap.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thành công bản ghi ");
            }
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaPhieuNhap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuNhap", txtMaPhieuNhap.Text);
            cmd.Parameters.AddWithValue("@MaNV", cboMaNV.Text);
            cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
            cmd.Parameters.AddWithValue("@MaNCC", cboMaNCC.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
        }

        private void View_DSPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuNhap.Text = View_DSPN.CurrentRow.Cells[0].Value.ToString();
            cboMaNV.Text = View_DSPN.CurrentRow.Cells[2].Value.ToString();
            dtpNgayNhap.Text = View_DSPN.CurrentRow.Cells[1].Value.ToString();
            cboMaNCC.Text = View_DSPN.CurrentRow.Cells[3].Value.ToString();
        }

        private void View_DSNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuNhap.Text = View_DSNCC.CurrentRow.Cells[0].Value.ToString();
            cboNCC.Text = View_DSNCC.CurrentRow.Cells[1].Value.ToString();
            cboDiaChi.Text = View_DSNCC.CurrentRow.Cells[2].Value.ToString();
            cboSĐT.Text = View_DSNCC.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnHienThiNCC_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from NhaCungCap", con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            View_DSNCC.DataSource = dt;
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemNCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNCC   ", cboMaNCC1.Text);
            cmd.Parameters.AddWithValue("@TenNCC   ", cboNCC.Text);
            cmd.Parameters.AddWithValue("@DiaChi   ", cboDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT      ", cboSĐT.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Lưu thành công");
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa bản ghi hay không ?", "Chú ý?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("QLNhaHang_XoaNCC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", cboMaNCC1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa NCC thành công");
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaNCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNCC", cboMaNCC1.Text);
            cmd.Parameters.AddWithValue("@TenNCC", cboNCC.Text);
            cmd.Parameters.AddWithValue("@DiaChi", cboDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT", cboSĐT.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhập NCC thành công");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form_TimKiemDSThongTinDatHangNCC search = new Form_TimKiemDSThongTinDatHangNCC();
            search.Show();
        }
    }
}
