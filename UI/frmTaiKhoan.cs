using System;
using System.Windows.Forms;
using QuanLyLuong.BLL;
using QuanLyLuong.Models;

namespace QLL.UI
{

    public partial class frmTaiKhoan : Form
    {
        private readonly TaiKhoanBLL  _bll   = new TaiKhoanBLL();
        private readonly NhanVienBLL  _nvBll = new NhanVienBLL();
        private readonly ThongTinDangNhap _nd;

        public frmTaiKhoan(ThongTinDangNhap nguoiDung)
        {
            _nd = nguoiDung;
            InitializeComponent();
this.Load += frmTaiKhoan_Load;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Load nhân viên vào ComboBox
            var nvs = _nvBll.GetAll();
            cboNhanVien.DataSource    = nvs;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember   = "MaNV";

            // Load danh sách tài khoản
            var tks = _bll.GetAll();
            dgvTaiKhoan.Columns.Clear();
            dgvTaiKhoan.AutoGenerateColumns = false;
            dgvTaiKhoan.DataSource = null;

            dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaTK",        HeaderText = "Mã TK",       Width = 70  });
            dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaNV",        HeaderText = "Mã NV",       Width = 85  });
            dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen",       HeaderText = "Họ tên",      AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenDangNhap", HeaderText = "Tên đăng nhập", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvTaiKhoan.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "VaiTro",      HeaderText = "Vai trò",     Width = 110 });

            dgvTaiKhoan.DataSource = tks;
        }

        // ── Chọn hàng → điền form ─────────────────────────
        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0) return;
            var tk = dgvTaiKhoan.SelectedRows[0].DataBoundItem as TaiKhoan;
            if (tk == null) return;

            cboNhanVien.SelectedValue = tk.MaNV;
            txtTenDangNhap.Text       = tk.TenDangNhap;
            cboVaiTro.SelectedItem    = tk.VaiTro;
        }

        // ── Nút THÊM ──────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = (cboNhanVien.SelectedItem as NhanVien)?.MaNV;
            var (ok, msg) = _bll.Them(
                maNV,
                txtTenDangNhap.Text.Trim(),
                txtMatKhau.Text,
                cboVaiTro.SelectedItem?.ToString());

            MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) { LoadData(); XoaForm(); }
        }

        // ── Nút SỬA VAI TRÒ ──────────────────────────────
        private void btnSuaVaiTro_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            { MessageBox.Show("Vui lòng chọn tài khoản."); return; }

            var tk = dgvTaiKhoan.SelectedRows[0].DataBoundItem as TaiKhoan;
            var (ok, msg) = _bll.SuaVaiTro(tk.MaTK, cboVaiTro.SelectedItem?.ToString());

            MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) LoadData();
        }

        // ── Nút XÓA ───────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            { MessageBox.Show("Vui lòng chọn tài khoản."); return; }

            var tk = dgvTaiKhoan.SelectedRows[0].DataBoundItem as TaiKhoan;

            if (tk.MaTK == _nd?.MaTK)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var r = MessageBox.Show(
                $"Xóa tài khoản [{tk.TenDangNhap}]?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            var (ok, msg) = _bll.Xoa(tk.MaTK);
            MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) LoadData();
        }

        // ── Nút LÀM MỚI ───────────────────────────────────
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaForm(); LoadData();
        }

        private void XoaForm()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboVaiTro.SelectedIndex = 2; // NhanVien
        }
    }

    // =====================================================
    //  FORM ĐỔI MẬT KHẨU
    // =====================================================
    public partial class frmDoiMatKhau : Form
    {
        private readonly TaiKhoanBLL _bll;
        private readonly string      _maNV;

        public frmDoiMatKhau(string maNV)
        {
            _maNV = maNV;
            _bll  = new TaiKhoanBLL();
            InitializeComponent();
        }

        // ── Nút LƯU ───────────────────────────────────────
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var (ok, msg) = _bll.DoiMatKhau(
                    _maNV,
                    txtMatKhauCu.Text,
                    txtMatKhauMoi.Text,
                    txtNhapLai.Text);

                MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                    MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                if (ok) Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ── Nút HỦY ───────────────────────────────────────
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
