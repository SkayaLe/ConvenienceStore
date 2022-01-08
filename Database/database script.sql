create database ConvenienceStore
go
use ConvenienceStore
go

-- TABLE 1
create table Nguoi
(
	userID char(8),
	passwd varchar(24),
	hoTen nvarchar(50),
	ngaySinh date,
	gioiTinh bit,
	cmnd char(12),
	sdt varchar(15),
	email varchar(50),
	diaChi nvarchar(255),
	PRIMARY KEY (userID)
)

-- TABLE 2
create table QuanLy
(
	maQL char(8),
	isQLChiNhanh bit,
	isQLChuoi bit,
	PRIMARY KEY (maQL),
	FOREIGN KEY (maQL) REFERENCES Nguoi(userID)
)

-- TABLE 3
create table KeToan
(
	maKT char(8),
	PRIMARY KEY (maKT),
	FOREIGN KEY (maKT) REFERENCES Nguoi(userID)
)

-- TABLE 4
create table ChiNhanh
(
	maCN char(8),
	maQL char(8),
	tenCN nvarchar(50),
	sdt varchar(15),
	diaChi nvarchar(255),
	PRIMARY KEY (maCN),
	FOREIGN KEY (maQL) REFERENCES QuanLy(maQL)
)

-- TABLE 5
create table NhanVienBanHang
(
	maNVBH char(8),
	maCN char(8),
	luong float,
	soGioLam float,
	danhgia int,
	PRIMARY KEY (maNVBH),
	FOREIGN KEY (maNVBH) REFERENCES Nguoi(userID),
	FOREIGN KEY (maCN) REFERENCES ChiNhanh(maCN)
)

-- TABLE 6
create table NhanVienThuKho
(
	maNVTK char(8),
	PRIMARY KEY (maNVTK),
	FOREIGN KEY (maNVTK) REFERENCES Nguoi(userID),
)

-- TABLE 7
create table CaLam
(
	maCa char(8),
	thoiGianBD time,
	thoiGianKT time,
	PRIMARY KEY (maCa)
)

-- TABLE 8
create table NhanVienBanHangCaLam
(
	maNVBH char(8),
	maCa char(8),
	ngayLam date,
	PRIMARY KEY (maCa,maNVBH,ngayLam),
	FOREIGN KEY (maCa) REFERENCES CaLam(maCa),
	FOREIGN KEY (maNVBH) REFERENCES NhanVienBanHang(maNVBH)
)

-- TABLE 9
create table NhaCungCap
(
	maNCC char(8),
	tenNCC nvarchar(50),
	sdt varchar(15),
	email varchar(50),
	diaChi nvarchar(255),
	PRIMARY KEY (maNCC)
)

-- TABLE 10
create table LoaiHang
(
	maLoai char(8),
	tenLoai nvarchar(50),
	PRIMARY KEY (maLoai)
)

-- TABLE 11
create table MatHang
(
	maMH char(8),
	maLoai char(8),
	maNCC char(8),
	tenMH  nvarchar(50),
	donViTinh nvarchar(50),
	donGia float,
	PRIMARY KEY (maMH),
	FOREIGN KEY (maLoai) REFERENCES LoaiHang(maLoai),
	FOREIGN KEY (maNCC) REFERENCES NhaCungCap(maNCC)
)

-- TABLE 12
create table MatHangChiNhanh
(
	maMH char(8),
	maCN char(8),
	soLuong int
	PRIMARY KEY (maMH,maCN),
	FOREIGN KEY (maMH) REFERENCES MatHang(maMH),
	FOREIGN KEY (maCN) REFERENCES ChiNhanh(maCN)
)

-- TABLE 13
create table HoaDon
(
	maHD char(8),
	maNVBH char(8),
	maCa char(8),
	maCN char(8),
	ngayLap datetime,
	tongTien float,
	primary key (maHD),
	foreign key (maNVBH) references NhanVienBanHang(maNVBH),
	foreign key (maCa) references CaLam(maCa),
	foreign key (maCN) references ChiNhanh(maCN)
)

-- TABLE 14
create table HoaDonSanPham
(
	maHD char(8),
	maMH char(8),
	soLuong int,
	primary key (maHD,maMH),
	foreign key (maHD) references HoaDon(maHD),
	foreign key (maMH) references MatHang(maMH)
)

-- TABLE 15
create table NhanVienThuKhoMatHang
(
	maNVTK char(8),
	maMH char(8),
	soLuong int,
	ngayNhap datetime,
	PRIMARY KEY (maNVTK,maMH),
	foreign key (maNVTK) references NhanVienThuKho(maNVTK),
	foreign key (maMH) references MatHang(maMH)
)

-- TABLE 1
SET DATEFORMAT DMY
insert into Nguoi values
	('KT000001','123', N'Nguyễn Minh Hằng', '21/07/1993', 1, '046300004325', '0905653246', 'nguyenminhhang@convstore.com', N'53A Phan Đăng Lưu, Tp.HCM'),
	('KT000002','123', N'Đỗ Phương Thảo', '31/01/1999', 1, '045600009005', '09055587056', 'dophuongthao@convstore.com', N'73 Trần Bình Trọng, Tp.HCM'),
	('QL000001','123', N'Nguyễn Minh Đăng', '25/09/1990', 0, '064500005518', '0903767568', 'nguyenminhdang@convstore.com', N'18 Nguyễn Thị Minh Khai, Tp.HCM'),
	('QL000002','123', N'Bùi Thị Lan', '04/10/1988', 1, '054400001992', '0905657531', 'buithilan@convstore.com', N'55 Vạn Kiếp, Tp.HCM'),
	('QL000003','123', N'Đặng Văn Nam', '07/11/1993', 0, '072300004650', '0905231292', 'dangvannam@convstore.com', N'84 Cách Mạng Tháng Tám, Tp.HCM'),
	('QL000004','123', N'Huỳnh Thùy Dương', '24/05/1985', 1, '092700009623', '0908118234', 'huynhthuyduong@convstore.com', N'12 Đào Duy Anh, Tp.HCM'),
	('TK000001','123', N'Nguyễn Tấn Phát', '14/08/1987', 0, '095800003533', '0903531846', 'nguyentanphat@convstore.com', N'245 Trần Hưng Đạo, Tp.HCM'),
	('TK000002','123', N'Nguyễn Tường Minh', '08/05/1986', 0, '093300007119', '0904475285', 'nguyentuongminh@convstore.com', N'169 An Dương Vương, Tp.HCM'),
	('BH000001','123', N'Lê Minh Châu', '12/09/1996', 0, '079300003124', '09035115210', 'bh000001@convstore.com', N'1245 Huỳnh Tấn Phát, Tp.HCM'),
	('BH000002','123', N'Nguyễn Thanh Tùng', '03/10/1989', 0, '001500006140', '09022414525', 'bh000002@convstore.com', N'122 Nguyễn Hữu Thọ, Tp.HCM'),
	('BH000003','123', N'Nguyễn Quốc Tuấn', '18/03/2000', 0, '052800006131', '09028111255', 'bh000003@convstore.com', N'352 Hai Bà Trưng, Tp.HCM'),
	('BH000004','123', N'Trần Phương Nhi', '14/12/1989', 1, '019200001348', '09047675313', 'bh000004@convstore.com', N'102 Điện Biên Phủ, Tp.HCM'),
	('BH000005','123', N'Nguyễn Minh Tân', '28/09/1997', 0, '068700006956', '09045111648', 'bh000005@convstore.com', N'32 Hoàng Văn Thụ, Tp.HCM'),
	('BH000006','123', N'Cao Thị Hương', '30/09/1996', 1, '080200001929', '0908436627', 'bh000006@convstore.com', N'88 Hồ Biểu Chánh, Tp.HCM')

insert into Nguoi values
	('BH000007','123','Jordan Nguyễn','18/09/1992','0','755614564258','0905831483','bh000007@convstore.com','Ap #295-5264 Elit. Rd.'),
	('BH000008','123','Boris Nguyễn','29/10/1991','0','833128437018','0906376132','bh000008@convstore.com','256-7027 Nascetur Rd.'),
	('BH000009','123','Adena Nguyễn','22/12/2000','0','573128175227','0905186041','bh000009@convstore.com','Ap #131-5085 Pharetra Street'),
	('BH000010','123','Garth Nguyễn','18/05/1993','0','615355361128','0904835363','bh000010@convstore.com','Ap #186-2094 Integer Avenue'),
	('BH000011','123','Zahir Nguyễn','08/10/1981','1','265281237176','0907564993','bh000011@convstore.com','9933 Pellentesque. Av.'),
	('BH000012','123','Paul Trác','10/08/1983','1','159952678759','0904711552','bh000012@convstore.com','P.O. Box 894, 3216 Nascetur Rd.'),
	('BH000013','123','Amos Nguyễn','07/08/1987','1','785891338459','0906298831','bh000013@convstore.com','6639 Rutrum. St.'),
	('BH000014','123','Dalton Nguyễn','27/02/1999','1','324605238155','0908181737','bh000014@convstore.com','Ap #588-9183 Turpis Rd.'),
	('BH000015','123','Indigo Tăng','01/01/1995','0','305424618949','0905174126','bh000015@convstore.com','1996 Non St.'),
	('BH000016','123','Aristotle Nguyễn','06/09/1986','0','721188978141','0904475873','bh000016@convstore.com','Ap #610-3934 Nec Road')
insert into Nguoi values
	('BH000017','123','Mari Nguyễn','16/01/1994','1','717290220371','0904310715','bh000017@convstore.com','561-4642 At, St.'),
	('BH000018','123','Reed Nguyễn','14/09/2000','1','688673384198','0906857885','bh000018@convstore.com','458-5911 Dui Street'),
	('BH000019','123','Jayme Nguyễn','06/10/1994','1','287577812465','0908767346','bh000019@convstore.com','166-7398 Molestie Avenue'),
	('BH000020','123','Kevyn Vi','18/01/1991','1','500522757782','0902885732','bh000020@convstore.com','176 Gravida. Avenue'),
	('BH000021','123','Amanda Nguyễn','03/07/1989','0','682826823406','0901550554','bh000021@convstore.com','Ap #156-4240 Urna, St.'),
	('BH000022','123','Wallace Nguyễn','06/05/1987','1','362556528747','0904613402','bh000022@convstore.com','P.O. Box 100, 2114 Mauris Avenue'),
	('BH000023','123','Wynter Nguyễn','12/01/1988','0','157067124840','0908356631','bh000023@convstore.com','220-7595 Nulla. Road'),
	('BH000024','123','Cynthia Nguyễn','10/07/2000','1','294622280522','0902162404','bh000024@convstore.com','Ap #596-4704 Mauris, Road'),
	('BH000025','123','Ursula Nông','11/10/1984','1','930165215778','0901017233','bh000025@convstore.com','Ap #359-6065 Congue, Av.'),
	('BH000026','123','Alec Nguyễn','15/05/1989','0','223464576416','0903323324','bh000026@convstore.com','894-9747 Amet, Av.')

-- TABLE 2
insert into QuanLy values
	('QL000001', 0, 1),
	('QL000002', 0, 1),
	('QL000003', 1, 0),
	('QL000004', 1, 0)

-- TABLE 3
insert into KeToan values
	('KT000001'),
	('KT000002')

-- TABLE 4
insert into ChiNhanh values
	('CN000001', 'QL000003', N'245 Lê Văn Lương', '02837722208', N'245 Lê Văn Lương Q.7, Tp.HCM'),
	('CN000002', 'QL000004', N'81 Nguyễn Thị Thập', '02837755046', N'81 Nguyễn Thị Thập, Tp.HCM')

-- TABLE 5
insert into NhanVienBanHang values
	('BH000001', 'CN000001',  0, 94, 6),
	('BH000002', 'CN000001',  0, 120, 4),
	('BH000003', 'CN000001',  0, 12, 5),
	('BH000004', 'CN000002',  0, 30, 4),
	('BH000005', 'CN000002',  0, 56, 3),
	('BH000006', 'CN000002',  0, 0, 0)

insert into NhanVienBanHang values
	('BH000007', 'CN000001',  0, 21, 2),
	('BH000008', 'CN000001',  0, 22, 3),
	('BH000009', 'CN000001',  0, 23, 4),
	('BH000010', 'CN000001',  0, 24, 5),
	('BH000011', 'CN000001',  0, 25, 6),
	('BH000012', 'CN000001',  0, 26, 1),
	('BH000013', 'CN000001',  0, 27, 2),
	('BH000014', 'CN000001',  0, 28, 3),
	('BH000015', 'CN000001',  0, 29, 4),
	('BH000016', 'CN000001',  0, 30, 5)
insert into NhanVienBanHang values
	('BH000017', 'CN000002',  0, 141, 5),
	('BH000018', 'CN000002',  0, 142, 1),
	('BH000019', 'CN000002',  0, 143, 2),
	('BH000020', 'CN000002',  0, 144, 3),
	('BH000021', 'CN000002',  0, 145, 4),
	('BH000022', 'CN000002',  0, 146, 5),
	('BH000023', 'CN000002',  0, 147, 6),
	('BH000024', 'CN000002',  0, 148, 4),
	('BH000025', 'CN000002',  0, 149, 5),
	('BH000026', 'CN000002',  0, 150, 3)

-- TABLE 6
insert into NhanVienThuKho values
	('TK000001'),
	('TK000002')

-- TABLE 7
insert into CaLam values
	('CA000001', '06:00:00', '14:00:00'),
	('CA000002', '14:00:00', '22:00:00'),
	('CA000003', '22:00:00', '06:00:00')

-- TABLE 8
SET DATEFORMAT DMY
insert into NhanVienBanHangCaLam values
	('BH000001', 'CA000001', '13/12/2021'),
	('BH000001', 'CA000002', '14/12/2021'),
	('BH000001', 'CA000001', '15/12/2021'),
	('BH000001', 'CA000002', '16/12/2021'),
	('BH000001', 'CA000001', '17/12/2021'),
	('BH000001', 'CA000002', '18/12/2021'),
	('BH000002', 'CA000001', '13/12/2021'),
	('BH000002', 'CA000002', '14/12/2021'),
	('BH000002', 'CA000001', '15/12/2021'),
	('BH000002', 'CA000002', '16/12/2021'),
	('BH000002', 'CA000003', '17/12/2021'),
	('BH000002', 'CA000001', '19/12/2021'),
	('BH000003', 'CA000002', '13/12/2021'),
	('BH000003', 'CA000002', '14/12/2021'),
	('BH000003', 'CA000001', '15/12/2021'),
	('BH000003', 'CA000001', '16/12/2021'),
	('BH000003', 'CA000001', '17/12/2021'),
	('BH000003', 'CA000001', '18/12/2021'),
	('BH000003', 'CA000001', '19/12/2021'),
	('BH000004', 'CA000001', '13/12/2021'),
	('BH000004', 'CA000001', '14/12/2021'),
	('BH000004', 'CA000001', '15/12/2021'),
	('BH000004', 'CA000001', '16/12/2021'),
	('BH000004', 'CA000001', '17/12/2021'),
	('BH000004', 'CA000001', '18/12/2021'),
	('BH000004', 'CA000001', '19/12/2021'),
	('BH000005', 'CA000001', '13/12/2021'),
	('BH000005', 'CA000001', '14/12/2021'),
	('BH000005', 'CA000001', '15/12/2021'),
	('BH000005', 'CA000001', '16/12/2021'),
	('BH000005', 'CA000001', '17/12/2021'),
	('BH000005', 'CA000001', '18/12/2021'),
	('BH000005', 'CA000001', '19/12/2021'),
	('BH000006', 'CA000003', '13/12/2021'),
	('BH000006', 'CA000003', '14/12/2021'),
	('BH000006', 'CA000003', '15/12/2021'),
	('BH000006', 'CA000003', '17/12/2021'),
	('BH000006', 'CA000003', '18/12/2021'),
	('BH000006', 'CA000003', '19/12/2021')

insert into NhanVienBanHangCaLam values
	('BH000007', 'CA000001', '13/12/2021'),
	('BH000007', 'CA000001', '14/12/2021'),
	('BH000007', 'CA000001', '15/12/2021'),
	('BH000007', 'CA000001', '16/12/2021'),
	('BH000007', 'CA000001', '17/12/2021'),
	('BH000007', 'CA000001', '18/12/2021'),
	('BH000008', 'CA000001', '13/12/2021'),
	('BH000008', 'CA000001', '14/12/2021'),
	('BH000008', 'CA000001', '15/12/2021'),
	('BH000008', 'CA000001', '16/12/2021'),
	('BH000008', 'CA000001', '17/12/2021'),
	('BH000008', 'CA000001', '18/12/2021'),
	('BH000009', 'CA000001', '13/12/2021'),
	('BH000009', 'CA000001', '14/12/2021'),
	('BH000009', 'CA000001', '15/12/2021'),
	('BH000009', 'CA000001', '16/12/2021'),
	('BH000009', 'CA000001', '17/12/2021'),
	('BH000009', 'CA000001', '18/12/2021'),
	('BH000010', 'CA000002', '13/12/2021'),
	('BH000010', 'CA000002', '14/12/2021'),
	('BH000010', 'CA000002', '15/12/2021'),
	('BH000010', 'CA000002', '16/12/2021'),
	('BH000010', 'CA000002', '17/12/2021'),
	('BH000010', 'CA000002', '18/12/2021'),
	('BH000011', 'CA000002', '13/12/2021'),
	('BH000011', 'CA000002', '14/12/2021'),
	('BH000011', 'CA000002', '15/12/2021'),
	('BH000011', 'CA000002', '16/12/2021'),
	('BH000011', 'CA000002', '17/12/2021'),
	('BH000011', 'CA000002', '18/12/2021'),
	('BH000012', 'CA000002', '13/12/2021'),
	('BH000012', 'CA000002', '14/12/2021'),
	('BH000012', 'CA000002', '15/12/2021'),
	('BH000012', 'CA000002', '16/12/2021'),
	('BH000012', 'CA000002', '17/12/2021'),
	('BH000012', 'CA000002', '18/12/2021'),
	('BH000010', 'CA000003', '13/12/2021'),
	('BH000010', 'CA000003', '14/12/2021'),
	('BH000010', 'CA000003', '15/12/2021'),
	('BH000010', 'CA000003', '16/12/2021'),
	('BH000010', 'CA000003', '17/12/2021'),
	('BH000010', 'CA000003', '18/12/2021'),
	('BH000011', 'CA000003', '13/12/2021'),
	('BH000011', 'CA000003', '14/12/2021'),
	('BH000011', 'CA000003', '15/12/2021'),
	('BH000011', 'CA000003', '16/12/2021'),
	('BH000011', 'CA000003', '17/12/2021'),
	('BH000011', 'CA000003', '18/12/2021'),
	('BH000012', 'CA000003', '13/12/2021'),
	('BH000012', 'CA000003', '14/12/2021'),
	('BH000012', 'CA000003', '15/12/2021'),
	('BH000012', 'CA000003', '16/12/2021'),
	('BH000012', 'CA000003', '17/12/2021'),
	('BH000012', 'CA000003', '18/12/2021')
--insert into NhanVienBanHangCaLam values


-- TABLE 9
insert into NhaCungCap values
	('CT000001', N'Unilever', '0257722208', 'u@gmail.com', N'12 Hai Bà Trưng Q.7, Tp.HCM'),
	('CT000002', N'P&G', '02845722208', 'pg@gmail.com', N'5 Nguyễn Thị Thập Q.8, Tp.HCM'),
	('CT000003', N'Acecook', '03237722208', 'ace@gmail.com', N'23 Hồ Chí Minh Q.9, Tp.HCM'),
	('CT000004', N'Nestle', '02857722208', 'nest@gmail.com', N'15 Nguyễn Huệ Q.1, Tp.HCM'),
	('CT000005', N'PepsiCo', '02997722208', 'pep@gmail.com', N'26 Nguyễn Chí Thanh Q.2, Tp.HCM'),
	('CT000006', N'Coca-Cola', '03837744208', 'coca@gmail.com', N'78 Nguyễn Công Bình Q.3, Tp.HCM'),
	('CT000007', N'Channel', '01435222208', 'chan@gmail.com', N'454 Nguyễn Trãi Q.6, Tp.HCM'),
	('CT000008', N'Johhnie Walker', '01537722213', 'walk@gmail.com', N'676 Nguyễn Bỉnh Khiêm Q.12, Tp.HCM'),
	('CT000009', N'Budweiser', '05533322208', 'bud@gmail.com', N'455 Lê Ngọc Hân Q.10, Tp.HCM'),
	('CT000010', N'Heineken', '01137776208', 'hein@gmail.com', N'909 Nguyễn Đình Chiểu Q.4, Tp.HCM')

-- TABLE 10
insert into LoaiHang values
	('LH000001', N'Hàng tổng hợp'),
	('LH000002', N'Hóa mỹ phẩm'),
	('LH000003', N'Thực phẩm đóng gói'),
	('LH000004', N'Kem'),
	('LH000005', N'Sữa và sản phẩm từ sữa'),
	('LH000006', N'Snack'),
	('LH000007', N'Bánh kẹo'),
	('LH000008', N'Nước giải khát'),
	('LH000009', N'Rượu'),
	('LH000010', N'Bia - rượu trái cây')

-- TABLE 11
insert into MatHang values
	('MH000001', 'LH000001', 'CT000001', N'Nước giặt OMO 5L', N'Bình', 100000),
	('MH000002', 'LH000001', 'CT000001', N'Nước rửa chén Sunlight 1L', N'Chai', 40000),
	('MH000003', 'LH000001', 'CT000002', N'Nước xả vải Downy 1Kg', N'Bịch', 60000),
	('MH000004', 'LH000002', 'CT000007', N'Channel Luxury', N'Chai', 500000),
	('MH000005', 'LH000002', 'CT000007', N'Channel Gentle', N'Chai', 800000),
	('MH000006', 'LH000002', 'CT000007', N'Channel Gin', N'Chai', 300000),
	('MH000007', 'LH000003', 'CT000003', N'Hảo Hảo', N'Bịch',4000 ),
	('MH000008', 'LH000003', 'CT000003', N'Hảo Hảo xào khô', N'Bịch',4000 ),
	('MH000009', 'LH000003', 'CT000003', N'Hảo Hảo 100', N'Bịch',4000 ),
	('MH000010', 'LH000003', 'CT000003', N'Hảo Hảo thịt bằm', N'Bịch',4000 ),
	('MH000011', 'LH000004', 'CT000004', N'Kem MM', N'Cây', 5000),
	('MH000012', 'LH000004', 'CT000004', N'Kem xiang', N'Cây', 6000),
	('MH000013', 'LH000005', 'CT000004', N'Kem dừa', N'Hộp', 20000),
	('MH000014', 'LH000005', 'CT000004', N'Sữa nest đỏ', N'Bịch', 50000),
	('MH000015', 'LH000005', 'CT000004', N'Sữa dâu', N'Bịch', 5000),
	('MH000016', 'LH000005', 'CT000004', N'Sữa socola', N'Bịch', 5000),
	('MH000017', 'LH000005', 'CT000004', N'Sữa không đường', N'Bịch', 5000),
	('MH000018', 'LH000006', 'CT000005', N'Khoai tây Lays', N'Bịch', 5000),
	('MH000019', 'LH000007', 'CT000006', N'Kẹo coca', N'Bịch', 15000),
	('MH000020', 'LH000007', 'CT000006', N'Kẹo coca 2.0', N'Bịch', 18000),
	('MH000021', 'LH000007', 'CT000006', N'Kẹo love', N'Bịch', 22000),
	('MH000022', 'LH000008', 'CT000005', N'Pepsi không calo', N'Lon', 9000),
	('MH000023', 'LH000008', 'CT000006', N'Coca không calo', N'Lon', 9000),
	('MH000024', 'LH000008', 'CT000006', N'Coca caco', N'Lon', 9000),
	('MH000025', 'LH000009', 'CT000008', N'Rượu vang', N'Chai', 80000),
	('MH000026', 'LH000009', 'CT000008', N'Rượu noname', N'Chai', 100000),
	('MH000027', 'LH000009', 'CT000010', N'Ken Bạc', N'Lon', 18000),
	('MH000028', 'LH000010', 'CT000009', N'Jonas 9', N'Chai', 35000),
	('MH000029', 'LH000010', 'CT000009', N'Sneaky VIP', N'Chai', 60000),
	('MH000030', 'LH000010', 'CT000009', N'Ola Peco', N'Chai', 55000)

-- TABLE 12
insert into MatHangChiNhanh values
	('MH000001', 'CN000001', 76),
	('MH000002', 'CN000001', 55),
	('MH000003', 'CN000001', 44),
	('MH000004', 'CN000001', 82),
	('MH000005', 'CN000001', 67),
	('MH000006', 'CN000001', 75),
	('MH000007', 'CN000001', 65),
	('MH000008', 'CN000001', 44),
	('MH000009', 'CN000001', 92),
	('MH000010', 'CN000001', 77),
	('MH000011', 'CN000001', 86),
	('MH000012', 'CN000001', 81),
	('MH000013', 'CN000001', 100),
	('MH000014', 'CN000001', 66),
	('MH000015', 'CN000001', 59),
	('MH000016', 'CN000001', 69),
	('MH000017', 'CN000001', 77),
	('MH000018', 'CN000001', 88),
	('MH000019', 'CN000001', 64),
	('MH000020', 'CN000001', 74)

--TABLE 13
SET DATEFORMAT DMY
insert into HoaDon values
	('HD00001','BH000001','CA000001','CN000001','13/11/2021',55000),
	('HD00002','BH000002','CA000002','CN000002','14/11/2021',135000),
	('HD00003','BH000003','CA000001','CN000002','15/11/2021',72000),
	('HD00004','BH000004','CA000003','CN000001','16/11/2021',98000),
	('HD00005','BH000005','CA000002','CN000001','17/11/2021',112000)

--TABLE 14
insert into HoaDonSanPham values
	('HD00001','MH000007',6),
	('HD00001','MH000013',2),
	('HD00001','MH000014',1),
	('HD00002','MH000029',5),
	('HD00002','MH000012',10),
	('HD00003','MH000007',6),
	('HD00003','MH000013',2),
	('HD00003','MH000014',3),
	('HD00004','MH000022',4),
	('HD00004','MH000018',7),
	('HD00005','MH000016',4),
	('HD00005','MH000008',3),
	('HD00005','MH000003',4),
	('HD00005','MH000001',2)

--TABLE 15
SET DATEFORMAT DMY
insert into NhanVienThuKhoMatHang values
	('TK000001','MH000007',20, '02/12/2021'),
	('TK000001','MH000013',10, '02/12/2021'),
	('TK000002','MH000014',30, '03/12/2021'),
	('TK000002','MH000029',18, '04/12/2021'),
	('TK000001','MH000012',33, '05/12/2021'),
	('TK000001','MH000003',25, '08/12/2021'),
	('TK000002','MH000024',27, '09/12/2021'),
	('TK000002','MH000009',16, '11/12/2021')
