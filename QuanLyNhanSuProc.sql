/*
===============================================================================
QuanLyNhanSuProc.sql - CÁC STORED PROCEDURE CỦA CSDL QuanLyNhanSu
===============================================================================
CÁCH DÙNG
  1. Chạy QuanLyNhanSu.sql (tạo CSDL + bảng) rồi QuanLyNhanSu_Data.sql (dữ liệu).
  2. Chạy file này trong SSMS (Ctrl+A rồi F5) hoặc: sqlcmd -S .\SQLEXPRESS -I -i QuanLyNhanSuProc.sql
     Có thể chạy lại nhiều lần: mỗi procedure được xóa rồi tạo lại.

QUY ƯỚC
  - Tên procedure: usp_<Nhóm>_<Chức năng>.
  - Tham số lọc có giá trị mặc định NULL: NULL = bỏ qua tiêu chí đó.
  - Procedure chỉ truy vấn dữ liệu; kiểm tra nghiệp vụ nằm ở tầng BUS (C#).
  - Tầng DAL (C#) chỉ gọi các procedure này, không viết câu SQL trực tiếp.

NHÓM PROCEDURE
  usp_DanhMuc_*       : 13 danh mục (GioiTinh, ChucVu, DanToc, TonGiao, NoiSinh, NgoaiNgu,
                        PhongBan, HocVan, ChuyenMon, TruongDT, HinhThuc, NganhDT, XepLoai)
  usp_NhanVien_*      : hồ sơ nhân viên (+ usp_NV_NgoaiNgu_* cho bảng NV_NgoaiNgu)
  usp_QTDT_*          : quá trình đào tạo
  usp_QTCT_*          : quá trình công tác
  usp_BaoCao_*        : các báo cáo
===============================================================================
*/

USE QuanLyNhanSu;
GO

-- Bắt buộc ON: câu SELECT của nhân viên dùng phương thức .value() của kiểu XML.
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

-- =============================================================================
-- 1. DANH MỤC  (Loai = tên danh mục, xem danh sách ở đầu file)
--    Cot2, Cot3 = cột dữ liệu thứ 2, thứ 3 sau cột tên (nếu danh mục có):
--      TonGiao: Cot2=GhiChu | PhongBan: Cot2=DienThoai | TruongDT: Cot2=DiaChi, Cot3=DienThoai
-- =============================================================================

-- Lấy toàn bộ một danh mục (dùng cho lưới và để nạp ComboBox).
IF OBJECT_ID(N'dbo.usp_DanhMuc_GetAll', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_DanhMuc_GetAll;
GO
CREATE PROCEDURE dbo.usp_DanhMuc_GetAll
    @Loai NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;
    IF @Loai = N'GioiTinh'
    BEGIN
        SELECT * FROM GioiTinh ORDER BY MaGT;
    END
    ELSE IF @Loai = N'ChucVu'
    BEGIN
        SELECT * FROM ChucVu ORDER BY MaCV;
    END
    ELSE IF @Loai = N'DanToc'
    BEGIN
        SELECT * FROM DanToc ORDER BY MaDT;
    END
    ELSE IF @Loai = N'TonGiao'
    BEGIN
        SELECT * FROM TonGiao ORDER BY MaTG;
    END
    ELSE IF @Loai = N'NoiSinh'
    BEGIN
        SELECT * FROM NoiSinh ORDER BY MaNS;
    END
    ELSE IF @Loai = N'NgoaiNgu'
    BEGIN
        SELECT * FROM NgoaiNgu ORDER BY MaNN;
    END
    ELSE IF @Loai = N'PhongBan'
    BEGIN
        SELECT * FROM PhongBan ORDER BY MaPhong;
    END
    ELSE IF @Loai = N'HocVan'
    BEGIN
        SELECT * FROM HocVan ORDER BY MaHV;
    END
    ELSE IF @Loai = N'ChuyenMon'
    BEGIN
        SELECT * FROM ChuyenMon ORDER BY MaCM;
    END
    ELSE IF @Loai = N'TruongDT'
    BEGIN
        SELECT * FROM TruongDT ORDER BY MaTruong;
    END
    ELSE IF @Loai = N'HinhThuc'
    BEGIN
        SELECT * FROM HinhThuc ORDER BY MaHT;
    END
    ELSE IF @Loai = N'NganhDT'
    BEGIN
        SELECT * FROM NganhDT ORDER BY MaNganh;
    END
    ELSE IF @Loai = N'XepLoai'
    BEGIN
        SELECT * FROM XepLoai ORDER BY MaXL;
    END
    ELSE
    BEGIN
        RAISERROR(N'Tên danh mục không hợp lệ.', 16, 1);
    END
END
GO

-- Thêm một dòng vào danh mục.
IF OBJECT_ID(N'dbo.usp_DanhMuc_Insert', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_DanhMuc_Insert;
GO
CREATE PROCEDURE dbo.usp_DanhMuc_Insert
    @Loai NVARCHAR(30),
    @Ma VARCHAR(10),
    @Ten NVARCHAR(100) = NULL,
    @Cot2 NVARCHAR(100) = NULL,
    @Cot3 NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @Loai = N'GioiTinh'
    BEGIN
        INSERT INTO GioiTinh (MaGT, TenGT) VALUES (@Ma, @Ten);
    END
    ELSE IF @Loai = N'ChucVu'
    BEGIN
        INSERT INTO ChucVu (MaCV, TenCV) VALUES (@Ma, @Ten);
    END
    ELSE IF @Loai = N'DanToc'
    BEGIN
        INSERT INTO DanToc (MaDT, TenDT) VALUES (@Ma, @Ten);
    END
    ELSE IF @Loai = N'TonGiao'
    BEGIN
        INSERT INTO TonGiao (MaTG, TenTG, GhiChu) VALUES (@Ma, @Ten, @Cot2);
    END
    ELSE IF @Loai = N'NoiSinh'
    BEGIN
        INSERT INTO NoiSinh (MaNS, TenNS) VALUES (@Ma, @Ten);
    END
    ELSE IF @Loai = N'NgoaiNgu'
    BEGIN
        INSERT INTO NgoaiNgu (MaNN, TenNN) VALUES (@Ma, @Ten);
    END
    ELSE IF @Loai = N'PhongBan'
    BEGIN
        INSERT INTO PhongBan (MaPhong, TenPhong, DienThoai) VALUES (@Ma, @Ten, @Cot2);
    END
    ELSE IF @Loai = N'HocVan'
    BEGIN
        INSERT INTO HocVan (MaHV, TenHV) VALUES (@Ma, @Ten);
    END
    ELSE IF @Loai = N'ChuyenMon'
    BEGIN
        INSERT INTO ChuyenMon (MaCM, TenCM) VALUES (@Ma, @Ten);
    END
    ELSE IF @Loai = N'TruongDT'
    BEGIN
        INSERT INTO TruongDT (MaTruong, TenTruong, DiaChi, DienThoai) VALUES (@Ma, @Ten, @Cot2, @Cot3);
    END
    ELSE IF @Loai = N'HinhThuc'
    BEGIN
        INSERT INTO HinhThuc (MaHT, TenHT) VALUES (@Ma, @Ten);
    END
    ELSE IF @Loai = N'NganhDT'
    BEGIN
        INSERT INTO NganhDT (MaNganh, TenNganh) VALUES (@Ma, @Ten);
    END
    ELSE IF @Loai = N'XepLoai'
    BEGIN
        INSERT INTO XepLoai (MaXL, TenXL) VALUES (@Ma, @Ten);
    END
    ELSE
    BEGIN
        RAISERROR(N'Tên danh mục không hợp lệ.', 16, 1);
    END
END
GO

-- Sửa một dòng danh mục theo mã (khóa chính).
IF OBJECT_ID(N'dbo.usp_DanhMuc_Update', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_DanhMuc_Update;
GO
CREATE PROCEDURE dbo.usp_DanhMuc_Update
    @Loai NVARCHAR(30),
    @Ma VARCHAR(10),
    @Ten NVARCHAR(100) = NULL,
    @Cot2 NVARCHAR(100) = NULL,
    @Cot3 NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @Loai = N'GioiTinh'
    BEGIN
        UPDATE GioiTinh SET TenGT = @Ten WHERE MaGT = @Ma;
    END
    ELSE IF @Loai = N'ChucVu'
    BEGIN
        UPDATE ChucVu SET TenCV = @Ten WHERE MaCV = @Ma;
    END
    ELSE IF @Loai = N'DanToc'
    BEGIN
        UPDATE DanToc SET TenDT = @Ten WHERE MaDT = @Ma;
    END
    ELSE IF @Loai = N'TonGiao'
    BEGIN
        UPDATE TonGiao SET TenTG = @Ten, GhiChu = @Cot2 WHERE MaTG = @Ma;
    END
    ELSE IF @Loai = N'NoiSinh'
    BEGIN
        UPDATE NoiSinh SET TenNS = @Ten WHERE MaNS = @Ma;
    END
    ELSE IF @Loai = N'NgoaiNgu'
    BEGIN
        UPDATE NgoaiNgu SET TenNN = @Ten WHERE MaNN = @Ma;
    END
    ELSE IF @Loai = N'PhongBan'
    BEGIN
        UPDATE PhongBan SET TenPhong = @Ten, DienThoai = @Cot2 WHERE MaPhong = @Ma;
    END
    ELSE IF @Loai = N'HocVan'
    BEGIN
        UPDATE HocVan SET TenHV = @Ten WHERE MaHV = @Ma;
    END
    ELSE IF @Loai = N'ChuyenMon'
    BEGIN
        UPDATE ChuyenMon SET TenCM = @Ten WHERE MaCM = @Ma;
    END
    ELSE IF @Loai = N'TruongDT'
    BEGIN
        UPDATE TruongDT SET TenTruong = @Ten, DiaChi = @Cot2, DienThoai = @Cot3 WHERE MaTruong = @Ma;
    END
    ELSE IF @Loai = N'HinhThuc'
    BEGIN
        UPDATE HinhThuc SET TenHT = @Ten WHERE MaHT = @Ma;
    END
    ELSE IF @Loai = N'NganhDT'
    BEGIN
        UPDATE NganhDT SET TenNganh = @Ten WHERE MaNganh = @Ma;
    END
    ELSE IF @Loai = N'XepLoai'
    BEGIN
        UPDATE XepLoai SET TenXL = @Ten WHERE MaXL = @Ma;
    END
    ELSE
    BEGIN
        RAISERROR(N'Tên danh mục không hợp lệ.', 16, 1);
    END
END
GO

-- Xóa một dòng danh mục. Nếu bảng khác đang tham chiếu, khóa ngoại sẽ chặn xóa.
IF OBJECT_ID(N'dbo.usp_DanhMuc_Delete', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_DanhMuc_Delete;
GO
CREATE PROCEDURE dbo.usp_DanhMuc_Delete
    @Loai NVARCHAR(30),
    @Ma VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    IF @Loai = N'GioiTinh'
    BEGIN
        DELETE FROM GioiTinh WHERE MaGT = @Ma;
    END
    ELSE IF @Loai = N'ChucVu'
    BEGIN
        DELETE FROM ChucVu WHERE MaCV = @Ma;
    END
    ELSE IF @Loai = N'DanToc'
    BEGIN
        DELETE FROM DanToc WHERE MaDT = @Ma;
    END
    ELSE IF @Loai = N'TonGiao'
    BEGIN
        DELETE FROM TonGiao WHERE MaTG = @Ma;
    END
    ELSE IF @Loai = N'NoiSinh'
    BEGIN
        DELETE FROM NoiSinh WHERE MaNS = @Ma;
    END
    ELSE IF @Loai = N'NgoaiNgu'
    BEGIN
        DELETE FROM NgoaiNgu WHERE MaNN = @Ma;
    END
    ELSE IF @Loai = N'PhongBan'
    BEGIN
        DELETE FROM PhongBan WHERE MaPhong = @Ma;
    END
    ELSE IF @Loai = N'HocVan'
    BEGIN
        DELETE FROM HocVan WHERE MaHV = @Ma;
    END
    ELSE IF @Loai = N'ChuyenMon'
    BEGIN
        DELETE FROM ChuyenMon WHERE MaCM = @Ma;
    END
    ELSE IF @Loai = N'TruongDT'
    BEGIN
        DELETE FROM TruongDT WHERE MaTruong = @Ma;
    END
    ELSE IF @Loai = N'HinhThuc'
    BEGIN
        DELETE FROM HinhThuc WHERE MaHT = @Ma;
    END
    ELSE IF @Loai = N'NganhDT'
    BEGIN
        DELETE FROM NganhDT WHERE MaNganh = @Ma;
    END
    ELSE IF @Loai = N'XepLoai'
    BEGIN
        DELETE FROM XepLoai WHERE MaXL = @Ma;
    END
    ELSE
    BEGIN
        RAISERROR(N'Tên danh mục không hợp lệ.', 16, 1);
    END
END
GO

-- =============================================================================
-- 2. HỒ SƠ NHÂN VIÊN
-- =============================================================================

-- Danh sách toàn bộ nhân viên (kèm tên danh mục và các ngoại ngữ).
IF OBJECT_ID(N'dbo.usp_NhanVien_GetAll', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_NhanVien_GetAll;
GO
CREATE PROCEDURE dbo.usp_NhanVien_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT nv.*,
           gt.TenGT, cv.TenCV, dt.TenDT, tg.TenTG, ns.TenNS,
           pb.TenPhong, hv.TenHV, cm.TenCM,
           STUFF((
               SELECT ', ' + nn.TenNN
               FROM NV_NgoaiNgu mapNN
               INNER JOIN NgoaiNgu nn ON nn.MaNN = mapNN.MaNN
               WHERE mapNN.MaNV = nv.MaNV
               FOR XML PATH(''), TYPE
           ).value('.', 'nvarchar(max)'), 1, 2, '') AS NgoaiNgu
    FROM HoSoNV nv
    LEFT JOIN GioiTinh gt ON gt.MaGT = nv.MaGT
    LEFT JOIN ChucVu cv ON cv.MaCV = nv.MaCV
    LEFT JOIN DanToc dt ON dt.MaDT = nv.MaDT
    LEFT JOIN TonGiao tg ON tg.MaTG = nv.MaTG
    LEFT JOIN NoiSinh ns ON ns.MaNS = nv.MaNS
    LEFT JOIN PhongBan pb ON pb.MaPhong = nv.MaPhong
    LEFT JOIN HocVan hv ON hv.MaHV = nv.MaHV
    LEFT JOIN ChuyenMon cm ON cm.MaCM = nv.MaCM
    ORDER BY nv.MaNV;
END
GO

-- Một hồ sơ nhân viên theo mã (dùng khi sửa và kiểm tra trùng mã).
IF OBJECT_ID(N'dbo.usp_NhanVien_GetByMaNV', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_NhanVien_GetByMaNV;
GO
CREATE PROCEDURE dbo.usp_NhanVien_GetByMaNV
    @MaNV VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT nv.*,
           gt.TenGT, cv.TenCV, dt.TenDT, tg.TenTG, ns.TenNS,
           pb.TenPhong, hv.TenHV, cm.TenCM,
           STUFF((
               SELECT ', ' + nn.TenNN
               FROM NV_NgoaiNgu mapNN
               INNER JOIN NgoaiNgu nn ON nn.MaNN = mapNN.MaNN
               WHERE mapNN.MaNV = nv.MaNV
               FOR XML PATH(''), TYPE
           ).value('.', 'nvarchar(max)'), 1, 2, '') AS NgoaiNgu
    FROM HoSoNV nv
    LEFT JOIN GioiTinh gt ON gt.MaGT = nv.MaGT
    LEFT JOIN ChucVu cv ON cv.MaCV = nv.MaCV
    LEFT JOIN DanToc dt ON dt.MaDT = nv.MaDT
    LEFT JOIN TonGiao tg ON tg.MaTG = nv.MaTG
    LEFT JOIN NoiSinh ns ON ns.MaNS = nv.MaNS
    LEFT JOIN PhongBan pb ON pb.MaPhong = nv.MaPhong
    LEFT JOIN HocVan hv ON hv.MaHV = nv.MaHV
    LEFT JOIN ChuyenMon cm ON cm.MaCM = nv.MaCM
    WHERE nv.MaNV = @MaNV;
END
GO

-- Tìm nhân viên theo nhiều tiêu chí kết hợp (mã/tên chứa từ khóa; phòng ban, chức vụ, học vấn, ngoại ngữ).
IF OBJECT_ID(N'dbo.usp_NhanVien_TimKiem', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_NhanVien_TimKiem;
GO
CREATE PROCEDURE dbo.usp_NhanVien_TimKiem
    @MaNV VARCHAR(10) = NULL,
    @TenNV NVARCHAR(50) = NULL,
    @MaPhong VARCHAR(10) = NULL,
    @MaCV VARCHAR(10) = NULL,
    @MaHV VARCHAR(10) = NULL,
    @MaNN VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT nv.*,
           gt.TenGT, cv.TenCV, dt.TenDT, tg.TenTG, ns.TenNS,
           pb.TenPhong, hv.TenHV, cm.TenCM,
           STUFF((
               SELECT ', ' + nn.TenNN
               FROM NV_NgoaiNgu mapNN
               INNER JOIN NgoaiNgu nn ON nn.MaNN = mapNN.MaNN
               WHERE mapNN.MaNV = nv.MaNV
               FOR XML PATH(''), TYPE
           ).value('.', 'nvarchar(max)'), 1, 2, '') AS NgoaiNgu
    FROM HoSoNV nv
    LEFT JOIN GioiTinh gt ON gt.MaGT = nv.MaGT
    LEFT JOIN ChucVu cv ON cv.MaCV = nv.MaCV
    LEFT JOIN DanToc dt ON dt.MaDT = nv.MaDT
    LEFT JOIN TonGiao tg ON tg.MaTG = nv.MaTG
    LEFT JOIN NoiSinh ns ON ns.MaNS = nv.MaNS
    LEFT JOIN PhongBan pb ON pb.MaPhong = nv.MaPhong
    LEFT JOIN HocVan hv ON hv.MaHV = nv.MaHV
    LEFT JOIN ChuyenMon cm ON cm.MaCM = nv.MaCM
    WHERE (@MaNV IS NULL OR nv.MaNV LIKE '%' + @MaNV + '%')
      AND (@TenNV IS NULL OR nv.HoTen LIKE '%' + @TenNV + '%')
      AND (@MaPhong IS NULL OR nv.MaPhong = @MaPhong)
      AND (@MaCV IS NULL OR nv.MaCV = @MaCV)
      AND (@MaHV IS NULL OR nv.MaHV = @MaHV)
      AND (@MaNN IS NULL OR EXISTS (
            SELECT 1 FROM NV_NgoaiNgu x WHERE x.MaNV = nv.MaNV AND x.MaNN = @MaNN))
    ORDER BY nv.MaNV;
END
GO

-- Thêm hồ sơ nhân viên (danh sách ngoại ngữ được lưu riêng bằng usp_NV_NgoaiNgu_Them).
IF OBJECT_ID(N'dbo.usp_NhanVien_Insert', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_NhanVien_Insert;
GO
CREATE PROCEDURE dbo.usp_NhanVien_Insert
    @MaNV VARCHAR(10),
    @HoTen NVARCHAR(50),
    @MaGT VARCHAR(10) = NULL,
    @MaCV VARCHAR(10) = NULL,
    @MaDT VARCHAR(10) = NULL,
    @MaTG VARCHAR(10) = NULL,
    @NgaySinh DATE = NULL,
    @QueQuan NVARCHAR(100) = NULL,
    @MaNS VARCHAR(10) = NULL,
    @DiaChi NVARCHAR(100) = NULL,
    @DienThoai VARCHAR(20) = NULL,
    @SoCMND VARCHAR(20) = NULL,
    @MaPhong VARCHAR(10) = NULL,
    @MaHV VARCHAR(10) = NULL,
    @MaCM VARCHAR(10) = NULL,
    @VoChong NVARCHAR(50) = NULL,
    @Con NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO HoSoNV
        (MaNV, HoTen, MaGT, MaCV, MaDT, MaTG, NgaySinh, QueQuan, MaNS, DiaChi,
         DienThoai, SoCMND, MaPhong, MaHV, MaCM, VoChong, Con)
    VALUES
        (@MaNV, @HoTen, @MaGT, @MaCV, @MaDT, @MaTG, @NgaySinh, @QueQuan, @MaNS, @DiaChi,
         @DienThoai, @SoCMND, @MaPhong, @MaHV, @MaCM, @VoChong, @Con);
END
GO

-- Sửa hồ sơ nhân viên theo mã.
IF OBJECT_ID(N'dbo.usp_NhanVien_Update', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_NhanVien_Update;
GO
CREATE PROCEDURE dbo.usp_NhanVien_Update
    @MaNV VARCHAR(10),
    @HoTen NVARCHAR(50),
    @MaGT VARCHAR(10) = NULL,
    @MaCV VARCHAR(10) = NULL,
    @MaDT VARCHAR(10) = NULL,
    @MaTG VARCHAR(10) = NULL,
    @NgaySinh DATE = NULL,
    @QueQuan NVARCHAR(100) = NULL,
    @MaNS VARCHAR(10) = NULL,
    @DiaChi NVARCHAR(100) = NULL,
    @DienThoai VARCHAR(20) = NULL,
    @SoCMND VARCHAR(20) = NULL,
    @MaPhong VARCHAR(10) = NULL,
    @MaHV VARCHAR(10) = NULL,
    @MaCM VARCHAR(10) = NULL,
    @VoChong NVARCHAR(50) = NULL,
    @Con NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE HoSoNV SET
        HoTen = @HoTen, MaGT = @MaGT, MaCV = @MaCV, MaDT = @MaDT, MaTG = @MaTG,
        NgaySinh = @NgaySinh, QueQuan = @QueQuan, MaNS = @MaNS, DiaChi = @DiaChi,
        DienThoai = @DienThoai, SoCMND = @SoCMND, MaPhong = @MaPhong, MaHV = @MaHV,
        MaCM = @MaCM, VoChong = @VoChong, Con = @Con
    WHERE MaNV = @MaNV;
END
GO

-- Xóa nhân viên và các dòng NV_NgoaiNgu. Còn QTDT/QTCT liên quan thì khóa ngoại chặn xóa (và hủy cả giao dịch).
IF OBJECT_ID(N'dbo.usp_NhanVien_Delete', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_NhanVien_Delete;
GO
CREATE PROCEDURE dbo.usp_NhanVien_Delete
    @MaNV VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;   -- lỗi (ví dụ khóa ngoại) sẽ tự hủy toàn bộ giao dịch
    BEGIN TRANSACTION;
        DELETE FROM NV_NgoaiNgu WHERE MaNV = @MaNV;
        DELETE FROM HoSoNV WHERE MaNV = @MaNV;
    COMMIT TRANSACTION;
END
GO

-- Mã các ngoại ngữ của một nhân viên (để tick sẵn khi sửa hồ sơ).
IF OBJECT_ID(N'dbo.usp_NhanVien_GetNgoaiNgu', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_NhanVien_GetNgoaiNgu;
GO
CREATE PROCEDURE dbo.usp_NhanVien_GetNgoaiNgu
    @MaNV VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MaNN FROM NV_NgoaiNgu WHERE MaNV = @MaNV ORDER BY MaNN;
END
GO

-- Xóa toàn bộ ngoại ngữ của một nhân viên (trước khi lưu lại danh sách mới).
IF OBJECT_ID(N'dbo.usp_NV_NgoaiNgu_Xoa', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_NV_NgoaiNgu_Xoa;
GO
CREATE PROCEDURE dbo.usp_NV_NgoaiNgu_Xoa
    @MaNV VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM NV_NgoaiNgu WHERE MaNV = @MaNV;
END
GO

-- Thêm một ngoại ngữ cho nhân viên.
IF OBJECT_ID(N'dbo.usp_NV_NgoaiNgu_Them', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_NV_NgoaiNgu_Them;
GO
CREATE PROCEDURE dbo.usp_NV_NgoaiNgu_Them
    @MaNV VARCHAR(10),
    @MaNN VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO NV_NgoaiNgu (MaNV, MaNN) VALUES (@MaNV, @MaNN);
END
GO

-- =============================================================================
-- 3. QUÁ TRÌNH ĐÀO TẠO (QTDT)
-- =============================================================================

-- Toàn bộ quá trình đào tạo (kèm tên nhân viên/trường/hình thức/ngành/xếp loại).
IF OBJECT_ID(N'dbo.usp_QTDT_GetAll', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTDT_GetAll;
GO
CREATE PROCEDURE dbo.usp_QTDT_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT q.*, nv.HoTen, tr.TenTruong, ht.TenHT, ng.TenNganh, xl.TenXL
    FROM QTDT q
    LEFT JOIN HoSoNV nv ON nv.MaNV = q.MaNV
    LEFT JOIN TruongDT tr ON tr.MaTruong = q.MaTruong
    LEFT JOIN HinhThuc ht ON ht.MaHT = q.MaHT
    LEFT JOIN NganhDT ng ON ng.MaNganh = q.MaNganh
    LEFT JOIN XepLoai xl ON xl.MaXL = q.MaXL
    ORDER BY q.MaQTDT;
END
GO

-- Lọc QTDT theo nhân viên, trường, hình thức và khoảng ngày. Quá trình thiếu ngày thì bị loại khi lọc theo ngày đó.
IF OBJECT_ID(N'dbo.usp_QTDT_TimKiem', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTDT_TimKiem;
GO
CREATE PROCEDURE dbo.usp_QTDT_TimKiem
    @MaNV VARCHAR(10) = NULL,
    @MaTruong VARCHAR(10) = NULL,
    @MaHT VARCHAR(10) = NULL,
    @TuNgay DATE = NULL,
    @DenNgay DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT q.*, nv.HoTen, tr.TenTruong, ht.TenHT, ng.TenNganh, xl.TenXL
    FROM QTDT q
    LEFT JOIN HoSoNV nv ON nv.MaNV = q.MaNV
    LEFT JOIN TruongDT tr ON tr.MaTruong = q.MaTruong
    LEFT JOIN HinhThuc ht ON ht.MaHT = q.MaHT
    LEFT JOIN NganhDT ng ON ng.MaNganh = q.MaNganh
    LEFT JOIN XepLoai xl ON xl.MaXL = q.MaXL
    WHERE (@MaNV IS NULL OR q.MaNV = @MaNV)
      AND (@MaTruong IS NULL OR q.MaTruong = @MaTruong)
      AND (@MaHT IS NULL OR q.MaHT = @MaHT)
      AND (@TuNgay IS NULL OR q.TuNgay >= @TuNgay)     -- bắt đầu từ "Từ ngày" trở đi
      AND (@DenNgay IS NULL OR q.DenNgay <= @DenNgay)  -- kết thúc không muộn hơn "Đến ngày"
    ORDER BY q.MaQTDT;
END
GO

-- Thêm một quá trình đào tạo.
IF OBJECT_ID(N'dbo.usp_QTDT_Insert', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTDT_Insert;
GO
CREATE PROCEDURE dbo.usp_QTDT_Insert
    @MaQTDT VARCHAR(10),
    @MaNV VARCHAR(10),
    @TuNgay DATE = NULL,
    @DenNgay DATE = NULL,
    @MaTruong VARCHAR(10) = NULL,
    @MaHT VARCHAR(10) = NULL,
    @MaNganh VARCHAR(10) = NULL,
    @MaXL VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO QTDT (MaQTDT, MaNV, TuNgay, DenNgay, MaTruong, MaHT, MaNganh, MaXL)
    VALUES (@MaQTDT, @MaNV, @TuNgay, @DenNgay, @MaTruong, @MaHT, @MaNganh, @MaXL);
END
GO

-- Sửa một quá trình đào tạo theo mã.
IF OBJECT_ID(N'dbo.usp_QTDT_Update', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTDT_Update;
GO
CREATE PROCEDURE dbo.usp_QTDT_Update
    @MaQTDT VARCHAR(10),
    @MaNV VARCHAR(10),
    @TuNgay DATE = NULL,
    @DenNgay DATE = NULL,
    @MaTruong VARCHAR(10) = NULL,
    @MaHT VARCHAR(10) = NULL,
    @MaNganh VARCHAR(10) = NULL,
    @MaXL VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE QTDT SET MaNV = @MaNV, TuNgay = @TuNgay, DenNgay = @DenNgay,
        MaTruong = @MaTruong, MaHT = @MaHT, MaNganh = @MaNganh, MaXL = @MaXL
    WHERE MaQTDT = @MaQTDT;
END
GO

-- Xóa một quá trình đào tạo.
IF OBJECT_ID(N'dbo.usp_QTDT_Delete', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTDT_Delete;
GO
CREATE PROCEDURE dbo.usp_QTDT_Delete
    @MaQTDT VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM QTDT WHERE MaQTDT = @MaQTDT;
END
GO

-- Đếm số dòng có mã này (kiểm tra trùng mã trước khi thêm).
IF OBJECT_ID(N'dbo.usp_QTDT_TonTai', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTDT_TonTai;
GO
CREATE PROCEDURE dbo.usp_QTDT_TonTai
    @MaQTDT VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) AS SoDong FROM QTDT WHERE MaQTDT = @MaQTDT;
END
GO

-- Gợi ý mã mới = mã số lớn nhất hiện có + 1 (bỏ qua các mã không phải số).
IF OBJECT_ID(N'dbo.usp_QTDT_MaMoi', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTDT_MaMoi;
GO
CREATE PROCEDURE dbo.usp_QTDT_MaMoi
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ISNULL(MAX(CASE WHEN MaQTDT NOT LIKE '%[^0-9]%' THEN CAST(MaQTDT AS BIGINT) END), 0) + 1 AS MaMoi
    FROM QTDT;
END
GO

-- =============================================================================
-- 4. QUÁ TRÌNH CÔNG TÁC (QTCT)
-- =============================================================================

-- Toàn bộ quá trình công tác (kèm tên nhân viên, phòng ban, chức vụ).
IF OBJECT_ID(N'dbo.usp_QTCT_GetAll', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTCT_GetAll;
GO
CREATE PROCEDURE dbo.usp_QTCT_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT q.*, nv.HoTen, pb.TenPhong, cv.TenCV
    FROM QTCT q
    LEFT JOIN HoSoNV nv ON nv.MaNV = q.MaNV
    LEFT JOIN PhongBan pb ON pb.MaPhong = q.MaPhong
    LEFT JOIN ChucVu cv ON cv.MaCV = q.MaCV
    ORDER BY q.MaQTCT;
END
GO

-- Lọc QTCT theo nhân viên và/hoặc phòng ban.
IF OBJECT_ID(N'dbo.usp_QTCT_TimKiem', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTCT_TimKiem;
GO
CREATE PROCEDURE dbo.usp_QTCT_TimKiem
    @MaNV VARCHAR(10) = NULL,
    @MaPhong VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT q.*, nv.HoTen, pb.TenPhong, cv.TenCV
    FROM QTCT q
    LEFT JOIN HoSoNV nv ON nv.MaNV = q.MaNV
    LEFT JOIN PhongBan pb ON pb.MaPhong = q.MaPhong
    LEFT JOIN ChucVu cv ON cv.MaCV = q.MaCV
    WHERE (@MaNV IS NULL OR q.MaNV = @MaNV)
      AND (@MaPhong IS NULL OR q.MaPhong = @MaPhong)
    ORDER BY q.MaQTCT;
END
GO

-- Thêm một quá trình công tác.
IF OBJECT_ID(N'dbo.usp_QTCT_Insert', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTCT_Insert;
GO
CREATE PROCEDURE dbo.usp_QTCT_Insert
    @MaQTCT VARCHAR(10),
    @MaNV VARCHAR(10),
    @TuNgay DATE = NULL,
    @DenNgay DATE = NULL,
    @MaPhong VARCHAR(10) = NULL,
    @MaCV VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO QTCT (MaQTCT, MaNV, TuNgay, DenNgay, MaPhong, MaCV)
    VALUES (@MaQTCT, @MaNV, @TuNgay, @DenNgay, @MaPhong, @MaCV);
END
GO

-- Sửa một quá trình công tác theo mã.
IF OBJECT_ID(N'dbo.usp_QTCT_Update', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTCT_Update;
GO
CREATE PROCEDURE dbo.usp_QTCT_Update
    @MaQTCT VARCHAR(10),
    @MaNV VARCHAR(10),
    @TuNgay DATE = NULL,
    @DenNgay DATE = NULL,
    @MaPhong VARCHAR(10) = NULL,
    @MaCV VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE QTCT SET MaNV = @MaNV, TuNgay = @TuNgay, DenNgay = @DenNgay,
        MaPhong = @MaPhong, MaCV = @MaCV
    WHERE MaQTCT = @MaQTCT;
END
GO

-- Xóa một quá trình công tác.
IF OBJECT_ID(N'dbo.usp_QTCT_Delete', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTCT_Delete;
GO
CREATE PROCEDURE dbo.usp_QTCT_Delete
    @MaQTCT VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM QTCT WHERE MaQTCT = @MaQTCT;
END
GO

-- Đếm số dòng có mã này (kiểm tra trùng mã trước khi thêm).
IF OBJECT_ID(N'dbo.usp_QTCT_TonTai', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTCT_TonTai;
GO
CREATE PROCEDURE dbo.usp_QTCT_TonTai
    @MaQTCT VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) AS SoDong FROM QTCT WHERE MaQTCT = @MaQTCT;
END
GO

-- Gợi ý mã mới = mã số lớn nhất hiện có + 1 (bỏ qua các mã không phải số).
IF OBJECT_ID(N'dbo.usp_QTCT_MaMoi', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_QTCT_MaMoi;
GO
CREATE PROCEDURE dbo.usp_QTCT_MaMoi
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ISNULL(MAX(CASE WHEN MaQTCT NOT LIKE '%[^0-9]%' THEN CAST(MaQTCT AS BIGINT) END), 0) + 1 AS MaMoi
    FROM QTCT;
END
GO

-- =============================================================================
-- 5. BÁO CÁO
-- =============================================================================

-- Báo cáo QTDT theo nhân viên, trường đào tạo, ngành đào tạo (NULL = không lọc).
IF OBJECT_ID(N'dbo.usp_BaoCao_QTDT', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_BaoCao_QTDT;
GO
CREATE PROCEDURE dbo.usp_BaoCao_QTDT
    @MaNV VARCHAR(10) = NULL,
    @MaTruong VARCHAR(10) = NULL,
    @MaNganh VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT q.MaQTDT, q.MaNV, nv.HoTen, q.TuNgay, q.DenNgay,
           q.MaTruong, tr.TenTruong, q.MaHT, ht.TenHT,
           q.MaNganh, ng.TenNganh, q.MaXL, xl.TenXL
    FROM QTDT q
    LEFT JOIN HoSoNV nv ON nv.MaNV = q.MaNV
    LEFT JOIN TruongDT tr ON tr.MaTruong = q.MaTruong
    LEFT JOIN HinhThuc ht ON ht.MaHT = q.MaHT
    LEFT JOIN NganhDT ng ON ng.MaNganh = q.MaNganh
    LEFT JOIN XepLoai xl ON xl.MaXL = q.MaXL
    WHERE (@MaNV IS NULL OR q.MaNV = @MaNV)
      AND (@MaTruong IS NULL OR q.MaTruong = @MaTruong)
      AND (@MaNganh IS NULL OR q.MaNganh = @MaNganh)
    ORDER BY q.MaQTDT;
END
GO

-- Báo cáo QTCT theo nhân viên và/hoặc phòng ban (NULL = không lọc).
IF OBJECT_ID(N'dbo.usp_BaoCao_QTCT', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_BaoCao_QTCT;
GO
CREATE PROCEDURE dbo.usp_BaoCao_QTCT
    @MaNV VARCHAR(10) = NULL,
    @MaPhong VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT q.MaQTCT, q.MaNV, nv.HoTen, q.TuNgay, q.DenNgay,
           q.MaPhong, pb.TenPhong, q.MaCV, cv.TenCV
    FROM QTCT q
    LEFT JOIN HoSoNV nv ON nv.MaNV = q.MaNV
    LEFT JOIN PhongBan pb ON pb.MaPhong = q.MaPhong
    LEFT JOIN ChucVu cv ON cv.MaCV = q.MaCV
    WHERE (@MaNV IS NULL OR q.MaNV = @MaNV)
      AND (@MaPhong IS NULL OR q.MaPhong = @MaPhong)
    ORDER BY q.MaQTCT;
END
GO

-- Nhân viên có ĐỒNG THỜI ngoại ngữ và chuyên môn đã chọn.
IF OBJECT_ID(N'dbo.usp_BaoCao_NhanVienTheoNgoaiNguChuyenMon', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_BaoCao_NhanVienTheoNgoaiNguChuyenMon;
GO
CREATE PROCEDURE dbo.usp_BaoCao_NhanVienTheoNgoaiNguChuyenMon
    @MaNN VARCHAR(10),
    @MaCM VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT nv.MaNV, nv.HoTen, pb.TenPhong, cv.TenCV, hv.TenHV,
           nn.TenNN, cm.TenCM
    FROM HoSoNV nv
    INNER JOIN NV_NgoaiNgu mapNN ON mapNN.MaNV = nv.MaNV
    INNER JOIN NgoaiNgu nn ON nn.MaNN = mapNN.MaNN
    LEFT JOIN ChuyenMon cm ON cm.MaCM = nv.MaCM
    LEFT JOIN PhongBan pb ON pb.MaPhong = nv.MaPhong
    LEFT JOIN ChucVu cv ON cv.MaCV = nv.MaCV
    LEFT JOIN HocVan hv ON hv.MaHV = nv.MaHV
    WHERE mapNN.MaNN = @MaNN AND nv.MaCM = @MaCM
    ORDER BY nv.MaNV;
END
GO

-- QTDT đã bắt đầu và chưa qua ngày kết thúc (DenNgay NULL coi như chưa kết thúc). Ngày hiện tại lấy từ SQL Server.
IF OBJECT_ID(N'dbo.usp_BaoCao_QTDTChuaKetThuc', N'P') IS NOT NULL DROP PROCEDURE dbo.usp_BaoCao_QTDTChuaKetThuc;
GO
CREATE PROCEDURE dbo.usp_BaoCao_QTDTChuaKetThuc
AS
BEGIN
    SET NOCOUNT ON;
    SELECT q.MaQTDT, q.MaNV, nv.HoTen, q.TuNgay, q.DenNgay,
           q.MaTruong, tr.TenTruong, q.MaHT, ht.TenHT,
           q.MaNganh, ng.TenNganh, q.MaXL, xl.TenXL
    FROM QTDT q
    LEFT JOIN HoSoNV nv ON nv.MaNV = q.MaNV
    LEFT JOIN TruongDT tr ON tr.MaTruong = q.MaTruong
    LEFT JOIN HinhThuc ht ON ht.MaHT = q.MaHT
    LEFT JOIN NganhDT ng ON ng.MaNganh = q.MaNganh
    LEFT JOIN XepLoai xl ON xl.MaXL = q.MaXL
    WHERE q.TuNgay <= CONVERT(date, GETDATE())
      AND (q.DenNgay IS NULL OR q.DenNgay >= CONVERT(date, GETDATE()))
    ORDER BY q.DenNgay, q.MaQTDT;
END
GO

PRINT N'Đã tạo xong các stored procedure của QuanLyNhanSu.';
GO
