using System;
using System.Data;
using QuanLyNhanSu.DAL;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu.BUS
{
    /// <summary>Nghiệp vụ hồ sơ nhân viên: kiểm tra dữ liệu rồi gọi NhanVienDAL.</summary>
    public static class NhanVienBUS
    {
        public static DataTable GetAll()
        {
            return NhanVienDAL.GetAll();
        }

        public static DataTable GetByMaNV(string maNV)
        {
            KiemTra.BatBuoc(maNV, "Mã nhân viên");
            return NhanVienDAL.GetByMaNV(maNV.Trim());
        }

        public static DataTable GetNgoaiNgu(string maNV)
        {
            KiemTra.BatBuoc(maNV, "Mã nhân viên");
            return NhanVienDAL.GetNgoaiNgu(maNV.Trim());
        }

        /// <summary>Tìm theo nhiều tiêu chí kết hợp; tiêu chí null/rỗng được bỏ qua. maNV tìm theo "chứa từ khóa".</summary>
        public static DataTable TimKiem(string? tenNV = null, string? maPhong = null, string? maCV = null,
            string? maHV = null, string? maNN = null, string? maNV = null)
        {
            return NhanVienDAL.TimKiem(tenNV, maPhong, maCV, maHV, maNN, maNV);
        }

        /// <summary>
        /// Kiểm tra hồ sơ trước khi lưu; vi phạm thì ném NghiepVuException.
        /// GUI có thể gọi riêng để báo lỗi ngay khi bấm Lưu (trước khi đóng hộp thoại).
        /// </summary>
        public static void KiemTraHopLe(NhanVienDTO nv, bool themMoi)
        {
            KiemTra.BatBuoc(nv.MaNV, "Mã nhân viên");
            KiemTra.BatBuoc(nv.HoTen, "Họ tên");
            KiemTra.DoDaiToiDa(nv.MaNV, 10, "Mã nhân viên");
            KiemTra.DoDaiToiDa(nv.HoTen, 50, "Họ tên");
            KiemTra.DoDaiToiDa(nv.QueQuan, 100, "Quê quán");
            KiemTra.DoDaiToiDa(nv.DiaChi, 100, "Địa chỉ");
            KiemTra.DoDaiToiDa(nv.DienThoai, 20, "Điện thoại");
            KiemTra.DoDaiToiDa(nv.SoCMND, 20, "Số CMND");
            KiemTra.DoDaiToiDa(nv.VoChong, 50, "Vợ/chồng");
            KiemTra.DoDaiToiDa(nv.Con, 50, "Con");

            if (nv.NgaySinh != null && nv.NgaySinh.Value.Date > DateTime.Today)
                throw new NghiepVuException("Ngày sinh không được lớn hơn ngày hiện tại.");

            if (themMoi && NhanVienDAL.GetByMaNV(nv.MaNV.Trim()).Rows.Count > 0)
                throw new NghiepVuException("Mã nhân viên " + nv.MaNV.Trim() + " đã tồn tại.");
        }

        public static void Insert(NhanVienDTO nv)
        {
            KiemTraHopLe(nv, true);
            nv.MaNV = nv.MaNV.Trim();
            nv.HoTen = nv.HoTen.Trim();
            NhanVienDAL.Insert(nv);
        }

        public static void Update(NhanVienDTO nv)
        {
            KiemTraHopLe(nv, false);
            nv.MaNV = nv.MaNV.Trim();
            nv.HoTen = nv.HoTen.Trim();
            NhanVienDAL.Update(nv);
        }

        public static void Delete(string maNV)
        {
            KiemTra.BatBuoc(maNV, "Mã nhân viên");
            NhanVienDAL.Delete(maNV.Trim());
        }
    }
}
