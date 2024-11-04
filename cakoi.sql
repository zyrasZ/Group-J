CREATE TABLE CaCoi (
    IdcaKoi INT IDENTITY(1,1) PRIMARY KEY,
    TenLoai NVARCHAR(255),
    Gia INT,
    Tuoi NVARCHAR(50),
    HinhAnh NVARCHAR(MAX),
    SoLuong INT,
    Idloai INT,
    SupId INT
);

CREATE TABLE ChucVu (
    Idcv INT PRIMARY KEY,
    TenChucVu NVARCHAR(50)
);

CREATE TABLE DonHang (
    IddonHang INT IDENTITY(1,1) PRIMARY KEY,
    Idkh INT,
    NgayMua DATE,
    NgayGiao DATE,
    TrangThai NVARCHAR(10)
);

CREATE TABLE DonHangChiTiet (
    IddonHang INT,
    IdcaKoi INT,
    SoLuong INT,
    PRIMARY KEY (IddonHang, IdcaKoi),
    FOREIGN KEY (IddonHang) REFERENCES DonHang(IddonHang),
    FOREIGN KEY (IdcaKoi) REFERENCES CaCoi(IdcaKoi)
);

CREATE TABLE KhachHang (
    Idkh INT IDENTITY(1,1) PRIMARY KEY,
    TenTaiKhoan NVARCHAR(50),
    MatKhau NVARCHAR(50),
    Hoten NVARCHAR(50),
    Ngaysinh DATE,
    Gioitinh CHAR(3),
    Sdt VARCHAR(11),
    Email NVARCHAR(50)
);

CREATE TABLE Loai (
    Id INT PRIMARY KEY,
    Name NVARCHAR(50)
);

CREATE TABLE NhanVien (
    Idnv INT IDENTITY(1,1) PRIMARY KEY,
    TenTaiKhoan NVARCHAR(50),
    MatKhau NVARCHAR(50),
    Hoten NVARCHAR(50),
    Ngaysinh DATE,
    Gioitinh CHAR(3),
    Sdt VARCHAR(11),
    Email NVARCHAR(50)
);

CREATE TABLE Nsx (
    Id INT PRIMARY KEY,
    Ten NVARCHAR(100),
    Sdt VARCHAR(11)
);
