create table Unit
(
	id int identity(1,1) primary key,
	displayName nvarchar(max)
)
go

create table Suplier
(
	id int identity(1,1) primary key,
	DiplayName nvarchar(max),
	address nvarchar(max),
	phone nvarchar(20),
	email nvarchar(200),
)
go

create table Customer
(
	id int identity(1,1) primary key,
	DiplayName nvarchar(max),
	address nvarchar(max),
	phone nvarchar(20),
	email nvarchar(200),
)
go

create table Goods
(
	id nvarchar(128) primary key,
	DisplayName nvarchar(max), 
	idUnit int not null,
	idSuplier int not null,

	foreign key(idUnit) references Unit(id),
	foreign key(idSuplier) references suplier(id)
)
go

create table phieuNhap
(
	id nvarchar(128) primary key,
	datePhieuNhap datetime
)
go
create table infoPhieuNhap
(
	id nvarchar(128) primary key,
	idGood nvarchar(128) not null,
	idPhieuNhap nvarchar(128) not null,
	count int,
	inputPrice float default 0,
	outputPrice float default 0,
	status nvarchar(max),

	foreign key(idGood) references Goods(id),
	foreign key(idPhieuNhap) references phieuNhap(id)
)
go

create table phieuXuat
(
	id nvarchar(128) primary key,
	datePhieuXuat datetime
)
go
create table infoPhieuXuat
(
	id nvarchar(128) primary key,
	idGood nvarchar(128) not null,
	idInfoPhieuNhap nvarchar(128) not null,
	idCustomer int not null,
	count int,
	status nvarchar(max),

	foreign key(idGood) references Goods(id),
	foreign key(idInfoPhieuNhap) references phieuNhap(id)
)
go