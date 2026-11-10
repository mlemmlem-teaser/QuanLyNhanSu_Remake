using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAL
{
    /// <summary>
    /// Truy cập 13 bảng danh mục qua procedure usp_DanhMuc_GetAll / Insert / Update / Delete.
    /// Tên danh mục hợp lệ được khai báo sẵn bên dưới (trùng với procedure trong QuanLyNhanSuProc.sql).
    /// </summary>
    public static class DanhMucDAL
    {
        private class CauHinhDanhMuc
        {
            public string Ten { get; }          // tên danh mục (khớp @Loai trong procedure)
            public string Khoa { get; }         // cột khóa chính
            public string[] Cot { get; }        // các cột dữ liệu theo thứ tự: tên, cột 2, cột 3

            public CauHinhDanhMuc(string ten, string khoa, params string[] cot)
            {
                Ten = ten;
                Khoa = khoa;
                Cot = cot;
            }
        }

        private static readonly Dictionary<string, CauHinhDanhMuc> DanhMuc =
            new Dictionary<string, CauHinhDanhMuc>(StringComparer.OrdinalIgnoreCase)
            {
                { "GioiTinh", new CauHinhDanhMuc("GioiTinh", "MaGT", "TenGT") },
                { "ChucVu", new CauHinhDanhMuc("ChucVu", "MaCV", "TenCV") },
                { "DanToc", new CauHinhDanhMuc("DanToc", "MaDT", "TenDT") },
                { "TonGiao", new CauHinhDanhMuc("TonGiao", "MaTG", "TenTG", "GhiChu") },
                { "NoiSinh", new CauHinhDanhMuc("NoiSinh", "MaNS", "TenNS") },
                { "NgoaiNgu", new CauHinhDanhMuc("NgoaiNgu", "MaNN", "TenNN") },
                { "PhongBan", new CauHinhDanhMuc("PhongBan", "MaPhong", "TenPhong", "DienThoai") },
                { "HocVan", new CauHinhDanhMuc("HocVan", "MaHV", "TenHV") },
                { "ChuyenMon", new CauHinhDanhMuc("ChuyenMon", "MaCM", "TenCM") },
                { "TruongDT", new CauHinhDanhMuc("TruongDT", "MaTruong", "TenTruong", "DiaChi", "DienThoai") },
                { "HinhThuc", new CauHinhDanhMuc("HinhThuc", "MaHT", "TenHT") },
                { "NganhDT", new CauHinhDanhMuc("NganhDT", "MaNganh", "TenNganh") },
                { "XepLoai", new CauHinhDanhMuc("XepLoai", "MaXL", "TenXL") }
            };

        private static CauHinhDanhMuc LayCauHinh(string? loai)
        {
            if (loai == null || !DanhMuc.TryGetValue(loai, out CauHinhDanhMuc? cauHinh))
                throw new ArgumentException("Tên danh mục không hợp lệ.", nameof(loai));
            return cauHinh;
        }

        private static object? LayGiaTri(Dictionary<string, object>? values, string cot)
        {
            return values != null && values.ContainsKey(cot) ? values[cot] : null;
        }

        /// <summary>Tên cột khóa chính của danh mục (BUS dùng để kiểm tra dữ liệu).</summary>
        public static string CotKhoa(string loai)
        {
            return LayCauHinh(loai).Khoa;
        }

        /// <summary>Tên cột "tên" (cột dữ liệu đầu tiên) của danh mục.</summary>
        public static string CotTen(string loai)
        {
            return LayCauHinh(loai).Cot[0];
        }

        public static DataTable GetAll(string loai)
        {
            CauHinhDanhMuc c = LayCauHinh(loai);
            return Db.QueryProc("usp_DanhMuc_GetAll", Db.P("@Loai", c.Ten));
        }

        /// <summary>Thêm dòng danh mục. values gồm khóa chính và các cột dữ liệu (khóa là tên cột).</summary>
        public static int Insert(string loai, Dictionary<string, object> values)
        {
            CauHinhDanhMuc c = LayCauHinh(loai);
            return Db.ExecuteProc("usp_DanhMuc_Insert",
                Db.P("@Loai", c.Ten),
                Db.P("@Ma", LayGiaTri(values, c.Khoa)),
                Db.P("@Ten", LayGiaTri(values, c.Cot[0])),
                Db.P("@Cot2", c.Cot.Length > 1 ? LayGiaTri(values, c.Cot[1]) : null),
                Db.P("@Cot3", c.Cot.Length > 2 ? LayGiaTri(values, c.Cot[2]) : null));
        }

        /// <summary>Sửa theo khóa chính. values chỉ cần chứa các cột dữ liệu, không cần khóa.</summary>
        public static int Update(string loai, string maKhoa, Dictionary<string, object> values)
        {
            CauHinhDanhMuc c = LayCauHinh(loai);
            return Db.ExecuteProc("usp_DanhMuc_Update",
                Db.P("@Loai", c.Ten),
                Db.P("@Ma", maKhoa),
                Db.P("@Ten", LayGiaTri(values, c.Cot[0])),
                Db.P("@Cot2", c.Cot.Length > 1 ? LayGiaTri(values, c.Cot[1]) : null),
                Db.P("@Cot3", c.Cot.Length > 2 ? LayGiaTri(values, c.Cot[2]) : null));
        }

        /// <summary>Xóa một dòng. Nếu bảng khác đang tham chiếu, khóa ngoại sẽ chặn xóa.</summary>
        public static int Delete(string loai, string maKhoa)
        {
            CauHinhDanhMuc c = LayCauHinh(loai);
            return Db.ExecuteProc("usp_DanhMuc_Delete", Db.P("@Loai", c.Ten), Db.P("@Ma", maKhoa));
        }
    }
}
