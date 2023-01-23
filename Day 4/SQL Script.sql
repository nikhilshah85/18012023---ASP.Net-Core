create database shoppingDB_MVC

use shoppingDB_MVC

create table productDetails
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)

insert into productDetails values(101,'Iphone','Electronics',140000,1)
insert into productDetails values(102,'Air Pods','Electronics',18000,1)
insert into productDetails values(103,'Maggie','Fast-Food',240,1)
insert into productDetails values(104,'Nike','Shoes',21000,0)

select * from productDetails



create table Customers
(
	cId int primary key,
	cName varchar(20),
	cCity varchar(20),
	cWalletBalance int,
	cProfileIsActive bit
)

insert into Customers values(501,'Ankit','Chennai',800,1
insert into Customers values(502,'Akriti','Pune',1200,1)
insert into Customers values(503,'Sumit','Mumbai',0,0)

alter table productDetails add pManufacturer varchar(20)

select * from productDetails

select * from Customers









