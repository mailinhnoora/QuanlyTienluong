using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyLuong.Models;

namespace QuanLyLuong.DAL
{
    public class NhanVienDAL
    {
        public List<PhongBan> GetAllPhongBan()
        {
            var list = new List<PhongBan>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_GetAllPhongBan", conn)
                    { CommandType = CommandType.StoredProcedure };
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new PhongBan
                        {
                            MaPhong       = r["MaPhong"].ToString(),
                            TenPhong      = r["TenPhong"].ToString(),
                            SoDienThoai   = r["SoDienThoai"].ToString()
                        });
            }
            return list;
        }


        public List<ChucVu> GetAllChucVu()
        {
            var list = new List<ChucVu>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_GetAllChucVu", conn)
                    { CommandType = CommandType.StoredProcedure };
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new ChucVu
                        {
                            MaChucVu  = r["MaChucVu"].ToString(),
                            TenChucVu = r["TenChucVu"].ToString(),
                            HeSoLuong = Convert.ToDecimal(r["HeSoLuong"])
                        });
            }
            return list;
        }

        // ── LẤY TẤT CẢ NHÂN VIÊN (sp_GetAllNhanVien) ─────
        public List<NhanVien> GetAll()
        {
            var list = new List<NhanVien>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_GetAllNhanVien", conn)
                    { CommandType = CommandType.StoredProcedure };
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapFull(r));
            }
            return list;
        }

        // ── TÌM KIẾM (sp_TimKiemNhanVien) ─────────────────
        public List<NhanVien> TimKiem(string keyword, string maPhong = null)
        {
            var list = new List<NhanVien>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_TimKiemNhanVien", conn)
                    { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Keyword",
                    string.IsNullOrWhiteSpace(keyword) ? (object)DBNull.Value : keyword.Trim());
                cmd.Parameters.AddWithValue("@MaPhong",
                    string.IsNullOrWhiteSpace(maPhong) ? (object)DBNull.Value : maPhong);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapSearch(r));
            }
            return list;
        }

        // ── THÊM (sp_ThemNhanVien) — trả về 1/−1/−2 ──────
        public int Them(NhanVien nv)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_ThemNhanVien", conn)
                    { CommandType = CommandType.StoredProcedure };
                BindThemSua(cmd, nv);
                var pOut = new SqlParameter("@KetQua", SqlDbType.Int)
                    { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(pOut);
                
                cmd.ExecuteNonQuery();
                return (int)pOut.Value;
            }
        }

        // ── SỬA (sp_SuaNhanVien) ──────────────────────────
        public int Sua(NhanVien nv)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_SuaNhanVien", conn)
                    { CommandType = CommandType.StoredProcedure };
                BindThemSua(cmd, nv);
                var pOut = new SqlParameter("@KetQua", SqlDbType.Int)
                    { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                return (int)pOut.Value;
            }
        }

        // ── XÓA (sp_XoaNhanVien) ──────────────────────────
        public int Xoa(string maNV)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_XoaNhanVien", conn)
                    { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                var pOut = new SqlParameter("@KetQua", SqlDbType.Int)
                    { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                return (int)pOut.Value;
            }
        }

        // ── HELPER: bind tham số cho Thêm/Sửa ────────────
        private void BindThemSua(SqlCommand cmd, NhanVien nv)
        {
            cmd.Parameters.AddWithValue("@MaNV",        nv.MaNV);
            cmd.Parameters.AddWithValue("@HoTen",       nv.HoTen);
            cmd.Parameters.AddWithValue("@NgaySinh",    nv.NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh",    nv.GioiTinh);
            cmd.Parameters.AddWithValue("@CCCD",        string.IsNullOrWhiteSpace(nv.CCCD)   ? (object)DBNull.Value : nv.CCCD);
            cmd.Parameters.AddWithValue("@DiaChi",      string.IsNullOrWhiteSpace(nv.DiaChi) ? (object)DBNull.Value : nv.DiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", string.IsNullOrWhiteSpace(nv.SoDienThoai) ? (object)DBNull.Value : nv.SoDienThoai);
            cmd.Parameters.AddWithValue("@Email",       string.IsNullOrWhiteSpace(nv.Email)  ? (object)DBNull.Value : nv.Email);
            cmd.Parameters.AddWithValue("@MaPhong",     nv.MaPhong);
            cmd.Parameters.AddWithValue("@MaChucVu",    nv.MaChucVu);
            cmd.Parameters.AddWithValue("@NgayVaoLam",  nv.NgayVaoLam);
            cmd.Parameters.AddWithValue("@LuongCoBan",  nv.LuongCoBan);
        }

        // ── MAP đầy đủ (từ sp_GetAllNhanVien) ─────────────
        private NhanVien MapFull(SqlDataReader r) => new NhanVien
        {
            MaNV        = r["MaNV"].ToString(),
            HoTen       = r["HoTen"].ToString(),
            NgaySinh    = r["NgaySinh"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(r["NgaySinh"]),
            GioiTinh    = Convert.ToBoolean(r["GioiTinh"]),
            SoDienThoai = r["SoDienThoai"].ToString(),
            MaPhong     = r["MaPhong"].ToString(),
            TenPhong    = r["TenPhong"].ToString(),
            MaChucVu    = r["MaChucVu"].ToString(),
            TenChucVu   = r["TenChucVu"].ToString(),
            HeSoLuong   = Convert.ToDecimal(r["HeSoLuong"]),
            NgayVaoLam  = r["NgayVaoLam"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(r["NgayVaoLam"]),
            LuongCoBan  = Convert.ToDecimal(r["LuongCoBan"])
        };

        // ── MAP tìm kiếm (từ sp_TimKiemNhanVien) ──────────
        private NhanVien MapSearch(SqlDataReader r) => new NhanVien
        {
            MaNV        = r["MaNV"].ToString(),
            HoTen       = r["HoTen"].ToString(),
            NgaySinh    = r["NgaySinh"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(r["NgaySinh"]),
            GioiTinh    = Convert.ToBoolean(r["GioiTinh"]),
            SoDienThoai = r["SoDienThoai"].ToString(),
            MaPhong     = r["MaPhong"].ToString(),
            TenPhong    = r["TenPhong"].ToString(),
            MaChucVu    = r["MaChucVu"].ToString(),
            TenChucVu   = r["TenChucVu"].ToString(),
            LuongCoBan  = Convert.ToDecimal(r["LuongCoBan"])
        };
    }
}
