using System;

namespace QuanLyNhanSu.DTO
{
    /// <summary>Dữ liệu một quá trình công tác (bảng QTCT).</summary>
    public class QuaTrinhCongTacDTO
    {
        public string MaQTCT { get; set; } = "";
        public string MaNV { get; set; } = "";
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public string? MaPhong { get; set; }
        public string? MaCV { get; set; }
    }
}
