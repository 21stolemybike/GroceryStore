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
product_id  int constraint, 
account_id int, 
totalPrice float, 
quantity int,
saved int
)

select * from account
select * from orders
select * from products



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


select sum(totalprice) from orders  where product_id=33


go 
alter procedure GetProductsSale (@productId int, @sum float output,@quant int output ) 
as 
set @sum = (select sum(totalprice) from orders  where product_id= @productId)
set @quant = (select sum(quantity) from orders where product_id = @productId) 

declare @Sum float, @Quant int 
exec GetProductsSale @productId = 33 , @sum = @Sum OUTPUT , @Quant = @quant OUTPUT
select @Sum, @Quant


go 
alter procedure GetAccountTotalValue (@accountId int, @sum float output) 
as 
set @sum = ( select sum(totalPrice) from orders where account_id = @accountId ) 


declare @Sum float 
exec GetAccountTotalValue @accountId = 6, @sum = @Sum output 
select @Sum

go 
alter procedure VerifiyStock(@accountId int,@productId int,@textboxValue int,@result int output) 
as 
declare @stock int
declare @currentUnsavedQuantity int
set @stock = (select stock from products where id = @productId)
set @currentUnsavedQuantity = (select quantity from orders where product_id = @productId and account_id = @accountId and saved = 0) 
if (@stock - @currentUnsavedQuantity - @textboxValue < 0) 
set @result = 0 
else 
set @result = 1 




