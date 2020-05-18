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

namespace ThucTapNhom.GUI
{
    public partial class frm_QLKH : Form
    {
        SqlConnection con = Program.con;
        DbQuery DbAcessObject = new DbQuery();
        string MaNV { get; set; }
        public frm_QLKH(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }
        public void HienThiDSKH()
        {
            DataTable dt = DbAcessObject.HienThiDSKH(con);
            dgvDSKH.DataSource = dt;
        }
        private void btnDanhSachNV_Click(object sender, EventArgs e)
        {
            HienThiDSKH();
        }

        private void frm_QLKH_Load(object sender, EventArgs e)
        {
            DataTable dt = DbAcessObject.HienThiTenNV(con, MaNV);
            lbNameAcc.Text += dt.Rows[0][0];

            HienThiDSKH();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.SetData(txtTenKH.Text, cbbGioiTinh.Text, txtDiaChi.Text, txtSĐT.Text);

            try
            {
                int ret = DbAcessObject.ThemKH(con, kh);
                HienThiDSKH();
                MessageBox.Show("Thêm khách hàng thành công!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi không thêm được!");
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắn chắn muốn xoá không?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DbAcessObject.XoaKH(con, dgvDSKH.CurrentRow.Cells["MaKH"].Value.ToString());
                MessageBox.Show("Xoá thành công!");
                HienThiDSKH();
            }
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenKH.Text = dgvDSKH.CurrentRow.Cells[1].Value.ToString();
            cbbGioiTinh.Text = dgvDSKH.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDSKH.CurrentRow.Cells[3].Value.ToString();
            txtSĐT.Text = dgvDSKH.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.SetData(txtTenKH.Text, cbbGioiTinh.Text, txtDiaChi.Text, txtSĐT.Text);
            kh.MaKH = int.Parse(dgvDSKH.CurrentRow.Cells["MaKH"].Value.ToString());
            DbAcessObject.CapNhatKH(con, kh);
            HienThiDSKH();
            MessageBox.Show("Cập nhật nhân viên thành công!");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdbTheoTen.Checked == true)
            {
                DataTable dt = DbAcessObject.TimKHTheoTen(con, txtTimKiem.Text);
                dgvDSKH.DataSource = dt;
            }
            else if (rdbTheoGioiTinh.Checked == true)
            {
                DataTable dt = DbAcessObject.TimKHTheoGioiTinh(con, txtTimKiem.Text);
                dgvDSKH.DataSource = dt;
            }
        }
    }
}
