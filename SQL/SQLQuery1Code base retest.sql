create database Codebase_Retest
use Codebase_Retest


create table Delete_product
(
Product_Id int Primary key,
Product_Name varchar(25),
Price int,
Qty_Available int) 

insert into Delete_product values(101,'Desktop',25000,25),
(102,'Heater',1500,26),
(103,'Mobile_iphone13',1700000,25),
(104,'printer',10000,100)


select * from Delete_product


create or alter proc Items
as
begin
begin try

delete from Delete_product where Product_Id=103
end try
begin catch
print 'Select the matched product'
end catch
end
exec Items



