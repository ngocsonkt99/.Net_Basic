create database CSDLXe
go
use CSDLXe
go

create table LoaiXe
(
	maloai nvarchar(10)  primary key,
	tenloai nvarchar(100),
	
	
)
go

create table ListXe
(
	ma int  primary key,
	ten nvarchar(100),
	namsx int,
	gia float, 
	hinhanh nvarchar(100),
	loai nvarchar(10) references Loaixe(maloai),
	
)
go

insert into LoaiXe values ('NN','Ngoai nhap')
insert into LoaiXe values ('ND','Noi dia')
insert into LoaiXe values ('LD','Lien doanh')

go

insert into ListXe values('1','Audio','1996','20000','h1.jpg','NN')
insert into ListXe values('2','Ford','1996','20000','h2.jpg','ND')
insert into ListXe values('3','Madaz','1996','20000','h3.jpg','NN')
insert into ListXe values('4','Audio','1996','20000','h1.jpg','ND')
insert into ListXe values('5','Ford','1996','20000','h2.jpg','LD')
insert into ListXe values('6','Madaz','1996','20000','h3.jpg','LD')

