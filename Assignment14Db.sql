create database Assignment14Db

use Assignment14Db

create table Category(
Id int primary key,
CourceCategory nvarchar(50) not null unique)

create table Cource(
Id int primary key,
Name nvarchar(50),
Fee float,
SDate datetime,
CourceCategory int foreign key references Category(Id))

insert into Category values(1,'MCA')
insert into Category values(2,'MBA')
insert into Category values(3,'Btech')
insert into Category values(4,'English')

select * from Category

insert into Cource values(1,'Cyber Security',50000,'10-05-2020',1)
insert into Cource values(2,'AI',60000,'01-01-2020',3)
insert into Cource values(3,'Finance',20000,'10-05-2020',2)
insert into Cource values(4,'Litrature',30000,'03-15-2021',4)

select * from Cource

