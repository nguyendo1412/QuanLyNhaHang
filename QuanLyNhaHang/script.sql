
CREATE DATABASE [QL_NhaHang]

ALTER DATABASE [QL_NhaHang] SET COMPATIBILITY_LEVEL = 110
GO
ALTER DATABASE [QL_NhaHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_NhaHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_NhaHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_NhaHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_NhaHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_NhaHang] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_NhaHang] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_NhaHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_NhaHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_NhaHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_NhaHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_NhaHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_NhaHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_NhaHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_NhaHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_NhaHang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_NhaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_NhaHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_NhaHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_NhaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_NhaHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_NhaHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_NhaHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_NhaHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_NhaHang] SET  MULTI_USER 
GO
ALTER DATABASE [QL_NhaHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_NhaHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_NhaHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_NhaHang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_NhaHang]
GO
/****** Object:  StoredProcedure [dbo].[cbo_Banan]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------LOAD COMBO BÀN ĂN----------------------------------
create proc [dbo].[cbo_Banan]
as
select [MaBan],[TenBan] from [dbo].[BANAN]
GO
/****** Object:  StoredProcedure [dbo].[cbo_Khachhang]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------LOAD COMBO KHÁCH HÀNG----------------------------------
create proc [dbo].[cbo_Khachhang]
as
select [MaKH],[TenKH] from [dbo].[KHACHHANG]
GO
/****** Object:  StoredProcedure [dbo].[cbo_NhanVien]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------LOAD COMBO NHÂN VIÊN--------------------------------
create proc [dbo].[cbo_NhanVien]
as
select [MaNV],[TenNV] from [dbo].[NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[check_user_pass]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------------------------CHECK USER PASSWORD KHI ĐĂNG NHẬP-------------------------------------------------------
create proc [dbo].[check_user_pass]
@user varchar(50),
@pass varchar(50)
as
select count(*) from [dbo].[Acount] where [UserName]=@user and [PassWord]=@pass


GO
/****** Object:  StoredProcedure [dbo].[combo_Monan]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------------LOAD COMBO MÓN ĂN------------------------------------
create proc [dbo].[combo_Monan]
as
select [MaMon],[TenMon] from [dbo].[MONAN]
GO
/****** Object:  StoredProcedure [dbo].[delete_B]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------------------DELETE BÀN-----------------------------------------------
create proc [dbo].[delete_B]
@maban varchar(20)
as
delete from [dbo].[BANAN] where [MaBan]=@maban

GO
/****** Object:  StoredProcedure [dbo].[Delete_CTPTT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------------------DELETE------------------------------------------
create proc [dbo].[Delete_CTPTT]
@sp varchar(20),
@mamon varchar(20)
as
delete from [dbo].[CHITIETPHIEUTHANHTOAN] where [SoPhieu]=@sp and [MaMon]=@mamon


GO
/****** Object:  StoredProcedure [dbo].[Delete_KH]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------------DELETE KHÁCH HÀNG---------------------------------------
create proc [dbo].[Delete_KH]
@makh varchar(20)
as
delete from [dbo].[KHACHHANG] where [MaKH]=@makh



GO
/****** Object:  StoredProcedure [dbo].[delete_MA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------------------DELETE MÓN ĂN--------------------------------------
create proc [dbo].[delete_MA]
@mamon varchar(20)
as
delete from [dbo].[MONAN] where [MaMon]=@mamon

GO
/****** Object:  StoredProcedure [dbo].[delete_NMA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------DELETE NHÓM MÓN ĂN---------------------------------------
create proc [dbo].[delete_NMA]
@manhom varchar(20)
as
delete from [dbo].[NHOMMONAN] where [MaNhom]=@manhom

GO
/****** Object:  StoredProcedure [dbo].[delete_NV]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


---------------------------------------DELETE NHÂN VIÊN------------------------------------------
create proc [dbo].[delete_NV]
@manv varchar(20)
as
delete from [dbo].[NHANVIEN] where [MaNV]=@manv

GO
/****** Object:  StoredProcedure [dbo].[Delete_PTT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_PTT]
@sp varchar(20)
as
delete from [dbo].[PHIEUTHANHTOAN] where [SoPhieu]=@sp

GO
/****** Object:  StoredProcedure [dbo].[insert_B]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------INSERT BÀN-----------------------------------------
create proc [dbo].[insert_B]
@maban varchar(20),
@tenban nvarchar(20)
as
insert into [dbo].[BANAN] values (@maban,@tenban)

GO
/****** Object:  StoredProcedure [dbo].[Insert_CTPTT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------INSERT CHI TIẾT PHIẾU THANH TOÁN---------------------
create proc [dbo].[Insert_CTPTT]
@sp varchar(20),
@mamon varchar(20),
@soluong int
as
insert into [dbo].[CHITIETPHIEUTHANHTOAN] values(@sp,@mamon,@soluong)


GO
/****** Object:  StoredProcedure [dbo].[Insert_KH]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------INSERT KHÁCH HÀNG----------------------------------
create proc [dbo].[Insert_KH]
@makh varchar(20),
@tenkh nvarchar(50),
@ns date,
@gt nvarchar(3),
@dc nvarchar(100),
@dt varchar(20)
as
insert into [dbo].[KHACHHANG] values(@makh,@tenkh,@ns,@gt,@dc,@dt)
GO
/****** Object:  StoredProcedure [dbo].[insert_MA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------------INSERT MÓN ĂN-----------------------------------
create proc [dbo].[insert_MA]
@mamon varchar(20),
@tenmon nvarchar(50),
@dvt nvarchar(10),
@dg float,
@manhom varchar(20)
as
insert into [dbo].[MONAN] values(@mamon,@tenmon,@dvt,@dg,@manhom)

GO
/****** Object:  StoredProcedure [dbo].[insert_NMA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------INSERT NHÓM MÓN ĂN----------------------------------------
create proc [dbo].[insert_NMA]
@manhom varchar(20),
@tennhom nvarchar(50)
as
insert into [dbo].[NHOMMONAN] values (@manhom,@tennhom)

GO
/****** Object:  StoredProcedure [dbo].[insert_NV]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------INSERT NHÂN VIÊN--------------------------------------------
create proc [dbo].[insert_NV]
@manv varchar(20),
@ten nvarchar(50),
@ns date,
@gt nvarchar(3),
@dc nvarchar(100),
@dt varchar(20),
@nvl date,
@luong float
as
insert into [dbo].[NHANVIEN] values(@manv,@ten,@ns,@gt,@dc,@dt,@nvl,@luong)
GO
/****** Object:  StoredProcedure [dbo].[Insert_PTT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_PTT]
(
  @sp varchar(20),
  @ngaylap date,
  @manv varchar(20),
  @makh varchar(20),
  @maban varchar(20)
)
as
insert into [dbo].[PHIEUTHANHTOAN] values(@sp,@ngaylap,0,@manv,@makh,@maban)


GO
/****** Object:  StoredProcedure [dbo].[kiemtra_B]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------KIỂM TRA MÃ BÀN ĐÃ TỒN TẠI HAY CHƯA--------------------------------
create proc [dbo].[kiemtra_B]
@ma varchar(20)
as
select * from [dbo].[BANAN] where [MaBan]=@ma
GO
/****** Object:  StoredProcedure [dbo].[kiemtra_CTPTT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------------KIỂM TRA MÃ PHIẾU VÀ MÃ MÓN CÓ TRÙNG HAY KHÔNG-------------------------
create proc [dbo].[kiemtra_CTPTT]
@sophieu varchar(20),
@mamon varchar(20)
as
select*from [dbo].[CHITIETPHIEUTHANHTOAN] where [MaMon]=@mamon and [SoPhieu]=@sophieu

GO
/****** Object:  StoredProcedure [dbo].[kiemtra_KH]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------Kiểm tra mã trùng------------------------------
create proc [dbo].[kiemtra_KH]
@ma varchar(20)
as
select*from [dbo].[KHACHHANG] where [MaKH]=@ma
GO
/****** Object:  StoredProcedure [dbo].[kiemtra_MA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------KIỂM TRA MÃ MÓN ĂN--------------------------------
create proc [dbo].[kiemtra_MA]
@ma varchar(20)
as
select*from [dbo].[MONAN] where [MaMon]=@ma

GO
/****** Object:  StoredProcedure [dbo].[kiemtra_NMA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------KIỂM TRA MÃ MÓN ĂN TỒN TẠI-------------------------------
create proc [dbo].[kiemtra_NMA]
@ma varchar(20)
as
select *from [dbo].[NHOMMONAN] where [MaNhom]=@ma

GO
/****** Object:  StoredProcedure [dbo].[kiemtra_NV]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-----------------------------KIỂM TRA MÃ NHÂN VIÊN TRÙNG-----------------------------
create proc [dbo].[kiemtra_NV]
@ma varchar(20)
as
select*from [dbo].[NHANVIEN] where [MaNV]=@ma
GO
/****** Object:  StoredProcedure [dbo].[kiemtra_PTT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------KIỂM TRA KHÓA CHÍNH----------------
create proc [dbo].[kiemtra_PTT]
@ma varchar(20)
as
select*from [dbo].[PHIEUTHANHTOAN] where [SoPhieu]=@ma
GO
/****** Object:  StoredProcedure [dbo].[Load_dongia]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------LOAD ĐƠN GIÁ VỚI MÃ MÓN ĂN TRUYỀN VÀO------------------------ 
create proc [dbo].[Load_dongia]
@ma varchar(20)
as
select [DonGia] from [dbo].[MONAN] where [MaMon]=@ma

exec Load_dongia 'MA001'

GO
/****** Object:  StoredProcedure [dbo].[NV_nghihuu]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NV_nghihuu]
as
select [MaNV],[TenNV],[NgaySinh],[GioiTinh],[DiaChi],[DienThoai]
from [dbo].[NHANVIEN] where ((year(getdate())- year(NgaySinh)>=60 and [GioiTinh]='Nam') or((year(getdate())- year(NgaySinh)>=55 and [GioiTinh]=N'Nữ')))

GO
/****** Object:  StoredProcedure [dbo].[select_B]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------BÀN------------------------------------------------------------------------
--------------------LẤY THÔNG TIN BÀN------------------------------
create proc [dbo].[select_B]
as
select*from [dbo].[BANAN]

GO
/****** Object:  StoredProcedure [dbo].[select_CTPTT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[select_CTPTT]
@ma varchar(20)
as
select [SoPhieu], [TenMon],[SoLuong],[DonGia], ([SoLuong]*[DonGia])as [ThanhTien]
from [dbo].[CHITIETPHIEUTHANHTOAN] inner join [dbo].[MONAN] on [dbo].[CHITIETPHIEUTHANHTOAN].[MaMon]=[dbo].[MONAN].MaMon
where [SoPhieu]=@ma

exec select_CTPTT 'SP00000008'
GO
/****** Object:  StoredProcedure [dbo].[select_KH]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------------------------------------KHÁCH HÀNG-------------------------------------------------------------
---------------------------------------Lấy thông tin nhân viên-----------------------------------
create proc [dbo].[select_KH]
as
select*from [dbo].[KHACHHANG]
GO
/****** Object:  StoredProcedure [dbo].[select_MA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------------------------------------------MÓN ĂN-----------------------------------------------------------------------
----------------------LẤY THÔNG TIN MÓN ĂN-------------------------------
create proc [dbo].[select_MA]
as
select[MaMon],[TenMon],[DonViTinh],[DonGia],[TenNhom] from [dbo].[MONAN] inner join [dbo].[NHOMMONAN]
on [dbo].[NHOMMONAN].MaNhom=[dbo].[MONAN].MaNhom
GO
/****** Object:  StoredProcedure [dbo].[select_NMA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------------------------------------------------NHÓM MÓN ĂN----------------------------------------------------------
-------------------------LẤY THÔNG TIN NHÓM MÓN ĂN-----------------------------
create proc [dbo].[select_NMA]
as
select*from [dbo].[NHOMMONAN]
GO
/****** Object:  StoredProcedure [dbo].[select_NV]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------------------------------------------------NHÂN VIÊN---------------------------------------------------
---------------------------LẤY DS NHÂN VIÊN------------------------------------
create proc [dbo].[select_NV]
as
select*from [dbo].[NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[select_PTT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------LẤY THÔNG TIN PHIẾU THANH TOÁN-----------------------
create proc [dbo].[select_PTT]
as
select [SoPhieu],[NgayLap],[TenNV],[TenKH],[TenBan],[TongTien]
from ((([dbo].[PHIEUTHANHTOAN] inner join [dbo].[NHANVIEN] on [dbo].[PHIEUTHANHTOAN].MaNV=[dbo].[NHANVIEN].MaNV)
inner join [dbo].[KHACHHANG] on [dbo].[PHIEUTHANHTOAN].MaKH=[dbo].[KHACHHANG].MaKH)
inner join [dbo].[BANAN] on [dbo].[PHIEUTHANHTOAN].MaBan=[dbo].[BANAN].MaBan)

GO
/****** Object:  StoredProcedure [dbo].[TK_theoquy]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[TK_theoquy]
@nam int
as
SELECT 
        SUM(CASE  WHEN MONTH(NgayLap) in (1,2,3 )THEN [TongTien]
            ELSE 0 END) AS N'Qúy 1',
        SUM(CASE WHEN  MONTH(NgayLap) in ( 4,5,6) THEN [TongTien]
            ELSE 0 END) AS N'Qúy 2',
        SUM(CASE WHEN MONTH(NgayLap) in (7,8,9) THEN [TongTien]
            ELSE 0 END) AS N'Qúy 3',
        SUM(CASE WHEN  MONTH(NgayLap) in (10,11,12) THEN [TongTien]
            ELSE 0 END) AS N'Qúy 4'
from [dbo].[PHIEUTHANHTOAN] where year([NgayLap])=@nam

GO
/****** Object:  StoredProcedure [dbo].[trung_mamon]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------KHI TRÙNG SỐ PHIẾU VÀ MÃ MÓN ĂN THÌ TỰ ĐỘNG CỘNG THÊM SỐ LƯỢNG VÀO CHI TIẾT PHIẾU ĐÃ CÓ----------------
create proc [dbo].[trung_mamon]
@sp varchar(20),
@mamon varchar(20),
@soluong int
as
update [dbo].[CHITIETPHIEUTHANHTOAN] set [SoLuong]=[SoLuong]+@soluong where [SoPhieu]=@sp and [MaMon]=@mamon

GO
/****** Object:  StoredProcedure [dbo].[update_B]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------UPDATE BÀN-----------------------------------------
create proc [dbo].[update_B]
@maban varchar(20),
@tenban nvarchar(20)
as
update [dbo].[BANAN] set [TenBan]=@tenban where [MaBan]=@maban
GO
/****** Object:  StoredProcedure [dbo].[Update_CTPTT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------------UPDATE-----------------------------------------------
create proc [dbo].[Update_CTPTT]
@sp varchar(20),
@mamon varchar(20),
@soluong int
as
update [dbo].[CHITIETPHIEUTHANHTOAN] set [MaMon]=@mamon, [SoLuong]=@soluong where [SoPhieu]=@sp 


GO
/****** Object:  StoredProcedure [dbo].[Update_KH]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------------------UPDATE KHÁCH HÀNG-----------------------------------
create proc [dbo].[Update_KH]
@makh varchar(20),
@tenkh nvarchar(50),
@ns date,
@gt nvarchar(3),
@dc nvarchar(100),
@dt varchar(20)
as
update [dbo].[KHACHHANG] set [TenKH]=@tenkh,[NgaySinh]=@ns,[GioiTinh]=@gt,[DiaChi]=@dc,[DienThoai]=@dt where [MaKH]=@makh


GO
/****** Object:  StoredProcedure [dbo].[update_MA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------------UPDATE MÓN ĂN---------------------------------
create proc [dbo].[update_MA]
@mamon varchar(20),
@tenmon nvarchar(50),
@dvt nvarchar(10),
@dg float,
@manhom varchar(20)
as
update [dbo].[MONAN] set [TenMon]=@tenmon,[DonViTinh]=@dvt,[DonGia]=@dg,[MaNhom]=@manhom where [MaMon]=@mamon

GO
/****** Object:  StoredProcedure [dbo].[update_NMA]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


------------------------------UPDATE NHÓM MÓN ĂN-----------------------------------------
create proc [dbo].[update_NMA]
@manhom varchar(20),
@tennhom nvarchar(50)
as
update[dbo].[NHOMMONAN] set [TenNhom]=@tennhom where [MaNhom]=@manhom
GO
/****** Object:  StoredProcedure [dbo].[update_NV]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------UPDATE NHÂN VIÊN--------------------------------------
create proc [dbo].[update_NV]
@manv varchar(20),
@ten nvarchar(50),
@ns date,
@gt nvarchar(3),
@dc nvarchar(100),
@dt varchar(20),
@nvl date,
@luong float
as
update [dbo].[NHANVIEN] set [TenNV]=@ten,[NgaySinh]=@ns,[GioiTinh]=@gt,[DiaChi]=@dc,[DienThoai]=@dt,[NgayVaoLam]=@nvl,[Luong]=@luong
where [MaNV]=@manv

GO
/****** Object:  StoredProcedure [dbo].[Update_PT]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_PT]
(
		@sp varchar(20),
		@ngaylap date,
		@manv varchar(20),
	    @makh varchar(20),
		@maban varchar(20)
)
as
update [dbo].[PHIEUTHANHTOAN] set [NgayLap]=@ngaylap,[MaNV]=@manv,[MaKH]=@makh,[MaBan]=@maban where [SoPhieu]=@sp

GO
/****** Object:  UserDefinedFunction [dbo].[fcgetBanAn]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fcgetBanAn]()
returns varchar(5)
as
begin
    declare @MaBan varchar(5)
	declare @MaxMaBan varchar(5)
	declare @Max float

	select @MaBan=MAX(MaBan) from BANAN
	if exists (select MaBan from BanAN)
						set @Max = CONVERT(float, SUBSTRING(@MaBan,3,3)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaBan='BA' + '00' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @MaBan='BA' + '0' + Convert(varchar(2),@Max)
			else
						set @MaBan ='BA' +  Convert(varchar(3),@Max)
			Return @MaBan
end
GO
/****** Object:  UserDefinedFunction [dbo].[fcgetMaKH]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------MÃ KHÁCH HÀNG--------------------------------------
create function [dbo].[fcgetMaKH]()
returns varchar(20)
as
begin
      declare @MaKH varchar(20)
	  declare @MaxMaKH varchar(20)
	  declare @Max float

	  select @MaxMaKH=MAX(MaKH) from KHACHHANG
	  if exists (select MaKH from KHACHHANG )
	             set  @Max = CONVERT(float, SUBSTRING(@MaxMaKH,3,8)) + 1
	  else
	           set @Max=1
	  if (@Max < 10)
						set @MaKH='KH' + '0000000' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @MaKH='KH' + '000000' + Convert(varchar(2),@Max)
			else
			if (@Max < 1000)
						set @MaKH='KH' + '00000' + Convert(varchar(3),@Max)
			else
			if (@Max < 10000)
						set @MaKH='KH' + '0000' + Convert(varchar(4),@Max)
			else
			if (@Max < 100000)
						set @MaKH ='KH' + '000' + Convert(varchar(5),@Max)
			else
			if (@Max < 1000000)
						set @MaKH  ='KH' + '00' + Convert(varchar(6),@Max)
			else	
			if (@Max < 10000000)
						set @MaKH ='KH' + '0' + Convert(varchar(7),@Max)
			else
						set @MaKH ='KH' +  Convert(varchar(8),@Max)
			Return @MaKH
end

GO
/****** Object:  UserDefinedFunction [dbo].[fcgetMaMonAn]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fcgetMaMonAn]()
returns varchar(5)
as
begin
    declare @MaMon varchar(5)
	declare @MaxMaMon varchar(5)
	declare @Max float

	select @MaxMaMon=MAX(MaMon) from MONAN

	if exists (select MaMon from MONAN)
						set @Max = CONVERT(float, SUBSTRING(@MaxMaMon,3,3)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaMon='MA' + '00' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @MaMon='MA' + '0' + Convert(varchar(2),@Max)
			else
						set @MaMon ='MA' +  Convert(varchar(3),@Max)
			Return @MaMon
end
GO
/****** Object:  UserDefinedFunction [dbo].[fcgetMaNhom]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fcgetMaNhom]()
returns varchar(5)
as
begin
    declare @MaNhom varchar(5)
	declare @MaxMaNhomn varchar(5)
	declare @Max float

	select @MaNhom=MAX(MaNhom) from NHOMMONAN

	if exists (select MaNhom from NHOMMONAN)
						set @Max = CONVERT(float, SUBSTRING(@MaNhom,3,3)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaNhom='MM' + '00' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @MaNhom='MM' + '0' + Convert(varchar(2),@Max)
			else
						set @MaNhom ='MM' +  Convert(varchar(3),@Max)
			Return @MaNhom
end
GO
/****** Object:  UserDefinedFunction [dbo].[fcgetMaNV]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fcgetMaNV]()
returns varchar(10)
as
begin 
   declare @MaNV varchar(10)
   declare @MaxMaNV varchar(10)
   declare @Max float

   select @MaxMaNV=MAX(MaNV) from NHANVIEN

   if exists (select MaNV from NHANVIEN)
						set @Max = CONVERT(float, SUBSTRING(@MaxMaNV,3,8)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @MaNV='NV' + '0000000' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @MaNV='NV' + '000000' + Convert(varchar(2),@Max)
			else
			if (@Max < 1000)
						set @MaNV='NV' + '00000' + Convert(varchar(3),@Max)
			else
			if (@Max < 10000)
						set @MaNV='NV' + '0000' + Convert(varchar(4),@Max)
			else
			if (@Max < 100000)
						set @MaNV ='NV' + '000' + Convert(varchar(5),@Max)
			else
			if (@Max < 1000000)
						set @MaNV  ='NV' + '00' + Convert(varchar(6),@Max)
			else	
			if (@Max < 10000000)
						set @MaNV ='NV' + '0' + Convert(varchar(7),@Max)
			else
						set @MaNV ='NV' +  Convert(varchar(8),@Max)
			Return @MaNV
end

GO
/****** Object:  UserDefinedFunction [dbo].[fcgetSoPhieu]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fcgetSoPhieu]()
returns varchar(10)
as
begin
      declare @MaSP varchar(10)
	  declare @MaxMaSP varchar(10)
	  declare @Max float

	  select @MaxMaSP=MAX(SoPhieu)from PHIEUTHANHTOAN
	  if exists (select SoPhieu from PHIEUTHANHTOAN )
	             set  @Max = CONVERT(float, SUBSTRING(@MaxMaSP,3,8)) + 1
	  else
	           set @Max=1
	  if (@Max < 10)
						set @MaSP='SP' + '0000000' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @MaSP='SP' + '000000' + Convert(varchar(2),@Max)
			else
			if (@Max < 1000)
						set @MaSP='SP' + '00000' + Convert(varchar(3),@Max)
			else
			if (@Max < 10000)
						set @MaSP='SP' + '0000' + Convert(varchar(4),@Max)
			else
			if (@Max < 100000)
						set @MaSP ='SP' + '000' + Convert(varchar(5),@Max)
			else
			if (@Max < 1000000)
						set @MaSP  ='SP' + '00' + Convert(varchar(6),@Max)
			else	
			if (@Max < 10000000)
						set @MaSP ='SP' + '0' + Convert(varchar(7),@Max)
			else
						set @MaSP ='SP' +  Convert(varchar(8),@Max)
			Return @MaSP
end
GO
/****** Object:  Table [dbo].[Acount]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Acount](
	[UserName] [varchar](100) NOT NULL,
	[PassWord] [varchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BANAN]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANAN](
	[MaBan] [varchar](20) NOT NULL,
	[TenBan] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUTHANHTOAN]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUTHANHTOAN](
	[SoPhieu] [varchar](20) NOT NULL,
	[MaMon] [varchar](20) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPhieu] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [varchar](20) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONAN](
	[MaMon] [varchar](20) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[DonGia] [float] NULL,
	[MaNhom] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](20) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](20) NULL,
	[NgayVaoLam] [date] NULL,
	[Luong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMMONAN]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMMONAN](
	[MaNhom] [varchar](20) NOT NULL,
	[TenNhom] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUTHANHTOAN]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUTHANHTOAN](
	[SoPhieu] [varchar](20) NOT NULL,
	[NgayLap] [date] NULL,
	[TongTien] [float] NULL,
	[MaNV] [varchar](20) NULL,
	[MaKH] [varchar](20) NULL,
	[MaBan] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[DSNV_nghihuu]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DSNV_nghihuu]
as
select [MaNV],[TenNV],[NgaySinh],[GioiTinh],[DiaChi],[DienThoai]
from [dbo].[NHANVIEN] 

GO
/****** Object:  View [dbo].[TK_QUY]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TK_QUY]
as
SELECT 
        SUM(CASE  WHEN MONTH(NgayLap) in (1,2,3 )THEN [TongTien]
            ELSE 0 END) AS N'Qúy 1',
        SUM(CASE WHEN  MONTH(NgayLap) in ( 4,5,6) THEN [TongTien]
            ELSE 0 END) AS N'Qúy 2',
        SUM(CASE WHEN MONTH(NgayLap) in (7,8,9) THEN [TongTien]
            ELSE 0 END) AS N'Qúy 3',
        SUM(CASE WHEN  MONTH(NgayLap) in (10,11,12) THEN [TongTien]
            ELSE 0 END) AS N'Qúy 4'
from [dbo].[PHIEUTHANHTOAN] 
GO
/****** Object:  View [dbo].[TT_HD]    Script Date: 01/10/2020 12:49:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------------------------------TÌM KIẾM HÓA ĐƠN---------------------------------------------------------
create view [dbo].[TT_HD]
as
select [SoPhieu],[NgayLap],[TenNV],[TenKH],[TenBan],[TongTien]
from ((([dbo].[PHIEUTHANHTOAN] inner join [dbo].[NHANVIEN] on [dbo].[PHIEUTHANHTOAN].MaNV=[dbo].[NHANVIEN].MaNV)
inner join [dbo].[KHACHHANG] on [dbo].[PHIEUTHANHTOAN].MaKH=[dbo].[KHACHHANG].MaKH)
inner join [dbo].[BANAN] on [dbo].[PHIEUTHANHTOAN].MaBan=[dbo].[BANAN].MaBan)

GO
INSERT [dbo].[Acount] ([UserName], [PassWord], [Type]) VALUES (N'NV00000001', N'123456', 0)
INSERT [dbo].[Acount] ([UserName], [PassWord], [Type]) VALUES (N'NV00000002', N'123456', 0)
INSERT [dbo].[Acount] ([UserName], [PassWord], [Type]) VALUES (N'NV00000003', N'123456', 0)
INSERT [dbo].[Acount] ([UserName], [PassWord], [Type]) VALUES (N'NV00000004', N'123456', 0)
INSERT [dbo].[BANAN] ([MaBan], [TenBan]) VALUES (N'BA001', N'Bàn 1')
INSERT [dbo].[BANAN] ([MaBan], [TenBan]) VALUES (N'BA002', N'Bàn 2')
INSERT [dbo].[BANAN] ([MaBan], [TenBan]) VALUES (N'BA003', N'Bàn 3')
INSERT [dbo].[BANAN] ([MaBan], [TenBan]) VALUES (N'BA004', N'Bàn 4')
INSERT [dbo].[BANAN] ([MaBan], [TenBan]) VALUES (N'BA005', N'Bàn 5')
INSERT [dbo].[BANAN] ([MaBan], [TenBan]) VALUES (N'BA006', N'Bàn 6')
INSERT [dbo].[BANAN] ([MaBan], [TenBan]) VALUES (N'BA007', N'Bàn 7')
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000001', N'MA001', 4)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000001', N'MA006', 4)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000001', N'MA020', 4)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000002', N'MA004', 8)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000002', N'MA009', 8)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000002', N'MA013', 8)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000002', N'MA021', 8)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000003', N'MA003', 5)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000003', N'MA007', 5)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000003', N'MA012', 5)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000003', N'MA023', 5)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000004', N'MA023', 3)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000005', N'MA020', 5)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000006', N'MA015', 3)
INSERT [dbo].[CHITIETPHIEUTHANHTOAN] ([SoPhieu], [MaMon], [SoLuong]) VALUES (N'SP00000007', N'MA015', 5)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000001', N'Phạm Quốc Nhiên', CAST(0xF1230B00 AS Date), N'Nam', N'Bến Tre', N'0379008219')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000002', N'Trương Quốc Phong', CAST(0xCF230B00 AS Date), N'Nam', N'TPHCM', N'0966506097')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000003', N'Phạm Quốc Bảo', CAST(0xCE230B00 AS Date), N'Nam', N'Đà Nẵng', N'0984568079')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000004', N'Nguyễn Thị Hạnh', CAST(0xE1080B00 AS Date), N'Nam', N'Thanh Xuân, Hà Nội', N'0937687967')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000005', N'Phạm Quốc Nhiên', CAST(0xF1230B00 AS Date), N'Nam', N'Bến Tre', N'0379008219')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000006', N'Trương Quốc Phong', CAST(0xCF230B00 AS Date), N'Nam', N'TPHCM', N'0966506097')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000007', N'Phạm Quốc Bảo', CAST(0xCE230B00 AS Date), N'Nam', N'Đà Nẵng', N'0984568079')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000008', N'Nguyễn Thị Hạnh', CAST(0xE1080B00 AS Date), N'Nam', N'Thanh Xuân, Hà Nội', N'0937687967')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000009', N'Trần Minh Quang', CAST(0xF0230B00 AS Date), N'Nam', N'Tây Ninh', N'0904703097')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000010', N'Nguyễn Trọng Đức', CAST(0xCE080B00 AS Date), N'Nam', N'Vĩnh Long', N'0954302798')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai]) VALUES (N'KH00000011', N'Trần Minh Tuấn', CAST(0x201E0B00 AS Date), N'Nam', N'An Giang', N'0398765432')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA001', N'Súp gà chua cay', N'Bát', 30000, N'MM001')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA002', N'Cá hồi táo trộn', N'Đĩa', 40000, N'MM001')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA003', N'Súp nấm cua', N'Bát', 30000, N'MM001')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA004', N'Burger cá ngừ', N'Đĩa', 50000, N'MM001')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA005', N'Chả giò cà ri', N'Đĩa', 30000, N'MM001')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA006', N'Thịt bò áp chảo', N'Đĩa', 150000, N'MM002')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA007', N'Gà kho sả', N'Đĩa', 100000, N'MM002')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA008', N'ỐC om chuối', N'Bát', 100000, N'MM002')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA009', N'Gà sốt phô mai', N'Nồi', 125000, N'MM002')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA010', N'Cá chép om dưa', N'Đĩa', 150000, N'MM002')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA011', N'Mực nướng sốt muối ớt', N'Đĩa', 70000, N'MM003')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA012', N'Bò nướng sốt ngũ vị', N'Đĩa', 70000, N'MM003')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA013', N'Thịt ba chỉ sốt riềng mẻ', N'Đĩa', 70000, N'MM003')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA014', N'Sữa bí đỏ đậu xanh', N'Ly', 25000, N'MM004')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA015', N'Bánh Mochi', N'Đĩa', 45000, N'MM004')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA016', N'Chè khoai', N'Bát', 25000, N'MM004')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA017', N'Kem dừa', N'Que', 25000, N'MM004')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA018', N'Sorbet dưa hấu sữa chua', N'Ly', 50000, N'MM004')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA019', N'Nước ép cà rốt', N'Ly', 20000, N'MM005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA020', N'Trà sữa mattcha trân châu', N'Ly', 20000, N'MM005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA021', N'Sữa dâu', N'Ly', 20000, N'MM005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA022', N'Trà trái cây', N'Tách', 20000, N'MM005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'MA023', N'Sinh tố đào chanh', N'Ly', 20000, N'MM005')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [NgayVaoLam], [Luong]) VALUES (N'NV00000001', N'Phạm Quốc Nhiên', CAST(0xF1230B00 AS Date), N'Nam', N'Bến TRe', N'0379008219', CAST(0x98390B00 AS Date), 5000000)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [NgayVaoLam], [Luong]) VALUES (N'NV00000002', N'Phạm Quốc Bảo', CAST(0xCE230B00 AS Date), N'Nam', N'Đà Nẵng', N'0943421892', CAST(0xF72F0B00 AS Date), 6000000)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [NgayVaoLam], [Luong]) VALUES (N'NV00000003', N'PTrương Quốc Phong', CAST(0xCF230B00 AS Date), N'Nam', N'TPHCM', N'0966350742', CAST(0x50350B00 AS Date), 4500000)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [NgayVaoLam], [Luong]) VALUES (N'NV00000004', N'Trần Minh Quang', CAST(0xB3230B00 AS Date), N'Nam', N'Tây Ninh', N'0965045730', CAST(0x4A330B00 AS Date), 3000000)
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'MM001', N'Món khai vị')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'MM002', N'Món ăn chính')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'MM003', N'Món ăn thêm')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'MM004', N'Món tráng miệng')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'MM005', N'Thức uống')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000001', CAST(0x98390B00 AS Date), 800000, N'NV00000001', N'KH00000005', N'BA004')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000002', CAST(0xEF3B0B00 AS Date), 2120000, N'NV00000003', N'KH00000004', N'BA001')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000003', CAST(0xEE390B00 AS Date), 1100000, N'NV00000003', N'KH00000004', N'BA001')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000004', CAST(0x243A0B00 AS Date), 60000, N'NV00000003', N'KH00000004', N'BA003')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000005', CAST(0x98390B00 AS Date), 100000, N'NV00000001', N'KH00000001', N'BA005')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000006', CAST(0x8A3A0B00 AS Date), 135000, N'NV00000003', N'KH00000003', N'BA002')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000007', CAST(0xEE390B00 AS Date), 225000, N'NV00000003', N'KH00000004', N'BA001')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000008', CAST(0x243A0B00 AS Date), NULL, N'NV00000003', N'KH00000004', N'BA003')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000009', CAST(0x98390B00 AS Date), NULL, N'NV00000001', N'KH00000001', N'BA005')
INSERT [dbo].[PHIEUTHANHTOAN] ([SoPhieu], [NgayLap], [TongTien], [MaNV], [MaKH], [MaBan]) VALUES (N'SP00000010', CAST(0x8D3A0B00 AS Date), NULL, N'NV00000001', N'KH00000003', N'BA004')
ALTER TABLE [dbo].[Acount] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHANHTOAN]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[MONAN] ([MaMon])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTHANHTOAN]  WITH CHECK ADD FOREIGN KEY([SoPhieu])
REFERENCES [dbo].[PHIEUTHANHTOAN] ([SoPhieu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MONAN]  WITH CHECK ADD FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMMONAN] ([MaNhom])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[BANAN] ([MaBan])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
USE [master]
GO
ALTER DATABASE [QL_NhaHang] SET  READ_WRITE 
GO
