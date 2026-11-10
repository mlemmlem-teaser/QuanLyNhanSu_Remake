using System;
using System.Data;
using QuanLyNhanSu.DAL;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu.BUS
{
    /// <summary>Nghiệp vụ quá trình đào tạo: kiểm tra dữ liệu rồi gọi QTDTDAL.</summary>
    public static class QTDTBUS
    {
        public static DataTable GetAll()
        {
            return QTDTDAL.GetAll();
        }

        /// <summary>Lọc theo nhân viên, trường, hình thức và khoảng ngày; tiêu chí null/rỗng được bỏ qua.</summary>
        public static DataTable TimKiem(string? maNV = null, string? maTruong = null, string? maHT = null,
            DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            KiemTra.KhoangNgay(tuNgay, denNgay, "\"Từ ngày\" không được lớn hơn \"Đến ngày\".");
            return QTDTDAL.TimKiem(maNV, maTruong, maHT, tuNgay?.Date, denNgay?.Date);
        }

        /// <summary>Mã gợi ý cho quá trình mới.</summary>
        public static string TaoMaMoi()
        {
            return QTDTDAL.MaMoi();
        }

        public static void KiemTraHopLe(QuaTrinhDaoTaoDTO q, bool themMoi)
        {
            KiemTra.BatBuoc(q.MaQTDT, "Mã quá trình đào tạo");
            KiemTra.DoDaiToiDa(q.MaQTDT, 10, "Mã quá trình đào tạo");
            KiemTra.ChonBatBuoc(q.MaNV, "nhân viên");
            KiemTra.ChonBatBuoc(q.MaTruong, "trường đào tạo");
            KiemTra.ChonBatBuoc(q.MaHT, "hình thức đào tạo");
            KiemTra.ChonBatBuoc(q.MaNganh, "ngành đào tạo");
            // Xếp loại có thể để trống (quá trình chưa kết thúc thì chưa có xếp loại).

            if (q.TuNgay == null)
                throw new NghiepVuException("Hãy nhập ngày bắt đầu đào tạo.");
            KiemTra.KhoangNgay(q.TuNgay, q.DenNgay, "Ngày kết thúc phải sau hoặc bằng ngày bắt đầu.");

            if (themMoi && QTDTDAL.TonTai(q.MaQTDT.Trim()))
                throw new NghiepVuException("Mã quá trình đào tạo " + q.MaQTDT.Trim() + " đã tồn tại.");
        }

        public static void Insert(QuaTrinhDaoTaoDTO q)
        {
            KiemTraHopLe(q, true);
            q.MaQTDT = q.MaQTDT.Trim();
            QTDTDAL.Insert(q);
        }

        public static void Update(QuaTrinhDaoTaoDTO q)
        {
            KiemTraHopLe(q, false);
            q.MaQTDT = q.MaQTDT.Trim();
            QTDTDAL.Update(q);
        }

        public static void Delete(string maQTDT)
        {
            KiemTra.BatBuoc(maQTDT, "Mã quá trình đào tạo");
            QTDTDAL.Delete(maQTDT.Trim());
        }
    }
}
