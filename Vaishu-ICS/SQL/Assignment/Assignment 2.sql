create database AQ2
create table EMP(EMPNO int PRIMARY KEY,ENAME VARCHAR(20),JOB VARCHAR(20),MGR_ID int,HIREDATE DATE,SAL decimal(7, 2),COMM decimal(7, 2),DEPTNO int);
create table DEPT (DEPTNO int PRIMARY KEY,DNAME VARCHAR(20),LOC VARCHAR(20))

insert into EMP values 
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10)

insert into DEPT values
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON')

select * from EMP
select * from DEPT

--1. List all employees whose name begins with 'A'. 
SELECT *FROM EMP
WHERE ENAME LIKE 'A%';

--2. Select all those employees who don't have a manager. 
SELECT *FROM EMP
WHERE MGR_ID IS NULL;

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
SELECT ENAME, EMPNO, SAL FROM EMP
WHERE SAL BETWEEN 1200 AND 1400;

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
-- Before the pay rise
SELECT *FROM EMP
WHERE DEPTNO = 20;

-- Apply the pay rise
UPDATE EMP SET SAL = SAL * 1.10
WHERE DEPTNO = 20;

-- After the pay rise
SELECT *FROM EMP
WHERE DEPTNO = 20;

--5. Find the number of CLERKS employed. Give it a descriptive heading. 
SELECT COUNT(*) AS "Number of CLERKS" FROM EMP
WHERE JOB = 'CLERK';

--6. Find the average salary for each job type and the number of people employed in each job. 
SELECT JOB, AVG(SAL) AS AVG_SALARY, COUNT(*) AS NUM_EMPLOYEES FROM EMP
GROUP BY JOB;

--7. List the employees with the lowest and highest salary. 
SELECT *FROM EMP
WHERE SAL IN (SELECT MIN(SAL) FROM EMP UNION SELECT MAX(SAL) FROM EMP);

--8. List full details of departments that don't have any employees. 
SELECT *FROM DEPT
WHERE DEPTNO NOT IN (SELECT DISTINCT DEPTNO FROM EMP);

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
SELECT ENAME, SAL FROM EMP
WHERE JOB = 'ANALYST' AND SAL > 1200 AND DEPTNO = 20
ORDER BY ENAME ASC;

--10. For each department, list its name and number together with the total salary paid to employees in that department.
SELECT D.DNAME, D.DEPTNO, SUM(E.SAL) AS TOTAL_SALARY FROM DEPT D
LEFT JOIN EMP E ON D.DEPTNO = E.DEPTNO
GROUP BY D.DNAME, D.DEPTNO;

--11. Find out salary of both MILLER and SMITH.
SELECT ENAME, SAL FROM EMP
WHERE ENAME IN ('MILLER', 'SMITH');

--12. Find out the names of the employees whose name begin with �A� or �M�. 
SELECT ENAME FROM EMP
WHERE ENAME LIKE 'A%' OR ENAME LIKE 'M%';

--13. Compute yearly salary of SMITH. 
SELECT ENAME, SAL * 12 AS YEARLY_SALARY FROM EMP
WHERE ENAME = 'SMITH';

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
SELECT ENAME, SAL FROM EMP
WHERE SAL NOT BETWEEN 1500 AND 2850;

--15. Find all managers who have more than 2 employees reporting to them
SELECT E.ENAME AS MANAGER_NAME, COUNT(*) AS NUM_REPORTS FROM EMP E
JOIN EMP M ON E.EMPNO = M.MGR_ID
GROUP BY E.ENAME
HAVING COUNT(*) > 2;



