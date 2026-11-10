using System.Data;
using QuanLyNhanSu.DAL;

namespace QuanLyNhanSu.BUS
{
    /// <summary>Các báo cáo: kiểm tra tiêu chí rồi gọi BaoCaoDAL.</summary>
    public static class BaoCaoBUS
    {
        public static DataTable BaoCaoQTDT(string? maNV = null, string? maTruong = null, string? maNganh = null)
        {
            return BaoCaoDAL.BaoCaoQTDT(maNV, maTruong, maNganh);
        }

        public static DataTable BaoCaoQTCT(string? maNV = null, string? maPhong = null)
        {
            return BaoCaoDAL.BaoCaoQTCT(maNV, maPhong);
        }

        /// <summary>Danh sách nhân viên có ĐỒNG THỜI ngoại ngữ và chuyên môn đã chọn (bắt buộc chọn cả hai).</summary>
        public static DataTable BaoCaoNhanVienTheoNgoaiNguChuyenMon(string? maNN, string? maCM)
        {
            KiemTra.ChonBatBuoc(maNN, "ngoại ngữ");
            KiemTra.ChonBatBuoc(maCM, "chuyên môn");
            return BaoCaoDAL.BaoCaoNhanVienTheoNgoaiNguChuyenMon(maNN!.Trim(), maCM!.Trim());
        }

        /// <summary>Quá trình đào tạo đã bắt đầu và chưa qua ngày kết thúc (hoặc chưa có ngày kết thúc).</summary>
        public static DataTable BaoCaoQTDTChuaKetThuc()
        {
            return BaoCaoDAL.BaoCaoQTDTChuaKetThuc();
        }
    }
}
