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
using ThucTapNhom.DAO;
using ThucTapNhom.GUI;

namespace ThucTapNhom
{
    public partial class frm_QLNV : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAcessObject = new DbQuery();
        string MaNV { get; set; }
        public frm_QLNV(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }   
        private void frm_QLNV_Load(object sender, EventArgs e)
        {
            HienThiMaNV();
            HienThiChucVuNhanVien();
            DataTable dt = DbAcessObject.HienThiTenNV(con, MaNV);
            lbNameAcc.Text += dt.Rows[0][0];      
        }
        public void HienThiMaNV()
        {
            SqlCommand cmd = new SqlCommand("Select MaNV from NhanVien", con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
        }
        public void HienThiChucVuNhanVien()
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDSChucVu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cboChucVuNV.DataSource = dt;
            cboChucVuNV.DisplayMember = "ChucVu";
            cboChucVuNV.ValueMember = "ChucVu";
        }
        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThiMaNV();
            HienThiChucVuNhanVien();
        }
        public void HienThiDSNhanVien()
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDSNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            View_NhanVien.DataSource = dt;
        }
        private void View_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaNV.Text = View_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = View_NhanVien.CurrentRow.Cells[1].Value.ToString();
            if (View_NhanVien.CurrentRow.Cells[2].Value.ToString().Trim() == "Nam")
            {
                rdbNam.Checked = true;
            }
            else if (View_NhanVien.CurrentRow.Cells[2].Value.ToString().Trim() == "Nữ")
            {
                rdbNu.Checked = true;
            }
            txtDiaChi.Text = View_NhanVien.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = View_NhanVien.CurrentRow.Cells[4].Value.ToString();
            cboChucVuNV.Text = View_NhanVien.CurrentRow.Cells[5].Value.ToString();
        }       
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            Form_TimKiemNhanVien nv = new Form_TimKiemNhanVien();
            nv.ShowDialog();
        }
        private void btnHienThi_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDSNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            View_NhanVien.DataSource = dt;
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa bản ghi hay không?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("QLNhaHang_XoaNV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", cboMaNV.Text);
                cmd.ExecuteNonQuery();
                HienThiDSNhanVien();
                MessageBox.Show("Xóa thành công bản ghi");
            }
        }
        private void btnChinhSua_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_SuaNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", cboMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
            if (rdbNu.Checked == true)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rdbNu.Text);

            }
            else
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rdbNam.Text);
            }
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
            cmd.Parameters.AddWithValue("@ChucVu", cboChucVuNV.Text);
            cmd.ExecuteNonQuery();
            HienThiDSNhanVien();
            MessageBox.Show("Thao tac Chinh sua nhan vien thanh cong");
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_ThemNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", cboMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
            if (rdbNu.Checked == true)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rdbNu.Text);

            }
            else
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rdbNam.Text);
            }
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
            cmd.Parameters.AddWithValue("@ChucVu", cboChucVuNV.Text);
            cmd.ExecuteNonQuery();
            HienThiDSNhanVien();
            MessageBox.Show("Thao tac Them nhan vien thanh cong");
        }

        private void View_NhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cboMaNV.Text = View_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = View_NhanVien.CurrentRow.Cells[1].Value.ToString();
            if (View_NhanVien.CurrentRow.Cells[2].Value.ToString().Trim() == "Nam")
            {
                rdbNam.Checked = true;
            }
            else if (View_NhanVien.CurrentRow.Cells[2].Value.ToString().Trim() == "Nữ")
            {
                rdbNu.Checked = true;
            }
            txtDiaChi.Text = View_NhanVien.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = View_NhanVien.CurrentRow.Cells[4].Value.ToString();
            cboChucVuNV.Text = View_NhanVien.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
