using System;
using System.Data;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu.DAL
{
    /// <summary>Truy cập quá trình đào tạo (bảng QTDT) qua procedure usp_QTDT_*.</summary>
    public static class QTDTDAL
    {
        public static DataTable GetAll()
        {
            return Db.QueryProc("usp_QTDT_GetAll");
        }

        /// <summary>Lọc theo nhân viên, trường, hình thức và khoảng ngày; null/rỗng = bỏ qua tiêu chí.</summary>
        public static DataTable TimKiem(string? maNV = null, string? maTruong = null, string? maHT = null,
            DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            return Db.QueryProc("usp_QTDT_TimKiem",
                Db.P("@MaNV", Db.Clean(maNV)),
                Db.P("@MaTruong", Db.Clean(maTruong)),
                Db.P("@MaHT", Db.Clean(maHT)),
                Db.P("@TuNgay", tuNgay),
                Db.P("@DenNgay", denNgay));
        }

        public static bool TonTai(string maQTDT)
        {
            return Convert.ToInt32(Db.ScalarProc("usp_QTDT_TonTai", Db.P("@MaQTDT", maQTDT))) > 0;
        }

        /// <summary>Mã gợi ý cho quá trình mới (mã số lớn nhất + 1).</summary>
        public static string MaMoi()
        {
            return Convert.ToString(Db.ScalarProc("usp_QTDT_MaMoi")) ?? "1";
        }

        public static int Insert(QuaTrinhDaoTaoDTO q)
        {
            return Db.ExecuteProc("usp_QTDT_Insert", ThamSo(q));
        }

        public static int Update(QuaTrinhDaoTaoDTO q)
        {
            return Db.ExecuteProc("usp_QTDT_Update", ThamSo(q));
        }

        public static int Delete(string maQTDT)
        {
            return Db.ExecuteProc("usp_QTDT_Delete", Db.P("@MaQTDT", maQTDT));
        }

        private static Microsoft.Data.SqlClient.SqlParameter[] ThamSo(QuaTrinhDaoTaoDTO q)
        {
            return new Microsoft.Data.SqlClient.SqlParameter[]
            {
                Db.P("@MaQTDT", q.MaQTDT),
                Db.P("@MaNV", q.MaNV),
                Db.P("@TuNgay", q.TuNgay),
                Db.P("@DenNgay", q.DenNgay),
                Db.P("@MaTruong", Db.Clean(q.MaTruong)),
                Db.P("@MaHT", Db.Clean(q.MaHT)),
                Db.P("@MaNganh", Db.Clean(q.MaNganh)),
                Db.P("@MaXL", Db.Clean(q.MaXL))
            };
        }
    }
}
