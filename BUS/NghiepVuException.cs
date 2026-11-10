using System;

namespace QuanLyNhanSu.BUS
{
    /// <summary>
    /// Lỗi vi phạm quy tắc nghiệp vụ (thiếu dữ liệu, ngày không hợp lệ, trùng mã...).
    /// Khác với lỗi hệ thống/CSDL: GUI nên hiện thông báo nhẹ (cảnh báo) cho loại lỗi này.
    /// </summary>
    public class NghiepVuException : Exception
    {
        public NghiepVuException(string message) : base(message)
        {
        }
    }
}
