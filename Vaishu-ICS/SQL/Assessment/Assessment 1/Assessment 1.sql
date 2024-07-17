create database Assessment1

--1 Display the birthday 
select Datename (dw,'2001-02-03') AS My_Birthday

--2 Display the age
declare @my_birthday date = '2001-02-03'
select DATEDIFF(day,@my_birthday,Getdate()) AS My_Age

--3 Display all employees information those who joined before 5 years in the current month
use AQ2 
select * from EMP
select getdate()

select * from EMP where year(HIREDATE)<=year(Getdate())-5 AND month(HIREDATE)=month(Getdate())

--4 Transaction
use AQ2
select * from EMP

use Assessment1
create table employees(empno int primary key,ename varchar(30),sal decimal(10,2))
alter table employees ADD doj date

BEGIN TRANSACTION
declare @deletedrows table (empno int primary key,ename varchar(30),sal decimal(10, 2),doj date)

--(a) insert 3 rows
insert into employees values 
(1,'vaishu',50000,'2020-02-03'),
(2,'raji',65000,'2019-06-27'),
(3,'ajay',40000,'2018-10-17')
select * from employees

--(b) update the 2nd row sal with 15% increment 
update employees set sal=sal*0.15
where empno=2
select * from employees

--(c)delete the 1st row
delete from employees output deleted.empno,deleted.ename,deleted.sal,deleted.doj into @deletedrows where empno=1
select * from employees

rollback
select * from @deletedrows

--5 User defined Function
use AQ2

create FUNCTION dbo.bonuscalculation(@DEPTNO int,@SAL decimal(7,2)
returns decimal(7,2)
AS
BEGIN
Declare @bonus decimal(7,2)

Set @bonus=case when @DEPTNO=10 Then @SAL * 0.15
                when @DEPTNO =20 Then @SAL * 020
				else @SAL *0.05
           end
    Return @bonus
end 
select EMPNO,ENAME,SAL,DEPTNO,dbo.bonuscalculation(DEPTNO,SAL) AS Bonus from EMP

    

    





