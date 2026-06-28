using System;
namespace QuanLyLuong.Models
{
    public class PhongBan
    {
        public string MaPhong  { get; set; }
        public string TenPhong { get; set; }
        public string SoDienThoai { get; set; }
        public override string ToString() => TenPhong;
    }

    public class ChucVu
    {
        public string MaChucVu  { get; set; }
        public string TenChucVu { get; set; }
        public decimal HeSoLuong { get; set; }
        public override string ToString() => TenChucVu;
    }

    public class NhanVien
    {
        public string   MaNV        { get; set; }
        public string   HoTen       { get; set; }
        public DateTime NgaySinh    { get; set; }
        public bool     GioiTinh    { get; set; }   // true = Nam
        public string   CCCD        { get; set; }
        public string   DiaChi      { get; set; }
        public string   SoDienThoai { get; set; }
        public string   Email       { get; set; }
        public string   MaPhong     { get; set; }
        public string   TenPhong    { get; set; }
        public string   MaChucVu    { get; set; }
        public string   TenChucVu   { get; set; }
        public decimal  HeSoLuong   { get; set; }
        public DateTime NgayVaoLam  { get; set; }
        public decimal  LuongCoBan  { get; set; }
        // Computed property cho hiển thị
        public string GioiTinhText => GioiTinh ? "Nam" : "Nữ";
    }

    public class TaiKhoan
    {
        public int    MaTK        { get; set; }
        public string MaNV        { get; set; }
        public string HoTen       { get; set; }
        public string TenDangNhap { get; set; }
        public string VaiTro      { get; set; }
    }

    // Kết quả trả về khi đăng nhập thành công
    public class ThongTinDangNhap
    {
        public int    MaTK        { get; set; }
        public string MaNV        { get; set; }
        public string HoTen       { get; set; }
        public string TenDangNhap { get; set; }
        public string VaiTro      { get; set; }
        public string MaPhong     { get; set; }
        public string MaChucVu    { get; set; }
    }

    public class ChamCong
    {
        public int     MaChamCong        { get; set; }
        public string  MaNV              { get; set; }
        public string  HoTen             { get; set; }
        public string  TenPhong          { get; set; }
        public string  TenChucVu         { get; set; }
        public int     Thang             { get; set; }
        public int     Nam               { get; set; }
        public decimal NgayCongChuanChi  { get; set; }
        public decimal NgayCongThucTe    { get; set; }
        public decimal NgayNghiPhep      { get; set; }
        public decimal NgayNghiKhongPhep { get; set; }
    }

    public class BangLuong
    {
        public int     MaBangLuong       { get; set; }
        public string  MaNV              { get; set; }
        public string  HoTen             { get; set; }
        public string  TenPhong          { get; set; }
        public string  TenChucVu         { get; set; }
        public int     Thang             { get; set; }
        public int     Nam               { get; set; }
        public decimal LuongCoBan        { get; set; }
        public decimal HeSoLuong         { get; set; }
        public decimal NgayCongChuanChi  { get; set; }
        public decimal NgayCongThucTe    { get; set; }
        public decimal LuongTheoNgayCong { get; set; }
        public decimal PhuCap            { get; set; }
        public decimal BHXH_NV           { get; set; }
        public decimal BHYT_NV           { get; set; }
        public decimal BHTN_NV           { get; set; }
        public decimal TongKhauTru       { get; set; }
        public decimal ThueTNCN          { get; set; }
        public decimal LuongThucNhan     { get; set; }
    }
}
