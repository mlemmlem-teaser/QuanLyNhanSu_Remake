using System.Collections.Generic;
using System.Data;
using QuanLyNhanSu.DAL;

namespace QuanLyNhanSu.BUS
{
    /// <summary>Nghiệp vụ danh mục: kiểm tra dữ liệu rồi gọi DanhMucDAL.</summary>
    public static class DanhMucBUS
    {
        public static DataTable GetAll(string loai)
        {
            return DanhMucDAL.GetAll(loai);
        }

        public static void Insert(string loai, Dictionary<string, object> values)
        {
            string cotKhoa = DanhMucDAL.CotKhoa(loai);
            string ma = Lay(values, cotKhoa);
            KiemTra.BatBuoc(ma, "Mã danh mục");
            KiemTra.DoDaiToiDa(ma, 10, "Mã danh mục");
            KiemTra.BatBuoc(Lay(values, DanhMucDAL.CotTen(loai)), "Tên danh mục");

            DanhMucDAL.Insert(loai, values);
        }

        public static void Update(string loai, string maKhoa, Dictionary<string, object> values)
        {
            KiemTra.BatBuoc(maKhoa, "Mã danh mục");
            KiemTra.BatBuoc(Lay(values, DanhMucDAL.CotTen(loai)), "Tên danh mục");

            DanhMucDAL.Update(loai, maKhoa, values);
        }

        public static void Delete(string loai, string maKhoa)
        {
            KiemTra.BatBuoc(maKhoa, "Mã danh mục");
            DanhMucDAL.Delete(loai, maKhoa);
        }

        private static string Lay(Dictionary<string, object>? values, string cot)
        {
            if (values == null || !values.ContainsKey(cot) || values[cot] == null) return "";
            return System.Convert.ToString(values[cot]) ?? "";
        }
    }
}
