using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyLuong.Models;

namespace QuanLyLuong.DAL
{
    public class TaiKhoanDAL
    {
     
        public ThongTinDangNhap DangNhap(string tenDangNhap, string matKhauRaw)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_DangNhap", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhauRaw",  matKhauRaw);

                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                        return new ThongTinDangNhap
                        {
                            MaTK        = Convert.ToInt32(r["MaTK"]),
                            MaNV        = r["MaNV"].ToString(),
                            HoTen       = r["HoTen"].ToString(),
                            TenDangNhap = r["TenDangNhap"].ToString(),
                            VaiTro      = r["VaiTro"].ToString(),
                            MaPhong     = r["MaPhong"].ToString(),
                            MaChucVu    = r["MaChucVu"].ToString()
                        };
                }
                return null;
            }
        }

        // ── ĐỔI MẬT KHẨU (gọi sp_DoiMatKhau) ────────────
        // Trả về: 1=OK, -1=mật khẩu cũ sai
        public int DoiMatKhau(string maNV, string cuRaw, string moiRaw)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_DoiMatKhau", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@MaNV",          maNV);
                cmd.Parameters.AddWithValue("@MatKhauCuRaw",  cuRaw);
                cmd.Parameters.AddWithValue("@MatKhauMoiRaw", moiRaw);
                var pOut = new SqlParameter("@KetQua", SqlDbType.Int)
                    { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                return (int)pOut.Value;
            }
        }

        // ── LẤY TẤT CẢ TÀI KHOẢN ─────────────────────────
        public List<TaiKhoan> GetAll()
        {
            var list = new List<TaiKhoan>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT tk.MaTK, tk.MaNV, nv.HoTen,
                                      tk.TenDangNhap, tk.VaiTro
                               FROM TaiKhoan tk
                               JOIN NhanVien nv ON tk.MaNV = nv.MaNV
                               ORDER BY tk.MaTK";
                using (var r = new SqlCommand(sql, conn).ExecuteReader())
                    while (r.Read())
                        list.Add(new TaiKhoan
                        {
                            MaTK        = Convert.ToInt32(r["MaTK"]),
                            MaNV        = r["MaNV"].ToString(),
                            HoTen       = r["HoTen"].ToString(),
                            TenDangNhap = r["TenDangNhap"].ToString(),
                            VaiTro      = r["VaiTro"].ToString()
                        });
            }
            return list;
        }

        // ── THÊM TÀI KHOẢN (hash trong SQL) ───────────────
        public bool Them(string maNV, string tenDangNhap, string matKhauRaw, string vaiTro)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO TaiKhoan(MaNV, TenDangNhap, MatKhau, VaiTro)
                               VALUES(@maNV, @tdn,
                                      CONVERT(VARCHAR(256),HASHBYTES('SHA2_256',@mk),2),
                                      @vaiTro)";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maNV",   maNV);
                cmd.Parameters.AddWithValue("@tdn",    tenDangNhap);
                cmd.Parameters.AddWithValue("@mk",     matKhauRaw);
                cmd.Parameters.AddWithValue("@vaiTro", vaiTro);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ── SỬA VAI TRÒ ───────────────────────────────────
        public bool SuaVaiTro(int maTK, string vaiTro)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "UPDATE TaiKhoan SET VaiTro=@vt WHERE MaTK=@id", conn);
                cmd.Parameters.AddWithValue("@vt", vaiTro);
                cmd.Parameters.AddWithValue("@id", maTK);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ── XÓA TÀI KHOẢN ─────────────────────────────────
        public bool Xoa(int maTK)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "DELETE FROM TaiKhoan WHERE MaTK=@id", conn);
                cmd.Parameters.AddWithValue("@id", maTK);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool TonTaiTenDangNhap(string tdn)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@tdn", conn);
                cmd.Parameters.AddWithValue("@tdn", tdn);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}
