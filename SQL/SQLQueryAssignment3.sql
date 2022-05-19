
use Assignment2

--****************** Assignment 3********************


select * from Employe

select * from Dept

--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.

select ename, Salary from Employe where Salary not between 1500 and 2850

--2. Display the name and job of all employees who do not have a MANAGER. 

select ename, job from Employe where MGR_id is null

--3. Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000. 

select ename,job,Salary from Employe where job in('MANAGER','ANALYST') and Salary not in(1000,3000,5000)

--4. Display the name, salary and commission for all employees whose commission,amount is greater than their salary increased by 10%


select ename,Salary,comm from Employe where comm > Salary+Salary*.10

--5. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
 
 select ename from Employe where ename like '%LL%' and deptno in (30) or MGR_id =7782

 --6. Display the names of employees with experience of over 10 years and under 20 yrs. Count the total number of employees.
 
 update Employe set hiredate='28-SEP-10' where empno in(7654,7900)

 select count(Hiredate) AS No_of_employe,ename from Employe
 where convert(varchar(3),datediff(YEAR, Hiredate, getdate()))>10
 and convert(varchar(3),datediff(YEAR, Hiredate, getdate()))<20
 group by ename


 --7. Retrieve the names of departments in ascending order and their employees in descending order.

 select Dname,Ename from Dept join Employe on dept.DeptNo = Employe.deptno
 order by Dname asc , ename desc

 --8. Find out experience of MILLER. 

select convert(varchar(5),datediff(year,hiredate,getdate())) as'Experience'
from Employe where ename='MILLER'

 --9. How many different departments are there in the employee table. 

 select Dname,count(*) as 'noof departments' from Employe join dept on
 dept.deptno= Employe.deptno
 group by Dname

 --10. Find out which employee either work in SALES or RESEARCH department. 

 select ename, Dname from Employe join dept on Employe.deptno=dept.DeptNo 
 where Dname in('SALES','RESEARCH')

 --11. Print the name and average salary of each department.
  
 select Dname, avg(Salary) as Avg_Salary from Employe join dept on Employe.Deptno=Dept.DeptNo
 group by Dname

 --12. Select the minimum and maximum salary from employee table. 

 select min(Salary) as min_salary, max(Salary) as max_salary from Employe

 --13. Select the minimum and maximum salaries from each department in employee table.

 select Dname,min(Salary) as min_salary,max(Salary) as max_salary from Employe join dept
 on Employe.Deptno=dept.DeptNo 
 group by Dname 

 --14. Select the details of employees whose salary is below 1000 and job is CLERK. 

 select * from Employe where Salary<1000 and job = 'CLERK'

 