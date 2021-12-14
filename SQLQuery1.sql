create database grocery 
use grocery

create table account ( 
id int not null identity(1,1) primary key,
username varchar(50) , 
pass varchar(50) , 
atype smallint,
fullname varchar(50),
mobile varchar(15))

create table products( 
id int not null identity(1,1) primary key, 
product_name varchar(50), 
product_weight float,
product_origin varchar(50), 
manufacture_date date, 
expiration_date date, 
stock int ,
price float
)

create table orders( 
id int not null identity(1,1) primary key, 
product_id  int constraint fk_productId foreign key references products(id), 
account_id int constraint fk_accountId foreign key references account(id), 
totalPrice float, 
quantity int
)

select * from orders
select * from products
select * from account


delete from orders




go 
create procedure DeleteUnsaved (@accountId int) 
as 
delete from orders where account_id = @accountId and saved = 0 


go 
alter procedure SaveOrder( @orderId int)
as 
declare @productId int
declare @quantity int
set @productId = (select product_id from orders where id = @orderId)
set @quantity = (select quantity from orders where id = @orderId)
update orders set saved = 1 where id = @orderId 
update products set stock = stock - @quantity where id = @productId 
















