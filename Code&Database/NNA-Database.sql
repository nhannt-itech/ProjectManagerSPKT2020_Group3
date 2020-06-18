create database QuanLyDeTaiSV
go
use QuanLyDeTaiSV
go

create table Teacher
(
	sMGV nvarchar(50) primary key,
	sName nvarchar(50)  null,
	sSex nvarchar(3)  null,
	sPhone char(13) null,
	sEmail char(50) null,
	dtBirth date null,
	sFaculty nvarchar(50)  null,
	sSubject nvarchar(50)  null,
	iImage image null
)
go
create table Student
(
	sMSSV nvarchar(50) primary key,
	sName nvarchar(50)  null,
	dtBirth date not null,
	sSex nvarchar(3)  null,
	sPhone char(13) null,
	sEmail char(50) null,
	sFaculty nvarchar(50) null,
	iYear int null,
)
go
create table Project
(
	sID nvarchar(50) primary key,
	sName nvarchar(50) null,
	sCategory nvarchar(50)  null,
	sSubject nvarchar(50)  null,
	iGrade int  null,
	dtFromDate date  null,
	dtToDate date  null,
	teacher_ID nvarchar(50) foreign key references dbo.Teacher(sMGV) null,
	sDescription nvarchar(200) null,
	sLink nvarchar (200) null
)
go

create table Comment
(
	sID nvarchar(50) primary key,
	iTime int null,
	sComment1 nvarchar(200) null,
	sComment2 nvarchar(200) null,
	sComment3 nvarchar(200) null
)

create table Student_Project
(
	Student_MSSV nvarchar(50)   not null,
	Project_ID nvarchar(50)  not null,
	primary key( Student_MSSV, Project_ID)
)
go
alter table dbo.Student_Project add foreign key(Student_MSSV) references dbo.Student
alter table dbo.Student_Project add foreign key(Project_ID) references dbo.Project
go



-- THÊM SINH VIÊN
Insert into Student Values ('001' , N'Nguyễn Thanh Nhân' , '2000-05-21' , N'Nữ' ,  '0987639079' , 'Nhancute215@gmail.com' , N'Công Nghệ Thông Tin' , 2017 )
Insert into Student Values ('002' , N'Trương Thị Thảo Nguyên' , '2000-03-12' , N'Nữ' ,  '0976584391' , 'BananaGirl123@gmail.com' , N'Công Nghệ Thông Tin' , 2017 )
Insert into Student Values ('003' , N'Đỗ Tân Hợp' , '2000-06-08' , N'Nam' ,  '0936783291' , 'HopGioiIELTS@gmail.com' , N'Ngôn Ngữ Anh' , 2018 )
Insert into Student Values ('004' , N'Lương Thế Anh' , '1999-03-08' , N'Nam' ,  '0912377283' , 'ThichCauLong83@gmail.com' , N'Ngôn Ngữ Anh' , 2018 )
Insert into Student Values ('005' , N'Nguyễn Tô Thuyết Y' , '2000-08-12' , N'Nữ' ,  '0912387481' , 'YcafeNguoiThu3@gmail.com' , N'Ngôn Ngữ Anh' , 2018 )
Insert into Student Values ('006' , N'Nguyễn Hoàng Huy' , '2000-05-22' , N'Nam' ,  '0987639079' , 'Huycakhia21@gmail.com' , N'Công Nghệ May' , 2017 )
Insert into Student Values ('007' , N'Phạm Minh Hoàng' , '2000-07-13' , N'Nữ' ,  '0985674827' , 'HoangNoel@gmail.com' , N'Công Nghệ May' , 2017 )
Insert into Student Values ('008' , N'Trần Thanh Toàn' , '2000-12-01' , N'Nữ' ,  '0946826384' , 'Toantt@gmail.com' , N'Ngôn Ngữ Anh' , 2018 )
Insert into Student Values ('009' , N'Nguyễn Đông Hướng' , '2000-09-08' , N'Nam' ,  '0987537293' , 'Huongit@gmail.com' , N'Ngôn Ngữ Anh' , 2018 )
Insert into Student Values ('010' , N'Nguyễn Đào Khang Hy' , '2000-03-01' , N'Nữ' ,  '0987362837' , 'Hymito@gmail.com' , N'Ngôn Ngữ Anh' , 2018 )
GO
-- THÊM GIÁO VIÊN
Insert into Teacher Values (N'GV001' , N'Trần Lý Kim Chi' , N'Nữ' , '01212747188' , 'kimchitl21@gmail.com',  '1992-03-04' , N'Công Nghệ Thông Tin' , N'Nhập Môn CNTT' , null)
Insert into Teacher Values (N'GV002' , N'Tôn Thị Kim Bằng' , N'Nữ' , '0987638473' , 'bangtonthi@gmail.com',  '1990-07-03' , N'Công Nghệ Thông Tin' , N'Thực Hành Máy Tính' , null)
Insert into Teacher Values (N'GV003' , N'Nguyễn Trần Minh Thức' , N'Nam' , '0987218473' , 'thucmn102@gmail.com',  '1995-09-09' , N'Công Nghệ Thông Tin' , N'Thực Hành Máy Tính' , null)
Insert into Teacher Values (N'GV004' , N'Phạm Thị Thanh Trúc' , N'Nữ' , '0987217384' , 'trcpham812@gmail.com',  '1992-12-08' , N'Công Nghệ May' , N'Nhập Môn May' , null)
Insert into Teacher Values (N'GV005' , N'Trần Thanh Thảo' , N'Nữ' , '0989738271' , 'thaott221@gmail.com',  '1990-03-09' , N'Công Nghệ May' , N'Thực Kỹ Thuật May' , null)
Insert into Teacher Values (N'GV006' , N'Lê Tuấn Lợi' , N'Nam' , '01212364788' , 'loimotlan123@gmail.com',  '1995-12-27' , N'Công Nghệ May' , N'Nhập Môn May' , null)
Insert into Teacher Values (N'GV007' , N'Nguyễn Như Phúc' , N'Nam' , '0987637281' , 'phucyeuhang1@gmail.com',  '1889-04-07' , N'Ngôn Ngữ Học' , N'Nhập Môn TA' , null)
Insert into Teacher Values (N'GV008' , N'Trần Đức Huy' , N'Nam' , '0827237281' , 'huyletran89@gmail.com',  '1889-12-03' , N'Ngôn Ngữ Học' , N'Giao Tiếp TA' , null)
Insert into Teacher Values (N'GV009' , N'Phạm Thanh Tân' , N'Nam' , '0787282329' , 'tanthuc_bay1@gmail.com',  '1995-12-21' , N'Ngôn Ngữ Học' , N'Giao Tiếp TA' , null)
GO
-- THÊM ĐỀ TÀI
Insert into Project Values ('DT001' , N'Công Cụ Trí Tuệ' , N'Đồ Án Môn Học' , N'Nhập Môn CNTT' , null , '2020-5-4' , '2020-5-20' , 'GV001', N'Đề Tài bảo vệ', N'https://www.w3schools.com/sql/sql_drop_table.asp')
Insert into Comment Values ('DT001', 0, null, null, null)

Insert into Project Values ('DT002' , N'Công Cụ May' , N'Đồ Án Môn Học' , N'Nhập Môn May' , null , '2020-6-7' , '2020-6-25' , 'GV001', null, null)
Insert into Comment Values ('DT002', 1, N'Lần 1', null, null)

Insert into Project Values ('DT003' , N'Tìm Hiểu Cỗ Máy' , N'Tiểu Luận Chuyên Ngành' , N'Nhập Môn CNTT' , null , '2020-1-1' , '2020-1-30' , 'GV001', null, null)
Insert into Comment Values ('DT003', 2, N'Lần 1', N'Lần 2', null) 

Insert into Project Values ('DT004' , N'Các Từ Chuyên Ngành' , N'Đồ Án Tốt Nghiệp' , N'Tìm Hiểu Anh Ngữ' , 8 , '2019-1-1' , '2019-1-2' , 'GV002', null, null)
Insert into Comment Values ('DT004', 3, N'Lần 1', N'Lần 2', N'Lần 3')

Insert into Project Values ('DT005' , N'Hệ Thống Tự Động' , N'Đồ Án Môn Học' , N'Nhập Môn CNTT' , 9 , '2019-1-1' , '2019-1-2' , 'GV003',null, null)
Insert into Comment Values ('DT005', 0, null, null, null)

Insert into Project Values ('DT006' , N'Thời Trang Ngày Nay' , N'Tiểu Luận Chuyên Ngành' , N'Nhập Môn May' , 7 , '2019-1-3' , '2019-1-16' , 'GV003',null, null)
Insert into Comment Values ('DT006', 0, null, null, null)

Insert into Project Values ('DT007' , N'Giao Tiếp Trong Đời Sống' , N'Đồ Án Tốt Nghiệp' , N'Tìm Hiểu Anh Ngữ' , 3 , '2019-3-1' , '2019-4-2' , 'GV004',null, null)
Insert into Comment Values ('DT007', 0, null, null, null)

Insert into Project Values ('DT008' , N'Hệ Thống May' , N'Đồ Án Môn Học' , N'Nhập Môn May' , 2 , '2019-6-3' , '2019-7-19' , 'GV004',null, null)
Insert into Comment Values ('DT008', 0, null, null, null)

Insert into Project Values ('DT009' , N'Phân Tích Ngôn Ngữ' , N'Tiểu Luận Chuyên Ngành' , N'Nhập Môn May' , 0 , '2019-2-2' , '2020-3-15' , 'GV004',null, null)
Insert into Comment Values ('DT009', 0, null, null, null)

Insert into Project Values ('DT010' , N'Công Cụ Lập Trình' , N'Tiểu Luận Chuyên Ngành' , N'Nhập Môn CNTT' , 10 , '2019-3-1' , '2019-8-2' , 'GV004',null, null)
Insert into Comment Values ('DT010', 0, null, null, null)

GO
-- PHÂN CÔNG ĐỀ TÀI CHO SINH VIÊN
Insert into Student_Project Values ('001' , 'DT001')
Insert into Student_Project Values ('002' , 'DT001')
Insert into Student_Project Values ('003' , 'DT001')
Insert into Student_Project Values ('004' , 'DT001')
Insert into Student_Project Values ('005' , 'DT002')
Insert into Student_Project Values ('006' , 'DT002')
Insert into Student_Project Values ('007' , 'DT002')
Insert into Student_Project Values ('008' , 'DT002')
Insert into Student_Project Values ('009' , 'DT002')
Insert into Student_Project Values ('010' , 'DT002')
Insert into Student_Project Values ('001' , 'DT003')
Insert into Student_Project Values ('002' , 'DT003')
Insert into Student_Project Values ('003' , 'DT003')
Insert into Student_Project Values ('006' , 'DT003')
Insert into Student_Project Values ('007' , 'DT003')
GO


create proc USP_SearchTeacher @sInput nvarchar(20) , @sKind nvarchar(30)
AS
BEGIN
	if (@sKind = N'Mã Giáo Viên')
		select sMGV as N'Mã Giáo Viên', sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', sSubject as N'Bộ Môn'  from dbo.Teacher
		where (charindex(@sInput, sMGV) > 0)
	if (@sKind = N'Họ Tên')
		select sMGV as N'Mã Giáo Viên', sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', sSubject as N'Bộ Môn'  from dbo.Teacher
		where (charindex(@sInput, sName) > 0)
 	if (@sKind = N'Số Điện Thoại')
		select sMGV as N'Mã Giáo Viên', sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', sSubject as N'Bộ Môn'  from dbo.Teacher
		where (charindex(@sInput, sPhone) > 0)
	if (@sKind = N'Email')
		select sMGV as N'Mã Giáo Viên', sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', sSubject as N'Bộ Môn'  from dbo.Teacher
		where (charindex(@sInput, sEmail) > 0)
	if (@sKind = N'Khoa')
		select sMGV as N'Mã Giáo Viên', sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', sSubject as N'Bộ Môn'  from dbo.Teacher
		where (charindex(@sInput, sFaculty) > 0)
	if (@sKind = N'Môn')
		select sMGV as N'Mã Giáo Viên', sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', sSubject as N'Bộ Môn'  from dbo.Teacher
		where (charindex(@sInput, sSubject) > 0)
	if (@sKind = N'Mã Đề Tài GVQL')
		select sMGV as N'Mã Giáo Viên', dbo.Teacher.sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', dbo.Teacher.sSubject as N'Bộ Môn'  from dbo.Teacher
		INNER JOIN dbo.Project ON teacher_ID = sMGV
		where (charindex(@sInput, sID) > 0)
	if (@sKind = 'Tất Cả')
		select sMGV as N'Mã Giáo Viên', sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', sSubject as N'Bộ Môn'  from dbo.Teacher
END
GO
--DROP PROCEDURE USP_SearchTeacher;

create proc USP_SearchStudent @sInput nvarchar(30) , @sKind nvarchar(30)
AS
BEGIN
	if (@sKind = N'Mã Số Sinh Viên')
		select sMSSV as N'MSSV', sName as N'Họ Tên', dtBirth as N'Ngày Sinh', sPhone as N'SĐT', sEmail as N'Email', sFaculty as 'Khoa', iYear as 'Năm Nhập Học'  from dbo.Student
		where (charindex(@sInput, sMSSV) > 0)
	if (@sKind = N'Họ Tên')
		select sMSSV as N'MSSV', sName as N'Họ Tên', dtBirth as N'Ngày Sinh', sPhone as N'SĐT', sEmail as N'Email', sFaculty as 'Khoa', iYear as 'Năm Nhập Học'  from dbo.Student
		where (charindex(@sInput, sName) > 0)
 	if (@sKind = N'Số Điện Thoại')
		select sMSSV as N'MSSV', sName as N'Họ Tên', dtBirth as N'Ngày Sinh', sPhone as N'SĐT', sEmail as N'Email', sFaculty as 'Khoa', iYear as 'Năm Nhập Học'  from dbo.Student
		where (charindex(@sInput, sPhone) > 0)
	if (@sKind = N'Email')
		select sMSSV as N'MSSV', sName as N'Họ Tên', dtBirth as N'Ngày Sinh', sPhone as N'SĐT', sEmail as N'Email', sFaculty as 'Khoa', iYear as 'Năm Nhập Học'  from dbo.Student
		where (charindex(@sInput, sEmail) > 0)
	if (@sKind = N'Khoa')
		select sMSSV as N'MSSV', sName as N'Họ Tên', dtBirth as N'Ngày Sinh', sPhone as N'SĐT', sEmail as N'Email', sFaculty as 'Khoa', iYear as 'Năm Nhập Học'  from dbo.Student
		where (charindex(@sInput, sFaculty) > 0)
	if (@sKind = N'Năm Nhập Học')
		select sMSSV as N'MSSV', sName as N'Họ Tên', dtBirth as N'Ngày Sinh', sPhone as N'SĐT', sEmail as N'Email', sFaculty as 'Khoa', iYear as 'Năm Nhập Học'  from dbo.Student
		where (charindex(@sInput, iYear) > 0)
	if (@sKind = N'Mã Đề Tài')
		select sd.sMSSV as N'MSSV', sd.sName as N'Họ Tên', sd.dtBirth as N'Ngày Sinh', sd.sPhone as N'SĐT', sd.sEmail as N'Email', sd.sFaculty as 'Khoa', sd.iYear as 'Năm Nhập Học'  from dbo.Student as sd, dbo.Project as pj, dbo.Student_Project as sp
		where  sd.sMSSV = sp.Student_MSSV and pj.sID = sp.Project_ID and(charindex(@sInput, sId) > 0) 
	if (@sKind = 'Tất Cả')
		select sMSSV as N'MSSV', sName as N'Họ Tên', dtBirth as N'Ngày Sinh', sPhone as N'SĐT', sEmail as N'Email', sFaculty as 'Khoa', iYear as 'Năm Nhập Học'  from dbo.Student
END
GO

-- DROP PROCEDURE USP_SearchStudent

create proc USP_SearchProject @sInput nvarchar(30) , @sKind nvarchar(30)
AS
BEGIN
	if (@sKind = N'Mã Đề Tài')
		select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
		where (charindex(@sInput, sID) > 0) and p.teacher_ID = t.sMGV
	if (@sKind = N'Tên Đề Tài')
		select sID as N'Mã Đề Tài', p.sName as N'HTên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
		where (charindex(@sInput, p.sName) > 0) and p.teacher_ID = t.sMGV
 	if (@sKind = N'Loại Đề Tài')
				select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
		where (charindex(@sInput, sCategory) > 0) and p.teacher_ID = t.sMGV
	if (@sKind = N'Bộ Môn')
		select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
		where (charindex(@sInput, p.sSubject) > 0) and p.teacher_ID = t.sMGV
	if (@sKind = N'MGV Quản Lý')
		select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
		where (charindex(@sInput, teacher_ID) > 0) and p.teacher_ID = t.sMGV
	if (@sKind = N'MSV Tham Gia')
		select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t, dbo.Student as s, dbo.Student_Project sp
		where (charindex(@sInput, s.sMSSV) > 0) and p.teacher_ID = t.sMGV and s.sMSSV = sp.Student_MSSV and p.sID = sp.Project_ID
	if (@sKind = N'Kết Quả' and @sInput = N'Đậu')
		select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
		where (p.iGrade >= 5) and p.teacher_ID = t.sMGV
	if (@sKind = N'Kết Quả' and @sInput = N'Rớt')
		select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
		where (p.iGrade < 5) and p.teacher_ID = t.sMGV
	if (@sKind = N'Kết Quả' and @sInput = N'Đang Thực Hiện')
		select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
		where (p.iGrade is null) and p.teacher_ID = t.sMGV
	if (@sKind = N'Tất cả')
		select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
		where p.teacher_ID = t.sMGV
END
GO
-- DROP PROCEDURE USP_SearchProject

create proc USP_DeleteStudent @sMSSV nvarchar(30)
AS
BEGIN
	delete from dbo.Student_Project
	where @sMSSV = Student_MSSV
	delete from dbo.Student
	where @sMSSV = sMSSV
END
GO
-- DROP PROCEDURE USP_DeleteStudent

create proc USP_DeleteTeacher @sMGV nvarchar(30)
AS
BEGIN
	update dbo.Project
	set teacher_ID = N'None'
	where @sMGV = teacher_ID

	delete from dbo.Teacher
	where @sMGV = sMGV
END
GO
-- DROP PROCEDURE USP_DeleteTeacher

create proc USP_DeleteProject @sID nvarchar(30)
AS
BEGIN
	delete from dbo.Student_Project
	where @sID = Project_ID
	delete from dbo.Project
	where @sID = sID
	delete from dbo.Comment
	where @sID = sID
END
GO

-- DROP PROCEDURE USP_DeleteProject

create proc USP_ShowStudent 
AS
BEGIN
	select sMSSV as N'MSSV', sName as N'Họ Tên', dtBirth as N'Ngày Sinh', sPhone as N'SĐT', sEmail as N'Email', sFaculty as 'Khoa', iYear as 'Năm Nhập Học'  from dbo.Student
END
GO

-- DROP PROCEDURE USP_ShowStudent

create proc USP_ShowTeacher
AS
BEGIN
	select sMGV as N'Mã Giáo Viên', sName as N'Họ Tên', dtBirth as N'Ngày Sinh' , sPhone as N'SĐT', sEmail as N'Email', sFaculty as N'Khoa', sSubject as N'Bộ Môn'  from dbo.Teacher
END
GO

-- DROP PROCEDURE USP_ShowTeacher

create proc USP_ShowProject 
AS
BEGIN
	select sID as N'Mã Đề Tài', p.sName as N'Tên Đề Tài', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm', t.sName as N'Giảng Viên Hỗ Trợ'  from dbo.Project as p, dbo.Teacher as t
	where  p.teacher_ID = t.sMGV
END
GO

-- DROP PROCEDURE USP_ShowProject


create PROC USP_SearchProjectSV @sMSSV nvarchar(30)
AS 
BEGIN
	select sID as N'Mã Đề Tài', p.sName as N'Tên', p.sCategory as N'Loại', p.sSubject as N'Bộ Môn', p.iGrade as N'Điểm' from dbo.Project as p, dbo.Student as s, dbo.Student_Project as sp
	where @sMSSV = sp.Student_MSSV and sp.Project_ID = p.sID and s.sMSSV = sp.Student_MSSV
END
GO

create PROC USP_SearchStudentPJ @sID nvarchar(30)
AS 
BEGIN
	select sd.sMSSV as N'MSSV', sd.sName as N'Họ Tên', sd.dtBirth as N'Ngày Sinh',  sd.sFaculty as 'Khoa', sd.iYear as 'Năm Nhập Học'  from dbo.Student as sd, dbo.Project as pj, dbo.Student_Project as sp
	where  sd.sMSSV = sp.Student_MSSV and pj.sID = sp.Project_ID and @sID = sID
END
GO
-- DROP PROCEDURE USP_SearchProjectSV

create Table ChartProject 
(
		sResult nvarchar(50),
		iGrade int,
)
GO

create PROC USP_ChartProject
AS
BEGIN
	DECLARE @Dau int
	DECLARE @DangThucHien int
	DECLARE @Rot int

	Set @Dau = (SELECT COUNT(*) FROM DBO.Project WHERE iGrade > 5)
	Set @DangThucHien = (SELECT COUNT(*) FROM DBO.Project WHERE iGrade is null)
	Set @Rot = (SELECT COUNT(*) FROM DBO.Project WHERE iGrade < 5)

	delete from dbo.ChartProject

	Insert into dbo.ChartProject Values (N'Đậu' , @Dau )
	Insert into dbo.ChartProject Values (N'Rớt' , @Rot )
	Insert into dbo.ChartProject Values (N'Đang Thực Hiện' , @DangThucHien )

	Select * from dbo.ChartProject
END
GO

-- DROP PROCEDURE USP_ChartProject


create PROC USP_ChartStudent
AS
BEGIN
	SELECT sSex , COUNT(sSex) as iCount  from dbo.Student
	GROUP BY sSex
END
GO

-- DROP PROCEDURE USP_ChartStudent


create PROC USP_ChartTeacher
AS
BEGIN
	SELECT sSex , COUNT(sSex) as iCount  from dbo.Teacher
	GROUP BY sSex
END
GO

-- DROP PROCEDURE USP_ChartTeacher


create PROC USP_GetListStudentInProject @sID nvarchar(50)
AS
BEGIN
	select Student.* from dbo.Student, dbo.Student_Project, dbo.Project
	where Project.sID = @sID
	and Project.sID = Student_Project.Project_ID
	and Student.sMSSV = Student_Project.Student_MSSV 
END
GO

-- DROP PROCEDURE USP_GetListStudentInProject


