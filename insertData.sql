alter table NHANVIEN
add MaTK nvarchar(50) foreign key references TAIKHOAN(MaTK)
insert into NHANVIEN values('NV01','Chu Van Dung', 'Ha Dong', 'Nam', '0982312321', '2003-4-10','2023-10-23',3,'','TK01'),
('NV02','Pham Van Linh', 'Bac Giang', 'Nam', '0982312321', '2003-4-12','2023-10-23',1,'','TK02')
insert into TAIKHOAN values ('TK01', 'chudung','123456','Admin'),
('TK02', 'linhca','123456','User')
select * from NHANVIEN
create table TAIKHOAN
(MaTK nvarchar(50) primary key,
TenDN nvarchar(50),
MatKhau nvarchar(50),
Quyen nvarchar(50)
)
select * from TAIKHOAN