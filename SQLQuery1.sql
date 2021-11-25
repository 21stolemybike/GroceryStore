create database grocery 
use grocery

create table account ( 
username varchar(50)  primary key, 
pass varchar(50) , 
atype smallint)

create table products( 
id int not null identity(1,1) primary key, 
product_name varchar(50), 
product_weight float,
product_origin varchar(50), 
manufacture_date date, 
expiration_date date, 
stock int 
)

select * from products



select *from account

insert into account  
values ('admin','admin',1), 
('admin2','admin3',1)

SELECT  FROM account WHERE username = 'admin' and pass = 'admin' 
SELECT username,pass,atype FROM account WHERE username like 'admin' and pass like 'admin'




update account set atype = 1 where username like 'test'

update account set pass = 'marius' where username like 'marius'

create table test ( 
id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
productname varchar(50)

)



alter table products ALTER COLUMN product_weight float

delete from test where id = 7


create table test( 
id int primary key, 
test date)

insert into test 
values(1, '2021-11-25')

select *from test


