---------------------------------------------TẠO DATABASE------------------------------------
create database QL_NhaHang;
use QL_NhaHang
go

-----------------------------TẠO BẢNG VÀ CÁC TRIGGER RÀNG BUỘC------------------------------

create table KHACHHANG
( 
            MaKH              char(10)  primary key ,
            TenKH             nvarchar(50),
            NgaySinh          date,
            GioiTinh          nvarchar(3),
            DiaChi            nvarchar(100),
            DienThoai         varchar(20),
			TheTV			  char (10),
			DiemTL			  float
 );
 

 create table NHANVIEN
 (
            MaNV              char(10) primary key,
            TenNV             nvarchar(50),
            NgaySinh          date,
            GioiTinh          nvarchar(3),
            DiaChi            nvarchar(100),
			DienThoai         varchar(20),
            NgayVaoLam        date,
            Luong             float
 );


  create table BANAN
 (
              MaBan           char(10) primary key,
              TenBan          nvarchar(50)
 );

  create table NHOMMONAN
 (
              MaNhom            char(10) primary key,
              TenNhom           nvarchar(50)
 );

 create table MONAN
 (
              MaMon              char(10) primary key,
              TenMon             nvarchar(50),
              DonViTinh          nvarchar(10),
              DonGia             float,
              MaNhom             char(10) references NHOMMONAN(MaNhom) on delete set null on update set null
);


create table PHIEUTHANHTOAN
( 
              SoPhieu             char(10) primary key,
              NgayLap             date ,
              TongTien            float,
              MaNV                char(10) references NHANVIEN(MaNV) on delete no action on update no action,
              MaKH                char(10) references KHACHHANG(MaKH) on delete no action on update no action,
			  MaBan               char(10) references BANAN(MaBan) on delete no action on update no action

);


  create table HOADON
 (
              MaHD           char(10) primary key,
              MaNV           char(50),
			  MaKH			 char(10),
			  MaBan			 char(10),
			  TongTien		 money,
			  NgayLap		date
 );
 
  create table CHITIET_HD
 (
              MaHD         char(10) primary key,
              MaMon        char(10),
			  TenMon	   nvarchar(50),
			  SoLuong	    int,
			  TongMon		int,

 );


 ---------------------------------Nhập Liệu---------------------------------

 ------------------------BẢNG Nhóm MÓN ĂN-------------------------------

 INSERT INTO NHOMMONAN VALUES
('N00001',N'Nhóm Món Nướng'),
('N00002',N'Nhóm Món Tráng Miệng'),
('N00003',N'Nhóm Món Lẩu'),
('N00004',N'Nhóm Món Cơm Quê'),
('N00005',N'Nhóm Món Hàn Quốc'),
('N00006',N'Nhóm Món Đặc Sản'),
('N00007',N'Nhóm Thức Uống '),
('N00008',N'Nhóm Món Thêm')
 -------------------------------BẢNG Bàn Ăn-------------------------------
  INSERT INTO BANAN VALUES
 ('MB00001',N'Bàn Số 1'),
 ('MB00002',N'Bàn Số 2'),
 ('MB00003',N'Bàn Số 3'),
 ('MB00004',N'Bàn Số 4'),
 ('MB00005',N'Bàn Số 5'),
 ('MB00006',N'Bàn Số 6'),
 ('MB00007',N'Bàn Số 7'),
 ('MB00008',N'Bàn Số 8'),
 ('MB00009',N'Bàn Số 9'),
 ('MB00010',N'Bàn Số 10'),
 ('MB00011',N'Bàn Số 11'),
 ('MB00012',N'Bàn Số 12')
  -------------------------------BẢNG Món Ăn-------------------------------
INSERT INTO MONAN VALUES
('M00001',N'Bia Heniken','Lon','25000','N00007'),
('M00002',N'Bia Tiger','Chai','25000','N00007'),
('M00003',N'Sting','Lon','25000','N00007'),
('M00004',N'PépSi','Lon','25000','N00007'),
('M00005',N'Nước Cam Ép','Ly','25000','N00007'),
('M00006',N'Nước Trà Tắc','Ly','25000','N00007'),

('M00007',N'Dưa Hấu','kg','50000','N00002'),
('M00008',N'Rau Câu Dừa',N'Dĩa','25000','N00007'),
('M00009',N'Nho Mỹ','kg','100000','N00007'),
('M00010',N'Ỗi','kg','25000','N00007'),
('M00011',N'Chè khoai',N'Bát','25000','N00007'),

('M00012',N'Mì gói thêm',N'Vắt','25000','N00008'),
('M00013',N'Nước lẩu thêm',N'Bát','25000','N00008'),
('M00014',N'Bún thêm',N'Đãi','25000','N00008'),
('M00015',N'Thịt thêm',N'Đĩa','25000','N00008'),
('M00016',N'Hải sản thêm',N'Đĩa','25000','N00008'),


