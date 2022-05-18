create database Assignment2
use Assignment2

create table Dept
(
  Deptno int primary key,
  Dname varchar(20)not null,
  Loc varchar(20)
)

insert into Dept values (10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'), (30 ,'SALES','CHICAGO' ),
(40,'OPERATIONS','BOSTON' )
create table Employe
(
Empno int primary key,
Ename varchar(20) not null,
Job varchar(15),
MGR_id int,
Hiredate varchar(20), 
Salary float,
Comm int,
Deptno int foreign key references Dept(Deptno)
)
insert into Employe
values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)
select * from Employe
select * from Dept

--1. Retrieve a list of MANAGERS. 

select Ename from Employe where Empno IN (select MGR_id from Employe)
--2. Find out salary of both MILLER and SMITH. 

select ename, Salary from Employe where ename in('MILLER','SMITH')

--3. Find out the names and salaries of all employees earning more than 1000 per month.

select ename, salary from Employe where Salary>1000 

--4. Display the names and salaries of all employees except JAMES. 

select ename, Salary from Employe where ename != 'JAMES'

--5. Find out the details of employees whose names begin with ‘S’. 

select * from Employe where ename like's%'

--6. Find out the names of all employees that have ‘A’ anywhere in their name. 

select * from Employe where ename like'%A%'

--7. Find out the names of all employees that have ‘L’ as their third character in their name.

select * from Employe where ename like'__L%'

--8. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select * from Employe where ename like 'A%' or ename like 'M%'
 
 --9. Compute yearly salary of SMITH.
 select (Salary*12) as 'Anual salary' from Employe where ename ='SMITH'

 --10. Compute daily salary of JONES.
 select (Salary/24) as 'Daily salary' from Employe where ename ='JONES'

 --11. Calculate the total monthly salary of all employees. 
 select sum(Salary) as 'Total sum' from Employe

 --12. Print the average annual salary. 
 select (Salary*12) from Employe 
 select avg(Salary*12) as 'Average anual sal' from Employe 

 --13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
 select ename, job, Salary, deptno from Employe where (job !='SALESMAN' and deptno =30)

 --14. List unique departments of the EMP table. 
 select distinct(deptno) from Employe
 

 --15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
 --Label the columns Employee and Monthly Salary respectively.
 select ename as'employ name', Salary as'Monthly salary' from Employe 
 where Salary>1500 and deptno in(10,30) 