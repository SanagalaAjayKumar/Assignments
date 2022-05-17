create database assign1sql
use assign1sql
--1 create table employee
create table Emp8(Empid int,empname varchar(20),Salary float,Deptno int)
insert into Emp8 values (101,'ajay',50000,10),
 (102,'kumar',5000,20),
 (103,'vishwa',25000,30),
 (104,'kishore',35000,40),
 (101,'vamsi',50000,50)
 select * from Emp8
 select * from Emp8 where Deptno= 10 or Deptno = 20 or Deptno=30
 select * from Emp8 where salary between 5000 and 50000

 --2 query age in days
 
 select DATEDIFF(dd,'1998/09/7','2022/05/17') AS DOB

