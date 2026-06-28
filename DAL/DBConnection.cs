using System.Data.SqlClient;

namespace QuanLyLuong.DAL
{
    public static class DBConnection
    {

        private static readonly string _conn =
            @"Server=DESKTOP-HEPPLUF\SQLEXPRESS;Database=QuanLyLuong;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_conn);
        }
    }
}
