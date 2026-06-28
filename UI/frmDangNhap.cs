using System;
using System.Windows.Forms;
using QuanLyLuong.BLL;
using QuanLyLuong.Models;

namespace QLL.UI
{

    public partial class frmDangNhap : Form
    {
        // Lưu thông tin người dùng sau khi đăng nhập thành công
        public ThongTinDangNhap TaiKhoanDangNhap { get; private set; }

        private readonly TaiKhoanBLL _bll = new TaiKhoanBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }




        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPass.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnDangNhap_Click(sender, e);
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = _bll.DangNhap(txtUser.Text.Trim(), txtPass.Text);

                if (tk == null)
                {
                    MessageBox.Show(
                        "Tên đăng nhập hoặc mật khẩu không đúng!",
                        "Đăng nhập thất bại",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtPass.Focus();
                    txtPass.SelectAll();
                    return;
                }

                TaiKhoanDangNhap = tk;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể kết nối cơ sở dữ liệu!\n\n" + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
