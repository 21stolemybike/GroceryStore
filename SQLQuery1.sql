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
fullName varchar(50) , 
mobile int
)

insert into account (username,pass) values ('Denis','parola')
insert into orders values (1,2,'Test Test','0839219203',20)

select id as 'ID', product_name as 'Product Name', product_weight as 'Product Weight', product_origin as 'Product Origin', manufacture_date as 'Manufacture Date' 
, expiration_date as 'Expiration Date', stock as 'Stock', price as 'Price' from products

select * from orders
select * from products
select * from account

delete from orders where id = (select max(id) from orders)



delete from orders
alter table orders add totalPrice float

select product_name, totalPrice from orders as A inner join products as B on A.product_id = B.id where account_id like 1 



insert into orders values (33,1,(select price*5 from products as B inner join orders as A on A.product_id = B.id where product_id = 33 ))







delete from products where id = 2 

update products set product_name , product_weight, product_origin , manufacture_date , expiration_date , stock where id like 1 









update account set atype = 1 where username like 'test'

update account set pass = 'marius' where username like 'marius'




 
alter table products ALTER COLUMN product_weight float






