create database Assignment1
use Assignment1
create table employee(
empno int not null, 
ename varchar(20),
job varchar(20), 
age int not null, 
mgr_Id int , 
hiredate varchar(15), 
salary int, 
comm int, 
deptno int);
insert into employee values(7369,'SMITH','CLERK',22,7902,'17-DEC-80',800,null,20);
insert into employee values(7499,'ALLEN','SALESMAN',23,7698,'20-FEB-81',1600,300,30);
insert into employee values(7521,'WARD','SALESMAN', 24,7698,'22-FEB-81',1250,500,30);
insert into employee values(7566,'JONES','MANAGER',25,7839,'02-APR-81',2975,null,20);
insert into employee values(7654,'MARTIN','SALESMAN',26,7698,'28-SEP-81',1250,1400,30);
insert into employee values(7698,'BLAKE','MANAGER',27,7839,'01-MAY-81',2850,null,30);
insert into employee values(7782,'CLARK','MANAGER',28,7839,'09-JUN-81',2450,null,10);
insert into employee values(7788,'SCOTT','ANALYST',29,7566,'19-APR-87',3000 ,null,20);
insert into employee values(7839,'KING','PRESIDENT',22,null,'17-NOV-81',5000,null,10);
insert into employee values(7844,'TURNER','SALESMAN',23,7698,'08-SEP-81',1500,0,30);
insert into employee values(7876,'ADAMS','CLERK',24,7788,'23-MAY-87',1100,null,20);
insert into employee values(7900,'JAMES','CLERK',25,7698,'03-DEC-81',950,null,30);
insert into employee values(7902,'FORD','ANALYST',26,7566,'03-DEC-81',3000,null,20);
insert into employee values(7934,'MILLER','CLERK',27,7782,'23-JAN-82',1300,null,10);
select * from employee;

create table Dept(deptno int not null, dname varchar(25), loc varchar(23))
 insert into Dept values(10,'ACCOUNTING','NEW YORK' );
 insert into Dept values(20,'RESEARCH','DALLAS' );
 insert into Dept values(30,'SALES','CHICAGO' );
 insert into Dept values(40,'OPERATIONS','BOSTON');
 select * from Dept


 --1.question
 select * from employee where ename like 'A%'

 --2.question
 select * from employee where mgr_Id is null

--3.question
select * from employee where salary between 1200 and 1400

--4. question
select salary+salary*10/100 AS "10% Payrise" from employee
Where Job ='PRESIDENT';

--5.question
Select COUNT(*) AS " NUMBER OF CLERKS" from employee Where Job='CLERK';


--6.question
Select AVG(salary) AS "AVG sal",COUNT(*) AS "Number Of People Employed In Each Job" from employee
Group by job;


--7.question
SELECT MAX(salary) AS "MAX Sal" ,MIN(salary) AS "MIN sal" from employee;

--8.question
select ename,salary from employee Where Job ='ANALYST' And deptno=20

Order by ename asc;

--9 question

Select * From Dept

Where deptno not in (select deptno from employee);

--10 question

select job ,DEPTNO, SUM(salary) AS "Total"
from employee
group by job,deptno

--11 question

select salary from employee where ename in('MILLER','SMITH')


--12 question

select ename from employee where ename like 'A%' or ename like'M%'

--13 question

Select salary*12 AS "Year sal" from employee
Where ename='SMITH';

--14 question

Select ename,salary from employee
where salary between 1500 and 2850;




