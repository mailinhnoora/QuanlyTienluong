using System;
using System.Windows.Forms;
using QuanLyLuong.BLL;
using QuanLyLuong.Models;

namespace QLL.UI
{

    public partial class frmChamCong : Form
    {
        private readonly ChamCongBLL _bll = new ChamCongBLL();
        private readonly NhanVienBLL _nvBll = new NhanVienBLL();

        public frmChamCong()
        {
            InitializeComponent();
	    this.Load += frmChamCong_Load;
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            // Load danh sách nhân viên vào ComboBox
            var list = _nvBll.GetAll();
            cboNhanVien.DataSource = list;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNV";

            // Mặc định tháng/năm hiện tại
            nudThang.Value = DateTime.Now.Month;
            nudNam.Value = DateTime.Now.Year;

            XemChamCong();
        }

        // ── Hiển thị chấm công ────────────────────────────
        private void XemChamCong()
        {
            var list = _bll.GetByThangNam((int)nudThang.Value, (int)nudNam.Value);

            dgvChamCong.Columns.Clear();
            dgvChamCong.AutoGenerateColumns = false;
            dgvChamCong.DataSource = null;

            dgvChamCong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaChamCong", HeaderText = "Mã CC", Width = 70 });
            dgvChamCong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaNV", HeaderText = "Mã NV", Width = 85 });
            dgvChamCong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvChamCong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenPhong", HeaderText = "Phòng ban", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvChamCong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayCongChuanChi", HeaderText = "Chuẩn", Width = 70, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
            dgvChamCong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayCongThucTe", HeaderText = "Thực tế", Width = 70, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
            dgvChamCong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayNghiPhep", HeaderText = "Nghỉ phép", Width = 80, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
            dgvChamCong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayNghiKhongPhep", HeaderText = "Nghỉ KP", Width = 75, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });

            dgvChamCong.DataSource = list;
            lblSoNV.Text = $"Tổng: {list.Count} nhân viên đã chấm công";
        }

        // ── Chọn hàng → điền vào form ────────────────────
        private void dgvChamCong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChamCong.SelectedRows.Count == 0) return;
            var cc = dgvChamCong.SelectedRows[0].DataBoundItem as ChamCong;
            if (cc == null) return;

            cboNhanVien.SelectedValue = cc.MaNV;
            nudChuanChi.Value = cc.NgayCongChuanChi;
            nudThucTe.Value = cc.NgayCongThucTe;
            nudThucTe.Value = cc.NgayNghiPhep;
            nudNghiKhong.Value = cc.NgayNghiKhongPhep;
        }

        // ── Nút XEM ───────────────────────────────────────
        private void btnXem_Click(object sender, EventArgs e)
        {
            XemChamCong();
        }

        // ── Nút LƯU ───────────────────────────────────────
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNV = (cboNhanVien.SelectedItem as NhanVien)?.MaNV;
            var (ok, msg) = _bll.Luu(
                maNV,
                (int)nudThang.Value, (int)nudNam.Value,
                nudChuanChi.Value, nudThucTe.Value,
                nudThucTe.Value, nudNghiKhong.Value);

            MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) XemChamCong();
        }

        // ── Nút XÓA ───────────────────────────────────────
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.SelectedRows.Count == 0)
            { MessageBox.Show("Vui lòng chọn dòng cần xóa."); return; }

            var cc = dgvChamCong.SelectedRows[0].DataBoundItem as ChamCong;
            if (cc == null) return;

            var r = MessageBox.Show(
                $"Xóa chấm công của [{cc.HoTen}] tháng {cc.Thang}/{cc.Nam}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            var (ok, msg) = _bll.Xoa(cc.MaChamCong);
            MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) XemChamCong();
        }

        // ── Nút THÊM LOẠT (thêm tất cả NV chưa CC) ───────
        private void btnThemLoat_Click(object sender, EventArgs e)
        {
            int t = (int)nudThang.Value, n = (int)nudNam.Value;
            var chua = _bll.GetNVChuaChamCong(t, n);

            if (chua.Count == 0)
            {
                MessageBox.Show("Tất cả nhân viên đã được chấm công tháng này.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int dem = 0;
            foreach (var nv in chua)
            {
                var (ok, _) = _bll.Luu(nv.MaNV, t, n, 26, 26, 0, 0);
                if (ok) dem++;
            }

            MessageBox.Show(
                $"Đã thêm chấm công cho {dem}/{chua.Count} nhân viên\n(mặc định 26 ngày công).",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XemChamCong();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
