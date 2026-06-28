using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyLuong.Models;

namespace QuanLyLuong.DAL
{
    public class ChamCongDAL
    {
        // ── LẤY CHẤM CÔNG (sp_GetChamCong) ───────────────
        public List<ChamCong> GetByThangNam(int thang, int nam)
        {
            var list = new List<ChamCong>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("sp_GetChamCong", conn)
                    { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam",   nam);
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new ChamCong
                        {
                            MaChamCong        = Convert.ToInt32(r["MaChamCong"]),
                            MaNV              = r["MaNV"].ToString(),
                            HoTen             = r["HoTen"].ToString(),
                            TenPhong          = r["TenPhong"].ToString(),
                            TenChucVu         = r["TenChucVu"].ToString(),
                            Thang             = Convert.ToInt32(r["Thang"]),
                            Nam               = Convert.ToInt32(r["Nam"]),
                            NgayCongChuanChi  = Convert.ToDecimal(r["NgayCongChuanChi"]),
                            NgayCongThucTe    = Convert.ToDecimal(r["NgayCongThucTe"]),
                            NgayNghiPhep      = Convert.ToDecimal(r["NgayNghiPhep"]),
                            NgayNghiKhongPhep = Convert.ToDecimal(r["NgayNghiKhongPhep"])
                        });
            }
            return list;
        }

        // ── LƯU CHẤM CÔNG (sp_LuuChamCong) ───────────────
        // SP dùng MERGE: tự thêm mới hoặc cập nhật
        public bool Luu(string maNV, int thang, int nam,
                decimal chuanChi, decimal thucTe,
                decimal nghiPhep, decimal nghiKhongPhep)
{
    if (string.IsNullOrEmpty(maNV)) return false;

    using (var conn = DBConnection.GetConnection())
    {
        conn.Open();
        var cmd = new SqlCommand("sp_LuuChamCong", conn)
            { CommandType = CommandType.StoredProcedure };
        cmd.Parameters.AddWithValue("@MaNV",              maNV);
        cmd.Parameters.AddWithValue("@Thang",             thang);
        cmd.Parameters.AddWithValue("@Nam",               nam);
        cmd.Parameters.AddWithValue("@NgayCongChuanChi",  chuanChi);
        cmd.Parameters.AddWithValue("@NgayCongThucTe",    thucTe);
        cmd.Parameters.AddWithValue("@NgayNghiPhep",      nghiPhep);
        cmd.Parameters.AddWithValue("@NgayNghiKhongPhep", nghiKhongPhep);
        cmd.ExecuteNonQuery();
        return true; 
    }
}

        // ── XÓA CHẤM CÔNG ─────────────────────────────────
        public bool Xoa(int maChamCong)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "DELETE FROM ChamCong WHERE MaChamCong=@id", conn);
                cmd.Parameters.AddWithValue("@id", maChamCong);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ── NHÂN VIÊN CHƯA CHẤM CÔNG THÁNG NÀY ──────────
        public List<NhanVien> GetNVChuaChamCong(int thang, int nam)
        {
            var list = new List<NhanVien>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT nv.MaNV, nv.HoTen, pb.TenPhong
                               FROM NhanVien nv
                               JOIN PhongBan pb ON nv.MaPhong = pb.MaPhong
                               WHERE nv.MaNV NOT IN (
                                   SELECT MaNV FROM ChamCong
                                   WHERE Thang=@Thang AND Nam=@Nam)
                               ORDER BY nv.MaNV";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam",   nam);
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new NhanVien
                        {
                            MaNV     = r["MaNV"].ToString(),
                            HoTen    = r["HoTen"].ToString(),
                            TenPhong = r["TenPhong"].ToString()
                        });
            }
            return list;
        }
    }
}
