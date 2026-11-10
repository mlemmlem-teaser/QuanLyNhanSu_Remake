create database QuanLyNhanSu;
use QuanLyNhanSu;

create table GioiTinh (
    MaGT varchar(10) primary key,
    TenGT varchar(50)
);

create table ChucVu (
    MaCV varchar(10) primary key,
    TenCV varchar(50)
);

create table DanToc (
    MaDT varchar(10) primary key,
    TenDT varchar(50)
);

create table TonGiao (
    MaTG varchar(10) primary key,
    TenTG varchar(50),
    GhiChu varchar(100)
);

create table NoiSinh (
    MaNS varchar(10) primary key,
    TenNS varchar(50)
);

create table NgoaiNgu (
    MaNN varchar(10) primary key,
    TenNN varchar(50)
);

create table PhongBan (
    MaPhong varchar(10) primary key,
    TenPhong varchar(50),
    DienThoai varchar(20)
);

create table HocVan (
    MaHV varchar(10) primary key,
    TenHV varchar(50)
);

create table ChuyenMon (
    MaCM varchar(10) primary key,
    TenCM varchar(50)
);

create table TruongDT (
    MaTruong varchar(10) primary key,
    TenTruong varchar(100),
    DiaChi varchar(100),
    DienThoai varchar(20)
);

create table HinhThuc (
    MaHT varchar(10) primary key,
    TenHT varchar(50)
);

create table NganhDT (
    MaNganh varchar(10) primary key,
    TenNganh varchar(50)
);

create table XepLoai (
    MaXL varchar(10) primary key,
    TenXL varchar(50)
);

create table HoSoNV (
    MaNV varchar(10) primary key,
    HoTen varchar(50),
    MaGT varchar(10),
    MaCV varchar(10),
    MaDT varchar(10),
    MaTG varchar(10),
    NgaySinh date,
    QueQuan varchar(100),
    MaNS varchar(10),
    DiaChi varchar(100),
    DienThoai varchar(20),
    SoCMND varchar(20),
    MaPhong varchar(10),
    MaHV varchar(10),
    MaCM varchar(10),
    VoChong varchar(50),
    Con varchar(50),
    foreign key (MaGT) references GioiTinh(MaGT),
    foreign key (MaCV) references ChucVu(MaCV),
    foreign key (MaDT) references DanToc(MaDT),
    foreign key (MaTG) references TonGiao(MaTG),
    foreign key (MaNS) references NoiSinh(MaNS),
    foreign key (MaPhong) references PhongBan(MaPhong),
    foreign key (MaHV) references HocVan(MaHV),
    foreign key (MaCM) references ChuyenMon(MaCM)
);

create table NV_NgoaiNgu (
    MaNV varchar(10),
    MaNN varchar(10),
    primary key (MaNV, MaNN),
    foreign key (MaNV) references HoSoNV(MaNV),
    foreign key (MaNN) references NgoaiNgu(MaNN)
);

create table QTDT (
    MaQTDT varchar(10) primary key,
    MaNV varchar(10),
    TuNgay date,
    DenNgay date,
    MaTruong varchar(10),
    MaHT varchar(10),
    MaNganh varchar(10),
    MaXL varchar(10),
    foreign key (MaNV) references HoSoNV(MaNV),
    foreign key (MaTruong) references TruongDT(MaTruong),
    foreign key (MaHT) references HinhThuc(MaHT),
    foreign key (MaNganh) references NganhDT(MaNganh),
    foreign key (MaXL) references XepLoai(MaXL)
);

create table QTCT (
    MaQTCT varchar(10) primary key,
    MaNV varchar(10),
    TuNgay date,
    DenNgay date,
    MaPhong varchar(10),
    MaCV varchar(10),
    foreign key (MaNV) references HoSoNV(MaNV),
    foreign key (MaPhong) references PhongBan(MaPhong),
    foreign key (MaCV) references ChucVu(MaCV)
);