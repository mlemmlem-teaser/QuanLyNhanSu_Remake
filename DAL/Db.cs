using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyNhanSu.DAL
{
    /// <summary>
    /// Kết nối SQL Server và các hàm gọi STORED PROCEDURE dùng chung cho mọi lớp DAL.
    /// Mọi truy vấn trong project đều đi qua procedure (xem QuanLyNhanSuProc.sql).
    /// </summary>
    public static class Db
    {
        // Sửa lại nếu SQL Server trên máy không phải .\SQLEXPRESS.
        public static string ConnectionString { get; set; } =
            @"Server=.\SQLEXPRESS;Database=QuanLyNhanSu;Integrated Security=True;TrustServerCertificate=True;";

        /// <summary>Tạo tham số; null được đổi thành DBNull.</summary>
        public static SqlParameter P(string name, object? value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }

        /// <summary>Chuỗi null/rỗng/chỉ có khoảng trắng -> null (bỏ qua tiêu chí lọc); còn lại cắt khoảng trắng hai đầu.</summary>
        public static string? Clean(string? value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }

        private static SqlCommand TaoLenh(SqlConnection conn, SqlTransaction? tran, string tenProc, SqlParameter[] thamSo)
        {
            SqlCommand cmd = new SqlCommand(tenProc, conn, tran);
            cmd.CommandType = CommandType.StoredProcedure;
            if (thamSo != null && thamSo.Length > 0) cmd.Parameters.AddRange(thamSo);
            return cmd;
        }

        /// <summary>Gọi procedure trả về bảng dữ liệu (SELECT).</summary>
        public static DataTable QueryProc(string tenProc, params SqlParameter[] thamSo)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = TaoLenh(conn, null, tenProc, thamSo))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        /// <summary>Gọi procedure thêm/sửa/xóa (không cần kết quả).</summary>
        public static int ExecuteProc(string tenProc, params SqlParameter[] thamSo)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = TaoLenh(conn, null, tenProc, thamSo))
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Gọi procedure trả về một giá trị (cột đầu của dòng đầu).</summary>
        public static object? ScalarProc(string tenProc, params SqlParameter[] thamSo)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = TaoLenh(conn, null, tenProc, thamSo))
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Chạy nhiều lệnh trong một giao dịch: thành công thì Commit, có lỗi thì Rollback rồi ném lại lỗi.
        /// Trong work, gọi ExecuteProc(conn, tran, ...) cho từng procedure.
        /// </summary>
        public static void RunTransaction(Action<SqlConnection, SqlTransaction> work)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        work(conn, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>Gọi procedure thêm/sửa/xóa bên trong giao dịch đang mở (dùng với RunTransaction).</summary>
        public static int ExecuteProc(SqlConnection conn, SqlTransaction tran, string tenProc, params SqlParameter[] thamSo)
        {
            using (SqlCommand cmd = TaoLenh(conn, tran, tenProc, thamSo))
            {
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
