using System;

namespace QuanLyNhanSu.BUS
{
    /// <summary>Các hàm kiểm tra dùng chung cho các lớp BUS; vi phạm thì ném NghiepVuException.</summary>
    internal static class KiemTra
    {
        public static void BatBuoc(string? giaTri, string tenTruong)
        {
            if (string.IsNullOrWhiteSpace(giaTri))
                throw new NghiepVuException(tenTruong + " không được để trống.");
        }

        public static void ChonBatBuoc(string? ma, string tenTruong)
        {
            if (string.IsNullOrWhiteSpace(ma))
                throw new NghiepVuException("Hãy chọn " + tenTruong + ".");
        }

        public static void DoDaiToiDa(string? giaTri, int toiDa, string tenTruong)
        {
            if (giaTri != null && giaTri.Trim().Length > toiDa)
                throw new NghiepVuException(tenTruong + " không được dài quá " + toiDa + " ký tự.");
        }

        public static void KhoangNgay(DateTime? tuNgay, DateTime? denNgay, string thongBao)
        {
            if (tuNgay != null && denNgay != null && denNgay.Value.Date < tuNgay.Value.Date)
                throw new NghiepVuException(thongBao);
        }
    }
}
