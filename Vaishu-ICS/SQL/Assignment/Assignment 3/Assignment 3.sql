use AQ2
select * from EMP
select * from DEPT

select * from EMP where JOB='MANAGER'

select * from EMP where SAL>1000

select ENAME,SAL from EMP where ENAME != 'JAMES'

select ENAME from EMP where ENAME like 'S%'

select ENAME from EMP where ENAME like '%A%'

select ENAME from EMP where ENAME like '__L%'
select ENAME from EMP where substring(ENAME,3,1)='L'

select ENAME,SAL,SAL/DAY(HIREDATE) AS Dailysalary from EMP where ENAME='JONES'

select SUM(SAL) AS Totalmonthlysalary from EMP 

select AVG(SAL) AS Annualsalary from EMP

select e.ENAME,e.JOB,e.SAL,d.DNAME,e.DEPTNO from EMP e JOIN DEPT d ON e.DEPTNO=d.DEPTNO where d.DEPTNO = 30 AND e.JOB != 'SALESMAN'

select distinct DEPTNO from EMP 
select distinct d.DEPTNO,d.DNAME from DEPT d JOIN EMP e ON e.DEPTNO=d.DEPTNO

select ENAME,SAL,DEPTNO from EMP where SAL>1500 AND DEPTNO IN (10,30)
select ENAME,SAL,DEPTNO from EMP where SAL>1500 AND DEPTNO=10 OR DEPTNO=30 

select ENAME,JOB,SAL from EMP where JOB IN('MANAGER','ANALYST') AND SAL NOT IN(1000,3000,5000)

select ENAME,SAL,COMM from EMP where COMM>SAL * 0.1

select ENAME from EMP where ENAME LIKE '%L%L%' AND DEPTNO=30 OR MGR_ID=7782

select ENAME from EMP where DATEDIFF(Year,HIREDATE, GETDATE()) BETWEEN 30 AND 39;
select getdate()
select ENAME from EMP where year(GETDATE())-year(HIREDATE) BETWEEN 30 AND 40
select count(*) from EMP where year(GETDATE())-year(HIREDATE) BETWEEN 30 AND 40

select d.DNAME AS DEPARTMENT,e.ENAME AS EMPLOYEE from dept d LEFT JOIN EMP e ON d.DEPTNO=e.DEPTNO ORDER BY d.DNAME ASC, e.ENAME DESC

select DATEDIFF(year,HIREDATE,getdate()) AS Millerexp from EMP where ENAME='MILLER'

