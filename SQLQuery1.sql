create database grocery 
use grocery

create table account ( 
username varchar(50)  primary key, 
pass varchar(50) , 
atype smallint)

select *from account

insert into account  
values ('admin','admin',1), 
('admin2','admin3',1)

SELECT  FROM account WHERE username = 'admin' and pass = 'admin' 
SELECT username,pass,atype FROM account WHERE username like 'admin' and pass like 'admin'  