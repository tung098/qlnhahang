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
    public partial class Form_TimKiemNhanVien : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAcessObject = new DbQuery();
        public Form_TimKiemNhanVien()
        {
            InitializeComponent();
        }
        public void HienThiTenNhanVien()
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDSTenNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cboTenNV.DataSource = dt;
            cboTenNV.DisplayMember = "TenNV";
            cboTenNV.ValueMember = "TenNV";
        }
        public void HienThiDiaChiNhanVien()
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDSDiaChiNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cboDiaChi.DataSource = dt;
            cboDiaChi.DisplayMember = "DiaChi";
            cboDiaChi.ValueMember = "DiaChi";
        }
        public void HienThiChucVuNhanVien()
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_HienThiDSChucVuNV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cboChucVu.DataSource = dt;
            cboChucVu.DisplayMember = "ChucVu";
            cboChucVu.ValueMember = "ChucVu";
        }

        private void btnTiemkiem_tenNV_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_TimKiemNVTheoTen", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNV", "%" + cboTenNV.Text + "%");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            View_DSNhanVien_Timkiem.DataSource = dt;
        }

        private void btnTimkiem_DiaChiNV_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_TimKiemNVTheoDiaChi", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DiaChi", "%" + cboDiaChi.Text + "%");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            View_DSNhanVien_Timkiem.DataSource = dt;
        }

        private void btnTimKiemChucVu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("QLNhaHang_TimKiemNVTheoChucVu", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ChucVu", "%" + cboChucVu.Text + "%");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            View_DSNhanVien_Timkiem.DataSource = dt;
        }

        private void Form_TimKiemNhanVien_Load(object sender, EventArgs e)
        {
            HienThiTenNhanVien();
            HienThiDiaChiNhanVien();
            HienThiChucVuNhanVien();
        }
    }
}
