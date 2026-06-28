using System;
using System.Collections.Generic;
using System.Data;
using QuanLyLuong.DAL;
using QuanLyLuong.Models;

namespace QuanLyLuong.BLL
{
    // ══════════════════════════════════════════════════════
    //  TAIKHOAN BLL
    // ══════════════════════════════════════════════════════
    public class TaiKhoanBLL
    {
        private readonly TaiKhoanDAL _dal = new TaiKhoanDAL();

        public ThongTinDangNhap DangNhap(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                throw new ArgumentException("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
            return _dal.DangNhap(user.Trim(), pass);
        }

        public (bool ok, string msg) DoiMatKhau(
            string maNV, string cu, string moi, string nhapLai)
        {
            if (string.IsNullOrWhiteSpace(cu))   return (false, "Nhập mật khẩu cũ.");
            if (string.IsNullOrWhiteSpace(moi))  return (false, "Nhập mật khẩu mới.");
            if (moi.Length < 6)                  return (false, "Mật khẩu mới phải ≥ 6 ký tự.");
            if (moi != nhapLai)                  return (false, "Nhập lại mật khẩu không khớp.");
            int r = _dal.DoiMatKhau(maNV, cu, moi);
            return r == 1 ? (true, "Đổi mật khẩu thành công!") : (false, "Mật khẩu cũ không đúng.");
        }

        public List<TaiKhoan> GetAll() => _dal.GetAll();

        public (bool ok, string msg) Them(
            string maNV, string tdn, string mk, string vaiTro)
        {
            if (string.IsNullOrWhiteSpace(maNV)) return (false, "Vui lòng chọn nhân viên.");
            if (string.IsNullOrWhiteSpace(tdn))  return (false, "Nhập tên đăng nhập.");
            if (string.IsNullOrWhiteSpace(mk))   return (false, "Nhập mật khẩu.");
            if (mk.Length < 6)                   return (false, "Mật khẩu phải ≥ 6 ký tự.");
            if (_dal.TonTaiTenDangNhap(tdn))     return (false, "Tên đăng nhập đã tồn tại.");
            return _dal.Them(maNV, tdn, mk, vaiTro)
                ? (true, "Thêm tài khoản thành công!")
                : (false, "Thêm tài khoản thất bại.");
        }

        public (bool ok, string msg) SuaVaiTro(int maTK, string vaiTro)
            => _dal.SuaVaiTro(maTK, vaiTro)
                ? (true, "Cập nhật vai trò thành công!")
                : (false, "Cập nhật thất bại.");

        public (bool ok, string msg) Xoa(int maTK)
            => _dal.Xoa(maTK)
                ? (true, "Xóa tài khoản thành công!")
                : (false, "Xóa thất bại.");
    }

    // ══════════════════════════════════════════════════════
    //  NHANVIEN BLL
    // ══════════════════════════════════════════════════════
    public class NhanVienBLL
    {
        private readonly NhanVienDAL _dal = new NhanVienDAL();

        public List<PhongBan> GetAllPhongBan() => _dal.GetAllPhongBan();
        public List<ChucVu>   GetAllChucVu()   => _dal.GetAllChucVu();
        public List<NhanVien> GetAll()          => _dal.GetAll();

        public List<NhanVien> TimKiem(string kw, string maPhong = null)
            => _dal.TimKiem(kw, maPhong);

        public (bool ok, string msg) Them(NhanVien nv)
        {
            string err = Validate(nv); if (err != null) return (false, err);
            int r = _dal.Them(nv);
            if (r ==  1) return (true,  "Thêm nhân viên thành công!");
            if (r == -1) return (false, "Mã nhân viên đã tồn tại.");
            if (r == -2) return (false, "Số CCCD đã tồn tại.");
            return (false, "Thêm thất bại.");
        }

        public (bool ok, string msg) Sua(NhanVien nv)
        {
            string err = Validate(nv); if (err != null) return (false, err);
            int r = _dal.Sua(nv);
            return r == 1 ? (true, "Cập nhật thành công!") : (false, "Không tìm thấy nhân viên.");
        }

        public (bool ok, string msg) Xoa(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV)) return (false, "Chưa chọn nhân viên.");
            int r = _dal.Xoa(maNV);
            return r == 1 ? (true, "Xóa nhân viên thành công!") : (false, "Xóa thất bại.");
        }

        private string Validate(NhanVien nv)
        {
            if (string.IsNullOrWhiteSpace(nv.MaNV))     return "Mã nhân viên không được trống.";
            if (string.IsNullOrWhiteSpace(nv.HoTen))    return "Họ tên không được trống.";
            if (string.IsNullOrWhiteSpace(nv.MaPhong))  return "Vui lòng chọn phòng ban.";
            if (string.IsNullOrWhiteSpace(nv.MaChucVu)) return "Vui lòng chọn chức vụ.";
            if (nv.LuongCoBan < 0)                      return "Lương cơ bản không hợp lệ.";
            return null;
        }
    }

    // ══════════════════════════════════════════════════════
    //  CHAMCONG BLL
    // ══════════════════════════════════════════════════════
    public class ChamCongBLL
    {
        private readonly ChamCongDAL _dal = new ChamCongDAL();

        public List<ChamCong>  GetByThangNam(int t, int n)
            => _dal.GetByThangNam(t, n);

        public List<NhanVien> GetNVChuaChamCong(int t, int n)
            => _dal.GetNVChuaChamCong(t, n);

        public (bool ok, string msg) Luu(string maNV, int thang, int nam,
            decimal chuanChi, decimal thucTe, decimal nghiPhep, decimal nghiKhongPhep)
        {
            if (string.IsNullOrEmpty(maNV))
        return (false, "Vui lòng chọn nhân viên!");
            if (thucTe < 0 || thucTe > 31)       return (false, "Ngày công thực tế phải từ 0–31.");
            if (chuanChi <= 0)                    return (false, "Ngày công chuẩn phải > 0.");
            return _dal.Luu(maNV, thang, nam, chuanChi, thucTe, nghiPhep, nghiKhongPhep)
                ? (true, "Lưu chấm công thành công!")
                : (false, "Lưu chấm công thất bại.");
        }

        public (bool ok, string msg) Xoa(int maChamCong)
            => _dal.Xoa(maChamCong)
                ? (true, "Xóa chấm công thành công!")
                : (false, "Xóa thất bại.");
    }

    // ══════════════════════════════════════════════════════
    //  BANGLUONG BLL
    // ══════════════════════════════════════════════════════
    public class BangLuongBLL
    {
        private readonly BangLuongDAL _dal = new BangLuongDAL();

        public (bool ok, string msg) TinhLuong(int thang, int nam)
        {
            if (thang < 1 || thang > 12) return (false, "Tháng phải từ 1–12.");
            if (nam < 2000)              return (false, "Năm không hợp lệ.");
            try   { return _dal.TinhLuong(thang, nam); }
            catch (Exception ex) { return (false, "Lỗi: " + ex.Message); }
        }

        public List<BangLuong> GetByThangNam(int t, int n, string mp = null)
            => _dal.GetByThangNam(t, n, mp);

        public List<BangLuong> GetByNhanVien(string maNV)
            => _dal.GetByNhanVien(maNV);

        public DataTable ThongKeQuyLuong(int t, int n)
            => _dal.ThongKeQuyLuong(t, n);

        public DataTable TopLuong(int t, int n, int top = 5)
            => _dal.TopLuong(t, n, top);
    }
}
