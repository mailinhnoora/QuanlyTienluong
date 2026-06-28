using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyLuong.BLL;
using QuanLyLuong.Models;

namespace QLL.UI
{

    public partial class frmNhanVien : Form
    {
        private readonly NhanVienBLL _bll = new NhanVienBLL();
        private bool _dangSua = false;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            HienThiDanhSach(_bll.GetAll());
        }

        //combobox
        private void LoadComboBox()
        {
   
            var phongs = _bll.GetAllPhongBan();
            cboPhong.DataSource = phongs;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";

       
            var phongSearch = new List<PhongBan>
                { new PhongBan { MaPhong = null, TenPhong = "-- Tất cả --" } };
            phongSearch.AddRange(phongs);
            cboSearchPhong.DataSource = phongSearch;
            cboSearchPhong.DisplayMember = "TenPhong";
            cboSearchPhong.ValueMember = "MaPhong";


            var cvs = _bll.GetAllChucVu();
            cboChucVu.DataSource = cvs;
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";
        }

        //datagridview
        private void HienThiDanhSach(List<NhanVien> list)
        {
            dgvNhanVien.Columns.Clear();
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = null;

            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaNV", HeaderText = "Mã NV", Width = 80 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ và tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GioiTinhText", HeaderText = "Giới tính", Width = 75 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoDienThoai", HeaderText = "Điện thoại", Width = 110 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenPhong", HeaderText = "Phòng ban", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenChucVu", HeaderText = "Chức vụ", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LuongCoBan",
                HeaderText = "Lương CB",
                Width = 115,
                DefaultCellStyle = new DataGridViewCellStyle
                { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvNhanVien.DataSource = list;
        }

        // ── Chọn hàng → điền vào form ────────────────────
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0) return;
            var nv = dgvNhanVien.SelectedRows[0].DataBoundItem as NhanVien;
            if (nv == null) return;

            txtMaNV.Text = nv.MaNV;
            txtHoTen.Text = nv.HoTen;
            txtCCCD.Text = nv.CCCD;
            txtSDT.Text = nv.SoDienThoai;
            txtEmail.Text = nv.Email;
            pnlInput.Text = nv.DiaChi;
            txtLuong.Text = nv.LuongCoBan.ToString("N0");
            dtpNgaySinh.Value = nv.NgaySinh == DateTime.MinValue ? new DateTime(1995, 1, 1) : nv.NgaySinh;
            dtpNgayVaoLam.Value = nv.NgayVaoLam == DateTime.MinValue ? DateTime.Today : nv.NgayVaoLam;
            rdoNam.Checked = nv.GioiTinh;
            rdoNu.Checked = !nv.GioiTinh;

            if (cboPhong.Items.Count > 0) cboPhong.SelectedValue = nv.MaPhong;
            if (cboChucVu.Items.Count > 0) cboChucVu.SelectedValue = nv.MaChucVu;
        }

        // ── Double-click → chế độ sửa ────────────────────
        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _dangSua = true;
            txtMaNV.ReadOnly = true;
            btnThem.Visible = false;
            btnSua.Visible = true;
        }

        // ── Tìm kiếm ─────────────────────────────────────
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            string mp = (cboSearchPhong.SelectedItem as PhongBan)?.MaPhong;
            HienThiDanhSach(_bll.TimKiem(kw, mp));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboSearchPhong.SelectedIndex = 0;
            HienThiDanhSach(_bll.GetAll());
        }

        // ── Nút THÊM ─────────────────────────────────────
        private void btnThem_Click(object sender, EventArgs e)
        {
            var nv = LayDuLieuForm();
            if (nv == null) return;

            var (ok, msg) = _bll.Them(nv);
            ThongBao(ok, msg);
            if (ok) { HienThiDanhSach(_bll.GetAll()); XoaForm(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var nv = LayDuLieuForm();
            if (nv == null) return;

            var (ok, msg) = _bll.Sua(nv);
            ThongBao(ok, msg);
            if (ok) { HienThiDanhSach(_bll.GetAll()); XoaForm(); }
        }

        // ── Nút XÓA ──────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            { MessageBox.Show("Vui lòng chọn nhân viên cần xóa."); return; }

            var r = MessageBox.Show(
                $"Xóa nhân viên [{txtMaNV.Text} - {txtHoTen.Text}]?\n\nDữ liệu chấm công và bảng lương liên quan cũng bị xóa.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            var (ok, msg) = _bll.Xoa(txtMaNV.Text);
            ThongBao(ok, msg);
            if (ok) { HienThiDanhSach(_bll.GetAll()); XoaForm(); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaForm();
        }

        //Lấy dữ liệu từ form 
        private NhanVien LayDuLieuForm()
        {
            if (!decimal.TryParse(
                txtLuong.Text.Replace(",", "").Replace(".", ""),
                out decimal luong))
            {
                MessageBox.Show("Lương cơ bản không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return new NhanVien
            {
                MaNV = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = rdoNam.Checked,
                CCCD = txtCCCD.Text.Trim(),
                DiaChi = pnlInput.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                MaPhong = (cboPhong.SelectedItem as PhongBan)?.MaPhong,
                MaChucVu = (cboChucVu.SelectedItem as ChucVu)?.MaChucVu,
                NgayVaoLam = dtpNgayVaoLam.Value.Date,
                LuongCoBan = luong
            };
        }

        private void XoaForm()
        {
            txtMaNV.Text = ""; txtHoTen.Text = ""; txtCCCD.Text = "";
            txtSDT.Text = ""; txtEmail.Text = ""; pnlInput.Text = "";
            txtLuong.Text = "";
            dtpNgaySinh.Value = new DateTime(1995, 1, 1);
            dtpNgayVaoLam.Value = DateTime.Today;
            rdoNam.Checked = true;
            txtMaNV.ReadOnly = false;
            _dangSua = false;
            btnThem.Visible = true;
            btnSua.Visible = false;
        }

        private void ThongBao(bool ok, string msg) =>
            MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void cboSearchPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
