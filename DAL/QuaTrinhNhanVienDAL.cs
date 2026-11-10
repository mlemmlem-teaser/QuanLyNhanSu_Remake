using System.Data;

namespace QuanLyNhanSu.DAL
{
    /// <summary>Lấy toàn bộ quá trình đào tạo / công tác của MỘT nhân viên (dùng lại procedure lọc theo nhân viên).</summary>
    public static class QuaTrinhNhanVienDAL
    {
        public static DataTable GetQTDT(string maNV)
        {
            return QTDTDAL.TimKiem(maNV);
        }

        public static DataTable GetQTCT(string maNV)
        {
            return QTCTDAL.TimKiem(maNV);
        }
    }
}
