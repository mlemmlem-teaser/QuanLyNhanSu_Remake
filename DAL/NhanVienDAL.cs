using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu.DAL
{
    /// <summary>Truy cập hồ sơ nhân viên (bảng HoSoNV và NV_NgoaiNgu) qua procedure usp_NhanVien_*.</summary>
    public static class NhanVienDAL
    {
        public static DataTable GetAll()
        {
            return Db.QueryProc("usp_NhanVien_GetAll");
        }

        public static DataTable GetByMaNV(string maNV)
        {
            return Db.QueryProc("usp_NhanVien_GetByMaNV", Db.P("@MaNV", maNV));
        }

        /// <summary>Mã các ngoại ngữ của một nhân viên (cột MaNN).</summary>
        public static DataTable GetNgoaiNgu(string maNV)
        {
            return Db.QueryProc("usp_NhanVien_GetNgoaiNgu", Db.P("@MaNV", maNV));
        }

        /// <summary>Tìm theo nhiều tiêu chí kết hợp; null/rỗng = bỏ qua tiêu chí.</summary>
        public static DataTable TimKiem(string? tenNV = null, string? maPhong = null, string? maCV = null,
            string? maHV = null, string? maNN = null, string? maNV = null)
        {
            return Db.QueryProc("usp_NhanVien_TimKiem",
                Db.P("@MaNV", Db.Clean(maNV)),
                Db.P("@TenNV", Db.Clean(tenNV)),
                Db.P("@MaPhong", Db.Clean(maPhong)),
                Db.P("@MaCV", Db.Clean(maCV)),
                Db.P("@MaHV", Db.Clean(maHV)),
                Db.P("@MaNN", Db.Clean(maNN)));
        }

        /// <summary>Thêm hồ sơ và danh sách ngoại ngữ trong cùng một giao dịch.</summary>
        public static void Insert(NhanVienDTO nv)
        {
            Db.RunTransaction((conn, tran) =>
            {
                Db.ExecuteProc(conn, tran, "usp_NhanVien_Insert", ThamSoHoSo(nv));
                LuuNgoaiNgu(conn, tran, nv, false);
            });
        }

        /// <summary>Sửa hồ sơ và thay toàn bộ danh sách ngoại ngữ trong cùng một giao dịch.</summary>
        public static void Update(NhanVienDTO nv)
        {
            Db.RunTransaction((conn, tran) =>
            {
                Db.ExecuteProc(conn, tran, "usp_NhanVien_Update", ThamSoHoSo(nv));
                LuuNgoaiNgu(conn, tran, nv, true);
            });
        }

        /// <summary>Xóa nhân viên (procedure tự xóa NV_NgoaiNgu). Còn QTDT/QTCT thì khóa ngoại chặn xóa.</summary>
        public static void Delete(string maNV)
        {
            Db.ExecuteProc("usp_NhanVien_Delete", Db.P("@MaNV", maNV));
        }

        private static SqlParameter[] ThamSoHoSo(NhanVienDTO nv)
        {
            return new SqlParameter[]
            {
                Db.P("@MaNV", nv.MaNV),
                Db.P("@HoTen", nv.HoTen),
                Db.P("@MaGT", Db.Clean(nv.MaGT)),
                Db.P("@MaCV", Db.Clean(nv.MaCV)),
                Db.P("@MaDT", Db.Clean(nv.MaDT)),
                Db.P("@MaTG", Db.Clean(nv.MaTG)),
                Db.P("@NgaySinh", nv.NgaySinh),
                Db.P("@QueQuan", Db.Clean(nv.QueQuan)),
                Db.P("@MaNS", Db.Clean(nv.MaNS)),
                Db.P("@DiaChi", Db.Clean(nv.DiaChi)),
                Db.P("@DienThoai", Db.Clean(nv.DienThoai)),
                Db.P("@SoCMND", Db.Clean(nv.SoCMND)),
                Db.P("@MaPhong", Db.Clean(nv.MaPhong)),
                Db.P("@MaHV", Db.Clean(nv.MaHV)),
                Db.P("@MaCM", Db.Clean(nv.MaCM)),
                Db.P("@VoChong", Db.Clean(nv.VoChong)),
                Db.P("@Con", Db.Clean(nv.Con))
            };
        }

        private static void LuuNgoaiNgu(SqlConnection conn, SqlTransaction tran, NhanVienDTO nv, bool xoaCu)
        {
            if (xoaCu)
                Db.ExecuteProc(conn, tran, "usp_NV_NgoaiNgu_Xoa", Db.P("@MaNV", nv.MaNV));

            if (nv.MaNgoaiNgu == null) return;
            foreach (string maNN in nv.MaNgoaiNgu.Where(x => !string.IsNullOrWhiteSpace(x)).Distinct())
                Db.ExecuteProc(conn, tran, "usp_NV_NgoaiNgu_Them", Db.P("@MaNV", nv.MaNV), Db.P("@MaNN", maNN));
        }
    }
}
