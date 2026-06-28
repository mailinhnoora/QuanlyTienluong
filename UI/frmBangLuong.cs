using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyLuong.BLL;
using QuanLyLuong.Models;

namespace QLL.UI
{

    public partial class frmBangLuong : Form
    {
        private readonly BangLuongBLL _bll = new BangLuongBLL();
        private readonly NhanVienBLL _nvBll = new NhanVienBLL();

        public frmBangLuong()
        {
            InitializeComponent();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            var phongs = new List<PhongBan>
                { new PhongBan { MaPhong = null, TenPhong = "-- Tất cả phòng --" } };
            phongs.AddRange(_nvBll.GetAllPhongBan());
            cboPhong.DataSource = phongs;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";

            nudThang.Value = nudThangTK.Value = DateTime.Now.Month;
            nudNam.Value = nudNamTK.Value = DateTime.Now.Year;
        }

        //button  tính lương
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            int t = (int)nudThang.Value, n = (int)nudNam.Value;
            var r = MessageBox.Show(
                $"Tính lương tháng {t}/{n}?\n\n⚠️ Bảng lương tháng này sẽ được tính lại từ đầu.",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            btnTinhLuong.Enabled = false;
            btnTinhLuong.Text = "Đang tính...";
            Application.DoEvents();

            var (ok, msg) = _bll.TinhLuong(t, n);
            btnTinhLuong.Enabled = true;
            btnTinhLuong.Text = "Tính lương";

            MessageBox.Show(msg, ok ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) XemBangLuong();
        }

        //button xem bảng lương
        private void btnXem_Click(object sender, EventArgs e)
        {
            XemBangLuong();
        }

        private void XemBangLuong()
        {
            string mp = (cboPhong.SelectedItem as PhongBan)?.MaPhong;
            var list = _bll.GetByThangNam((int)nudThang.Value, (int)nudNam.Value, mp);

            dgvBangLuong.Columns.Clear();
            dgvBangLuong.AutoGenerateColumns = false;
            dgvBangLuong.DataSource = null;

            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaNV", HeaderText = "Mã NV", Width = 80 });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenPhong", HeaderText = "Phòng", Width = 120 });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayCongThucTe", HeaderText = "Ngày công", Width = 80, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LuongTheoNgayCong", HeaderText = "Lương ngày", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TongKhauTru", HeaderText = "Khấu trừ BH", Width = 115, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThueTNCN", HeaderText = "Thuế TNCN", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LuongThucNhan", HeaderText = "THỰC NHẬN", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });

            dgvBangLuong.DataSource = list;

            // Tổng quỹ lương
            decimal tong = 0;
            foreach (var bl in list) tong += bl.LuongThucNhan;
            lblTongLuong.Text = $"Tổng quỹ lương: {tong:N0} VNĐ   |   Số NV: {list.Count}";
        }

        //thống kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int t = (int)nudThangTK.Value, n = (int)nudNamTK.Value;

            // Quỹ lương theo phòng ban
            dgvQuyLuong.DataSource = _bll.ThongKeQuyLuong(t, n);

            // Top 5 lương cao nhất
            dgvTopLuong.DataSource = _bll.TopLuong(t, n, 5);
        }

        private void labelll_Click(object sender, EventArgs e)
        {

        }
    }
}
