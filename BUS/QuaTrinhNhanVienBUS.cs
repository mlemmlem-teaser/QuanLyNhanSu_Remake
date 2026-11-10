using System.Data;
using QuanLyNhanSu.DAL;

namespace QuanLyNhanSu.BUS
{
    /// <summary>Xem toàn bộ quá trình đào tạo / công tác của một nhân viên.</summary>
    public static class QuaTrinhNhanVienBUS
    {
        public static DataTable GetQTDT(string maNV)
        {
            KiemTra.ChonBatBuoc(maNV, "nhân viên");
            return QuaTrinhNhanVienDAL.GetQTDT(maNV.Trim());
        }

        public static DataTable GetQTCT(string maNV)
        {
            KiemTra.ChonBatBuoc(maNV, "nhân viên");
            return QuaTrinhNhanVienDAL.GetQTCT(maNV.Trim());
        }
    }
}
