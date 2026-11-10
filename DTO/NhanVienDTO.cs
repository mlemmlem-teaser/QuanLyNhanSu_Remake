using System;
using System.Collections.Generic;

namespace QuanLyNhanSu.DTO
{
    /// <summary>
    /// Dữ liệu một hồ sơ nhân viên, dùng để truyền giữa GUI -> BUS -> DAL.
    /// Chỉ chứa dữ liệu, không có xử lý.
    /// </summary>
    public class NhanVienDTO
    {
        public string MaNV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string? MaGT { get; set; }
        public string? MaCV { get; set; }
        public string? MaDT { get; set; }
        public string? MaTG { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? QueQuan { get; set; }
        public string? MaNS { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        public string? SoCMND { get; set; }
        public string? MaPhong { get; set; }
        public string? MaHV { get; set; }
        public string? MaCM { get; set; }
        public string? VoChong { get; set; }
        public string? Con { get; set; }

        /// <summary>Mã các ngoại ngữ của nhân viên (lưu vào bảng NV_NgoaiNgu).</summary>
        public List<string> MaNgoaiNgu { get; set; } = new List<string>();
    }
}
