using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyLuong.Models;

namespace QuanLyLuong.DAL
{
    public class BangLuongDAL
    {
        // ── TÍNH LƯƠNG (sp_TinhLuong) ─────────────────────
        // SP trả về: KetQua (1/-1), ThongBao
        public (bool ok, string msg) TinhLuong(int thang, int nam)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_TinhLuong", conn)
                    { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam",   nam);
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        int ketQua = Convert.ToInt32(r["KetQua"]);
                        string thongBao = r["ThongBao"].ToString();
                        return (ketQua == 1, thongBao);
                    }
                }
                return (false, "Không có kết quả trả về.");
            }
        }

        // ── XEM BẢNG LƯƠNG (sp_GetBangLuong) ─────────────
        public List<BangLuong> GetByThangNam(int thang, int nam, string maPhong = null)
        {
            var list = new List<BangLuong>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_GetBangLuong", conn)
                    { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Thang",   thang);
                cmd.Parameters.AddWithValue("@Nam",     nam);
                cmd.Parameters.AddWithValue("@MaPhong",
                    string.IsNullOrWhiteSpace(maPhong) ? (object)DBNull.Value : maPhong);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapBL(r));
            }
            return list;
        }

        // ── BẢNG LƯƠNG 1 NHÂN VIÊN (sp_GetBangLuongNhanVien) ──
        public List<BangLuong> GetByNhanVien(string maNV, int? thang = null, int? nam = null)
        {
            var list = new List<BangLuong>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_GetBangLuongNhanVien", conn)
                    { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@MaNV",  maNV);
                cmd.Parameters.AddWithValue("@Thang", thang.HasValue ? (object)thang.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Nam",   nam.HasValue   ? (object)nam.Value   : DBNull.Value);
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new BangLuong
                        {
                            MaBangLuong       = Convert.ToInt32(r["MaBangLuong"]),
                            MaNV              = r["MaNV"].ToString(),
                            HoTen             = r["HoTen"].ToString(),
                            Thang             = Convert.ToInt32(r["Thang"]),
                            Nam               = Convert.ToInt32(r["Nam"]),
                            LuongCoBan        = Convert.ToDecimal(r["LuongCoBan"]),
                            HeSoLuong         = Convert.ToDecimal(r["HeSoLuong"]),
                            NgayCongThucTe    = Convert.ToDecimal(r["NgayCongThucTe"]),
                            LuongTheoNgayCong = Convert.ToDecimal(r["LuongTheoNgayCong"]),
                            TongKhauTru       = Convert.ToDecimal(r["TongKhauTru"]),
                            LuongThucNhan     = Convert.ToDecimal(r["LuongThucNhan"])
                        });
            }
            return list;
        }

        // ── THỐNG KÊ QUỸ LƯƠNG (sp_ThongKe_QuyLuong) ─────
        public DataTable ThongKeQuyLuong(int thang, int nam)
        {
            var dt = new DataTable();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_ThongKe_QuyLuong", conn)
                    { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam",   nam);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        // ── TOP LƯƠNG CAO NHẤT (sp_ThongKe_TopLuong) ─────
        public DataTable TopLuong(int thang, int nam, int top = 5)
        {
            var dt = new DataTable();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_ThongKe_TopLuong", conn)
                    { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam",   nam);
                cmd.Parameters.AddWithValue("@Top",   top);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        // ── HELPER MAP ────────────────────────────────────
        private BangLuong MapBL(SqlDataReader r) => new BangLuong
        {
            MaBangLuong       = Convert.ToInt32(r["MaBangLuong"]),
            MaNV              = r["MaNV"].ToString(),
            HoTen             = r["HoTen"].ToString(),
            TenPhong          = r["TenPhong"].ToString(),
            TenChucVu         = r["TenChucVu"].ToString(),
            Thang             = Convert.ToInt32(r["Thang"]),
            Nam               = Convert.ToInt32(r["Nam"]),
            LuongCoBan        = Convert.ToDecimal(r["LuongCoBan"]),
            HeSoLuong         = Convert.ToDecimal(r["HeSoLuong"]),
            NgayCongChuanChi  = Convert.ToDecimal(r["NgayCongChuanChi"]),
            NgayCongThucTe    = Convert.ToDecimal(r["NgayCongThucTe"]),
            LuongTheoNgayCong = Convert.ToDecimal(r["LuongTheoNgayCong"]),
            BHXH_NV           = Convert.ToDecimal(r["BHXH_NV"]),
            BHYT_NV           = Convert.ToDecimal(r["BHYT_NV"]),
            BHTN_NV           = Convert.ToDecimal(r["BHTN_NV"]),
            TongKhauTru       = Convert.ToDecimal(r["TongKhauTru"]),
            ThueTNCN          = Convert.ToDecimal(r["ThueTNCN"]),
            LuongThucNhan     = Convert.ToDecimal(r["LuongThucNhan"])
        };
    }
}
