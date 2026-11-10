using System;
using System.Data;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu.DAL
{
    /// <summary>Truy cập quá trình công tác (bảng QTCT) qua procedure usp_QTCT_*.</summary>
    public static class QTCTDAL
    {
        public static DataTable GetAll()
        {
            return Db.QueryProc("usp_QTCT_GetAll");
        }

        /// <summary>Lọc theo nhân viên và/hoặc phòng ban; null/rỗng = bỏ qua tiêu chí.</summary>
        public static DataTable TimKiem(string? maNV = null, string? maPhong = null)
        {
            return Db.QueryProc("usp_QTCT_TimKiem",
                Db.P("@MaNV", Db.Clean(maNV)),
                Db.P("@MaPhong", Db.Clean(maPhong)));
        }

        public static bool TonTai(string maQTCT)
        {
            return Convert.ToInt32(Db.ScalarProc("usp_QTCT_TonTai", Db.P("@MaQTCT", maQTCT))) > 0;
        }

        /// <summary>Mã gợi ý cho quá trình mới (mã số lớn nhất + 1).</summary>
        public static string MaMoi()
        {
            return Convert.ToString(Db.ScalarProc("usp_QTCT_MaMoi")) ?? "1";
        }

        public static int Insert(QuaTrinhCongTacDTO q)
        {
            return Db.ExecuteProc("usp_QTCT_Insert", ThamSo(q));
        }

        public static int Update(QuaTrinhCongTacDTO q)
        {
            return Db.ExecuteProc("usp_QTCT_Update", ThamSo(q));
        }

        public static int Delete(string maQTCT)
        {
            return Db.ExecuteProc("usp_QTCT_Delete", Db.P("@MaQTCT", maQTCT));
        }

        private static Microsoft.Data.SqlClient.SqlParameter[] ThamSo(QuaTrinhCongTacDTO q)
        {
            return new Microsoft.Data.SqlClient.SqlParameter[]
            {
                Db.P("@MaQTCT", q.MaQTCT),
                Db.P("@MaNV", q.MaNV),
                Db.P("@TuNgay", q.TuNgay),
                Db.P("@DenNgay", q.DenNgay),
                Db.P("@MaPhong", Db.Clean(q.MaPhong)),
                Db.P("@MaCV", Db.Clean(q.MaCV))
            };
        }
    }
}
