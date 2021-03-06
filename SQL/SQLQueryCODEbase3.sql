create database EmployeeManagement
use EmployeeManagement

create table Code_Employee(
empno int primary key,
empname varchar(50) not null,
empsal numeric(10,2) check (empsal>=25000),
emptype varchar(1) check(emptype in('C','P')))



insert into Code_Employee values
(101,'ajay',30000,'P'),
(102,'rishi', 50000,'C'),
(103,'pandu', 25000,'C')

select * from Code_Employee

create or alter procedure Addnewemploye @ename varchar(20), @esal numeric(10,2), @etype varchar(4)
as
begin
declare @eid int = (select max(empno) from Code_Employee)
begin
declare @empid int = @eid + 1;
insert into Code_Employee values(@empid, @ename, @esal, @etype)
end
end

