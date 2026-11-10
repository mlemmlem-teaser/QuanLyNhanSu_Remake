using System.Data;

namespace QuanLyNhanSu.DAL
{
    /// <summary>Các báo cáo, qua procedure usp_BaoCao_*.</summary>
    public static class BaoCaoDAL
    {
        public static DataTable BaoCaoQTDT(string? maNV = null, string? maTruong = null, string? maNganh = null)
        {
            return Db.QueryProc("usp_BaoCao_QTDT",
                Db.P("@MaNV", Db.Clean(maNV)),
                Db.P("@MaTruong", Db.Clean(maTruong)),
                Db.P("@MaNganh", Db.Clean(maNganh)));
        }

        public static DataTable BaoCaoQTCT(string? maNV = null, string? maPhong = null)
        {
            return Db.QueryProc("usp_BaoCao_QTCT",
                Db.P("@MaNV", Db.Clean(maNV)),
                Db.P("@MaPhong", Db.Clean(maPhong)));
        }

        public static DataTable BaoCaoNhanVienTheoNgoaiNguChuyenMon(string maNN, string maCM)
        {
            return Db.QueryProc("usp_BaoCao_NhanVienTheoNgoaiNguChuyenMon",
                Db.P("@MaNN", maNN), Db.P("@MaCM", maCM));
        }

        public static DataTable BaoCaoQTDTChuaKetThuc()
        {
            return Db.QueryProc("usp_BaoCao_QTDTChuaKetThuc");
        }
    }
}
