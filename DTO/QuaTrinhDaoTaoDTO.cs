using System;

namespace QuanLyNhanSu.DTO
{
    /// <summary>Dữ liệu một quá trình đào tạo (bảng QTDT).</summary>
    public class QuaTrinhDaoTaoDTO
    {
        public string MaQTDT { get; set; } = "";
        public string MaNV { get; set; } = "";
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public string? MaTruong { get; set; }
        public string? MaHT { get; set; }
        public string? MaNganh { get; set; }
        public string? MaXL { get; set; }
    }
}
