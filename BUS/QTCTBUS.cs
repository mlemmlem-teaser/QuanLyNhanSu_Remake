using System;
using System.Data;
using QuanLyNhanSu.DAL;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu.BUS
{
    /// <summary>Nghiệp vụ quá trình công tác: kiểm tra dữ liệu rồi gọi QTCTDAL.</summary>
    public static class QTCTBUS
    {
        public static DataTable GetAll()
        {
            return QTCTDAL.GetAll();
        }

        /// <summary>Lọc theo nhân viên và/hoặc phòng ban; tiêu chí null/rỗng được bỏ qua.</summary>
        public static DataTable TimKiem(string? maNV = null, string? maPhong = null)
        {
            return QTCTDAL.TimKiem(maNV, maPhong);
        }

        /// <summary>Mã gợi ý cho quá trình mới.</summary>
        public static string TaoMaMoi()
        {
            return QTCTDAL.MaMoi();
        }

        public static void KiemTraHopLe(QuaTrinhCongTacDTO q, bool themMoi)
        {
            KiemTra.BatBuoc(q.MaQTCT, "Mã quá trình công tác");
            KiemTra.DoDaiToiDa(q.MaQTCT, 10, "Mã quá trình công tác");
            KiemTra.ChonBatBuoc(q.MaNV, "nhân viên");
            KiemTra.ChonBatBuoc(q.MaPhong, "phòng ban");
            KiemTra.ChonBatBuoc(q.MaCV, "chức vụ");

            if (q.TuNgay == null)
                throw new NghiepVuException("Hãy nhập ngày bắt đầu công tác.");
            // Không có ngày kết thúc = đang công tác.
            KiemTra.KhoangNgay(q.TuNgay, q.DenNgay, "Ngày kết thúc phải sau hoặc bằng ngày bắt đầu.");

            if (themMoi && QTCTDAL.TonTai(q.MaQTCT.Trim()))
                throw new NghiepVuException("Mã quá trình công tác " + q.MaQTCT.Trim() + " đã tồn tại.");
        }

        public static void Insert(QuaTrinhCongTacDTO q)
        {
            KiemTraHopLe(q, true);
            q.MaQTCT = q.MaQTCT.Trim();
            QTCTDAL.Insert(q);
        }

        public static void Update(QuaTrinhCongTacDTO q)
        {
            KiemTraHopLe(q, false);
            q.MaQTCT = q.MaQTCT.Trim();
            QTCTDAL.Update(q);
        }

        public static void Delete(string maQTCT)
        {
            KiemTra.BatBuoc(maQTCT, "Mã quá trình công tác");
            QTCTDAL.Delete(maQTCT.Trim());
        }
    }
}
