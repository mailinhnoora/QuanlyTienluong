using QLL.UI;
using QuanLyLuong.Models;
using System;
using System.Windows.Forms;

namespace QLL.UI
{

    public partial class frmMain : Form
    {
        private ThongTinDangNhap NguoiDung; 

        public frmMain(ThongTinDangNhap taiKhoan) //constructor có tham số
        {
            InitializeComponent();
            NguoiDung = taiKhoan;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (NguoiDung == null) return;

            lblChao.Text = $"Xin chào, {NguoiDung.HoTen}!";
            lblVaiTro.Text = $"Vai trò: {NguoiDung.VaiTro}   |   Tài khoản: {NguoiDung.TenDangNhap}";

            // Phân quyền: chỉ Admin mới thấy "Quản lý tài khoản"
            mnuQuanLyTaiKhoan.Visible = (NguoiDung.VaiTro == "Admin");
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            var frm = new frmNhanVien();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

 //chấm công: lưu lại thông tin thao tác ở thời điểm đó
        private void mnuChamCong_Click(object sender, EventArgs e)
        {
            var frm = new frmChamCong();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

     
        private void mnuBangLuong_Click(object sender, EventArgs e)
        {
            var frm = new frmBangLuong();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void mnuQuanLyTaiKhoan_Click(object sender, EventArgs e)//chỉ admin?
        {
            var frm = new frmTaiKhoan(NguoiDung);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        //đổi mật khẩu
        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            var frm = new frmDoiMatKhau(NguoiDung?.MaNV);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        //đăng xuất
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes) return;

            this.Hide();
            var login = new frmDangNhap();
            if (login.ShowDialog() == DialogResult.OK)
            {
                NguoiDung = login.TaiKhoanDangNhap;
                lblChao.Text = $"Xin chào, {NguoiDung.HoTen}!";
                lblVaiTro.Text = $"Vai trò: {NguoiDung.VaiTro}   |   Tài khoản: {NguoiDung.TenDangNhap}";
                mnuQuanLyTaiKhoan.Visible = (NguoiDung.VaiTro == "Admin");
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
