create database POS

use POS

create table UserAccount
(
	id int identity primary key not null,
	accounttype varchar(255) not null,
	name varchar(255) unique not null,
	username varchar(255) unique not null,
	password varchar(255) not null
)

create table Product
(
	id int identity primary key not null,
	itemcode varchar(255) not null,
	itemdescription varchar(255) not null,
	quantity int not null,
	price float not null
)


create table Employees
(
	id int identity primary key not null,
	lastname varchar(255) not null,
	firstname varchar(255) not null,
	middlename varchar(255) not null
)


create table TransactionHistory
(
	id int identity primary key not null,
	comodity varchar(255) not null,
	employee varchar(255) not null,
	date varchar(255) not null,
	amountpay float not null,
	totalamount float not null,
	itemcode varchar(255) not null,
	itemdescription varchar(255) not null,
	quantity int not null,
	getquantity int not null,
	price float not null,
	subtotal float not null,
	status varchar(255) not null,
	cashier varchar(255) not null
)

create table Inventory
(
	id int identity primary key not null,
	transactionno varchar(255),
	orderby varchar(255),
	itemcode varchar(255),
	itemdescription varchar(255),
	price float,
	quantity int,
	onstock int,
	date varchar(255),
	cashier varchar(255),
	status varchar(255)
)


drop table inventory

select * from inventory

delete from product
delete from transactionhistory
delete from inventory

drop table transactionhistory
delete from transactionhistory
select * from transactionhistory
SELECT amountpay, totalamount, date, employee, status FROM transactionhistory

select itemcode, itemdescription, quantity, price from transactionhistory

drop table transactionhistory

SELECT transactionhistory.employee AS 'Customers', product.itemcode AS 'ItemCode', product.itemdescription AS 'ItemDescription', transactionhistory.quantity AS 'Quantity', transactionhistory.date AS 'DATE', transactionhistory.getquantity AS 'In Stock' from product inner join transactionhistory on transactionhistory.itemcode = product.itemcode 

select * from useraccount
select * from Product
select * from Employees
delete from TransactionHistory
select * from TransactionHistory

insert into UserAccount(accounttype, name, username, password) values('ADMIN', 'Jerome R. Villaruel', 'veo', 'veo123')

select sum(totalamount) from TransactionHistory where employee='Villaruel, Jerome Robiato'

update useraccount set accounttype='ADMIN', username='veo', password='123' where id=1;
delete from useraccount where id=2

update useraccount set accounttype='USER', username='ann', password='123' where id=3;

select quantity from TransactionHistory [where employee='Villaruel, Jerome Robiato']
minus
select quantity from Product 

drop table Product
SELECT itemcode AS 'Item Code', itemdescription AS 'Item Description', quantity AS 'Quantity', price AS 'Price', status AS 'Status' FROM TransactionHistory WHERE date='Monday, January 21, 2019' AND employee='cash' 

select sum(totalamount) from transactionhistory

delete  from transactionhistory