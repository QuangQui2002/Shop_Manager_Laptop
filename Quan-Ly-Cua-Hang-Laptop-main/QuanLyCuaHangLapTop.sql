
CREATE DATABASE QUANLYCUAHANGLAPTOP

DROP DATABASE QUANLYCUAHANGLAPTOP

CREATE TABLE KHACHHANG
(
	MAKH NVARCHAR(10) PRIMARY KEY,
	TENKH NVARCHAR(30),
	DIACHI NVARCHAR(30),
	DIENTHOAI NVARCHAR(20),
	EMAIL NVARCHAR(30),
	TRANGTHAI INT
)

CREATE TABLE NHANVIEN
(
	MANV NVARCHAR(10) PRIMARY KEY,
	HOTENNV NVARCHAR(30),	
	GIOITINH NVARCHAR(5),
	NGAYSINH DATE,
	DIACHI NVARCHAR(50),
	DIENTHOAI NVARCHAR(20),
	EMAIL CHAR(30),
	CHUCVU NVARCHAR(30),		
	NGAYVAOLAM DATETIME,
	TENNH NVARCHAR(30),
	SOTK INT,
	LUONG INT,
	TRANGTHAI INT
)

CREATE TABLE NHACUNGCAP
(
	MANCC NVARCHAR(10) PRIMARY KEY,
	TENNCC NVARCHAR(30),
	DIENTHOAI NVARCHAR(20),
	TENNH NVARCHAR(30),
	SOTK INT,
	DIACHI NVARCHAR(100),
	TRANGTHAI INT
)

CREATE TABLE SANPHAM
(
	MASP NVARCHAR(10) PRIMARY KEY,
	TENSP NVARCHAR(30),	
	MALOAI NVARCHAR(10),
	MANCC NVARCHAR(10),
	THOIGIANBH INT,
	GIANHAP DECIMAL,
	GIABAN DECIMAL,
	TRANGTHAI INT,
	HINH NVARCHAR(MAX)
)
        
CREATE TABLE LOAISP
(
	MALOAI NVARCHAR(10) PRIMARY KEY,
	TENLOAI NVARCHAR(30),
	TRANGTHAI INT
)
CREATE TABLE KICHTHUOC
(
	MASIZE NVARCHAR(10) PRIMARY KEY,
	TENSIZE NVARCHAR(30),
	TRANGTHAI INT
)
CREATE TABLE MAUSP
(
	MAMAU NVARCHAR(10) PRIMARY KEY,
	TENMAU NVARCHAR(30),
	TRANGTHAI INT
)



CREATE TABLE CHITIETSANPHAM
(
	MACTSP NVARCHAR(10),
	MASP NVARCHAR(10),
	
	MASIZE NVARCHAR(10),
	MAMAU NVARCHAR(10),
	MALOAI NVARCHAR(10),
	MOTA NVARCHAR(100),

	PRIMARY KEY(MASP,MALOAI,MASIZE,MAMAU)
)

CREATE TABLE HOADONNHAP
(
	MAHDN NVARCHAR(10) PRIMARY KEY,
	MANCC NVARCHAR(10),
	MANV NVARCHAR(10),	
	TONGTIEN INT,
	NGAYLAP DATETIME,
	TRANGTHAI INT
)

CREATE TABLE CHITIETHOADONNHAP
(
	MAHDN NVARCHAR(10),
	MASP NVARCHAR(30),
	DONGIA INT,
	SOLUONG INT,
	THANHTIEN INT,
	TRANGTHAI INT,
	PRIMARY KEY(MAHDN,MASP)
)
 
CREATE TABLE HOADONBAN
(
	MAHDB NVARCHAR(10) PRIMARY KEY,
	MAKH NVARCHAR(10),
	MANV NVARCHAR(10),
	NGAYLAP DATETIME,
	TONGTIEN INT,
	TRANGTHAI INT
)

CREATE TABLE CHITIETHOADONBAN
(
	MAHDB NVARCHAR(10), 
	MASP NVARCHAR(10), 
	DONGIA INT,
	SOLUONG INT,	
	THANHTIEN INT,
	TRANGTHAI INT,
	PRIMARY KEY(MAHDB,MASP)
)
CREATE TABLE CHUCVU
(
	MACV NVARCHAR(30),
	TENCV NVARCHAR(20),
	TRANGTHAI INT,
	constraint Pk_MACV PRIMARY KEY (MACV)
)


ALTER TABLE NHANVIEN
	ADD CONSTRAINT FK_MACV
		FOREIGN KEY (CHUCVU)
			REFERENCES CHUCVU(MACV)			

alter table SANPHAM
	add constraint fk_MANCC
		foreign key (MANCC) 
			references NHACUNGCAP(MANCC)
alter table SANPHAM
	add constraint fk_MALOAISP
		foreign key (MALOAI) 
			references LOAISP(MALOAI)

alter table HOADONBAN
	add constraint fk_MAKH
		foreign key (MAKH) 
			references KHACHHANG(MAKH)
alter table HOADONBAN
	add constraint fk_MANVBAN
		foreign key (MANV) 
			references NHANVIEN(MANV)

alter table HOADONNHAP
	add constraint fk_MANCCHD
		foreign key (MANCC) 
			references NHACUNGCAP(MANCC)
alter table HOADONNHAP
	add constraint fk_MANVNHAP
		foreign key (MANV) 
			references NHANVIEN(MANV)

insert CHUCVU
values('CV001',		N'Quản Lý Kho',1)		
insert CHUCVU
values('CV002',		N'Chăm Sóc Khách Hàng',1)		
insert CHUCVU
values('CV003',		N'Tư Vấn Online',1)
insert CHUCVU
values('CV004',		N'Nhân Viên',1)				

SELECT *FROM CHUCVU

insert NHANVIEN 
values('NV001',N'Trần Thanh Tâm'		,N'Nam'	,'07/09/1999'	,N'Phường 13, Tân Bình, Tp.Hồ Chí Minh'		,'0351 357 895'	,'thanhtam202@gmail.com'	,'CV001'		,'1/5/2017'		,N'Vietcombank'	, 101791778		,75000	,'1')
insert NHANVIEN 
values('NV002',N'Nguyễn Văn Tùng'		,N'Nam'	,'03/16/1998'	,N'Phường 15, Bình Thạnh, Tp.Hồ Chí Minh'	,'0812 878 987'	,'vantung199@gmail.com'		,'CV002'		,'8/3/2019'		,null			,null			,71000	,'0')
insert NHANVIEN 
values('NV003',N'Lê Thị Kim Anh'		,N'Nữ'	,'02/22/2000'	,N'Tam Phú, Thủ Đức, Tp.Hồ Chí Minh'		,'0352 457 895'	,'kimanh201@gmail.com'		,'CV003'		,'9/5/2016'		,N'Vietcombank'	, 101733212		,65000	,'1')
insert NHANVIEN		
values('NV004',N'Trần Văn Sang'			,N'Nam'	,'04/25/1998'	,N'Ấp 2, Nhơn Đức, Nhà Bè, Tp.Hồ Chí Minh'	,'0770 433 814'	,'vansang201@gmail.com'		,'CV004'		,'5/5/2017'		,N'Viettinbank'	, 101735425		,80000	,'1')
insert NHANVIEN 
values('NV005',N'Mai Thị Quế Anh'		,N'Nữ'	,'05/24/1997'	,N'Phường Bến Nghé, Quận 1, Tp.Hồ Chí Minh'	,'0560 159 116'	,'queanh2k@gmail.com'		,'CV003'		,'4/5/2018'		,N'Viettinbank'	,10387504	,75000	,'1')
insert NHANVIEN 
values('NV006',N'Nguyễn Phạm Đức Huy'	,N'Nam'	,'05/17/1996'	,N'Phường 8, Gò Vấp, Tp.Hồ Chí Minh'		,'0925 723 113'	,'duchuy199@gmail.com'		,'CV002'		,'1/5/2019'		,N'Sacombank'	, 101724356		,73000	,'1')
insert NHANVIEN 
values('NV007',N'Phạm Trần Thanh Thúy'	,N'Nữ'	,'12/5/1995'	,N'Phường 12, Tân Bình, Tp.Hồ Chí Minh'		,'0938 805 766'	,'thanhthuy201@gmail.com'	,'CV004'		,'1/5/2018'		,null			,null			,82000	,'1')
insert NHANVIEN 
values('NV008',N'Nguyễn Việt Anh'		,N'Nam'	,'2/7/2000'		,N'Tam Binh, Thủ Đức, Tp.Hồ Chí Minh'		,'0933 118 756'	,'vietanh22@gmail.com'		,'CV001'		,'7/3/2017'		,N'Sacombank'	,101884356		,92000	,'1')

select *from NHANVIEN

insert KHACHHANG
values('KH001'	,N'Nguyễn Phạm Vân Anh'	,N'Tp Hồ Chí Minh'	,'0703321682'	,'vananh@gmail.com'		,0)
insert KHACHHANG
values('KH002'	,N'Lê Hoàng Nam'		,N'Long An'			,'0948724538'	,'hoangnam@gmail.com'	,1)
insert KHACHHANG
values('KH003'	,N'Trần Văn Hùng'		,N'Tiền Giang'		,'0346474368'	,'tranhung@gmail.com'	,0)
insert KHACHHANG
values('KH004'	,N'Ngô Gia Bảo'			,N'Vĩnh Long'		,'0975010258'	,'baongo22@gmail.com'	,1)
insert KHACHHANG
values('KH005'	,N'Phạm Trần Kim Anh'	,N'Long An'			,'0860845643'	,'kimanhhh@gmail.com'	,1)
insert KHACHHANG
values('KH006'	,N'Nguyễn Lê Huỳnh Như'	,N'Tp Hồ Chí Minh'	,'0781457895'	,'bnt@gmail.com'		,1)
insert KHACHHANG
values('KH007'	,N'Nguyễn Thị Bé'		,N'Bình Dương'		,'0798057895'	,'bnt@gmail.com'		,1)

select * from KHACHHANG

insert NHACUNGCAP
values('NCC01'	,N'Xgear'		,'0949999356'		,'Vietcombank'	,'1017487322'	,N'362 Đường số 8, Phường 11, Quận Gò Vấp, Tp.Hồ Chí Minh'		,1)
insert NHACUNGCAP
values('NCC02'	,N'GaMa'		,'0986100922'		,'Viettinbank'	,'1078816570'	,N'119/31 Đường 3 Tháng 2, Phường 11, Quận 10, Tp.Hồ Chí Minh'	,1)
insert NHACUNGCAP
values('NCC03'	,N'LaptopNew'	,'0907934268'		,'Vietcombank'	,'1017328761'	,N'291 Tân Sơn Nhì, P.Tân Sơn Nhì, Q.Tân Phú, Tp.Hồ Chí Minh'	,0)
insert NHACUNGCAP
values('NCC04'	,N'Gearvn'		,'0937587302'		,'Sacombank'	,'0203406896'	,N'7/42/11 Bùi Đình Túy P24, Quận Bình Thạnh, Tp.Hồ Chí Minh'	,1)
insert NHACUNGCAP
values('NCC05'	,N'MacMall'		,'0798489788'		,'Vietcombank'	,'101791778'	,N'817A Kha Vạn Cân, P. Linh Tây, Q. Thủ Đức, Tp.Hồ Chí Minh'	,1)
 
select * from NHACUNGCAP

insert LOAISP
values('L001',		N'LapTop'		,1)		
insert LOAISP
values('L002',		N'MacBook'		,1)		
insert LOAISP
values('L003',		N'PC'		,1)		

select * from  LOAISP 

insert MAUSP
values('M001',		N'ĐEN'		,1)		
insert MAUSP
values('M002',		N'TRẮNG'		,1)		
insert MAUSP
values('M003',		N'XÁM'		,1)		

select * from  MAUSP 



insert KICHTHUOC
values('S001',		'15.5 inch'		,1)		
insert KICHTHUOC
values('S002',		'17.5 inch'		,1)		
insert KICHTHUOC
values('S003',		'16.5 inch'		,0)		
insert KICHTHUOC
values('S004',		'17 inch'		,1)		
insert KICHTHUOC
values('S005',		'15 inch'		,1)		
insert KICHTHUOC
values('S006',		'16 inch'		,1)	
insert KICHTHUOC
values('S007',		'14.5 inch'		,1)		

SELECT *FROM KICHTHUOC
--update KICHTHUOC set TENSIZE = '14.0 inch'
--where MASIZE = 'S006'

insert SANPHAM
values('SP001'	,N'Asus VivoBook S533EA-BN462W'		,'L001',	'NCC01'		,'24'	,143500000,	17630000,	1,'sp01.PNG')
insert SANPHAM
values('SP002'	,N'Asus VivoBook S433EA-AM2307W'	,'L001',	'NCC02'		,'24'	,163500000,	18900000,	1)
insert SANPHAM
values('SP003'	,N'Macbook Air'						,'L001',	'NCC03'		,'24'	,149500000, 16630000,	1)
insert SANPHAM
values('SP004'	,N'Macbook Pro'						,'L001',	'NCC04'		,'24'	,393500000, 43850000,	1)
insert SANPHAM
values('SP005'	,N'PC Man Hinh Cong'				,'L004',	'NCC05'		,'12'	,73500000,	9490000 ,	1)
insert SANPHAM
values('SP006'	,N'iMac'							,'L006',	'NCC01'		,'24'	,298500000,	32420000,	1)
insert SANPHAM
values('SP007'	,N'Lenovo G40-70'		,'L007',	'NCC02'		,'12'	,383100000,	41680000,	0)

select * from SANPHAM
			
insert CHITIETSANPHAM	
values(NULL,'SP001'	,'H001'		,'S001'		,'M001'	,'L001'	,N'Core i5-1135G7/8GB/512GB PCIE/WIN10'		,1)
insert CHITIETSANPHAM		
values(NULL,'SP002'	,'H002'		,'S002'		,'M002'	,'L002'	,N'Core i7-1135G7/8GB/512GB PCIE/WIN10'		,1)
insert CHITIETSANPHAM
values(NULL,'SP003'	,'H003'		,'S003'		,'M003'	,'L003'	,N'8-Core-16GB/1T PCIE//IOS 15.5'			,1)
insert CHITIETSANPHAM	
values(NULL,'SP004'	,'H004'		,'S004'		,'M004'	,'L004'	,N'16-Core-32GB/1T PCIE/IOS 15.5'			,1)
insert CHITIETSANPHAM		
values(NULL,'SP005'	,'H005'		,'S005'		,'M005'	,'L005'	,N'LTPO OLED/1.61 inch//Apple S7/32 GB'		,1)
insert CHITIETSANPHAM	
values(NULL,'SP006'	,'H006'		,'S006'		,'M006'	,'L006'	,N'Core i5/3.6GHz/8GB 2400Mhz/SSD 256GB'	,1)
insert CHITIETSANPHAM	
values(NULL,'SP007'	,'H007'		,'S007'		,'M007'	,'L007'	,N'253g/4.2/10 m/A2DP/AVRCP/HFP/HSP/16h'	,1)

SELECT *from CHITIETSANPHAM

insert HOADONNHAP	
values('HDN001',	'NCC04'		,'NV001'	,null	,'7/11/2019'	,1)
insert HOADONNHAP	
values('HDN002',	'NCC04'		,'NV001'	,null	,'12/20/2019'	,1)
insert HOADONNHAP	
values('HDN003',	'NCC05'		,'NV001'	,null	,'5/30/2020'	,1)
insert HOADONNHAP	
values('HDN004',	'NCC05'		,'NV001'	,null	,'3/8/2019'		,1)
insert HOADONNHAP	
values('HDN005',	'NCC04'		,'NV004'	,null	,'1/9/2019'		,1)
insert HOADONNHAP	
values('HDN006',	'NCC02'		,'NV004'	,null	,'12/16/2018'	,1)
insert HOADONNHAP	
values('HDN007',	'NCC02'		,'NV004'	,null	,'7/13/2019'	,1)

select * from HOADONNHAP

select * from CHITIETHOADONNHAP  

insert HOADONBAN
values('HDB001',	'KH001'		,'NV002'	,'1/2/2019'		,null	,1)
insert HOADONBAN	
values('HDB002',	'KH002'		,'NV002'	,'12/3/2019'	,null	,0)
insert HOADONBAN	
values('HDB003',	'KH003'		,'NV002'	,'10/2/2020'	,null	,1)
insert HOADONBAN	
values('HDB004',	'KH004'		,'NV002'	,'11/3/2020'	,null	,1)
insert HOADONBAN	
values('HDB005',	'KH004'		,'NV003'	,'3/4/2020'		,null	,1)
insert HOADONBAN	
values('HDB006',	'KH002'		,'NV003'	,'1/5/2020'		,null	,1)
insert HOADONBAN	
values('HDB007',	'KH006'		,'NV003'	,'6/6/2021'		,null	,0)

SELECT *  from HOADONBAN

select * from CHITIETHOADONBAN




