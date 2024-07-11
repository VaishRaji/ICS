create database Assignment1

create table Clients(client_id int primary key,cname varchar(40) not null,address varchar(30) unique,phone int,business varchar(20) not null)
create table Departments(deptno int primary key,edname varchar(15) not null,loc varchar(20))
create table Employees(empno int primary key,ename varchar(20) not null,job varchar(15),salary int,deptno int references Departments(deptNo))
create table Projects(project_id int primary key,descr varchar(30) not null,startdate date,planned_end_date date,actual_end_date date,budget int,client_id int references Clients(client_id))
create table Empprojecttasks(project_id int primary key,empno int,startdate date,enddate date,task varchar(25) not null,status varchar(15) not null)

alter table Clients add email varchar(30)
alter table Employees add constraint chk_salary_positive check(salary>0)
alter table Projects add constraint chk_budget_positive check(budget>0)
alter table Projects add constraint chk_actual_end_date check(actual_end_date>planned_end_date)
alter table Empprojecttasks add constraint fk_project_employees_projects foreign key(project_id) references Projects(project_id)
alter table Empprojecttasks add constraint fk_project_employees_employees foreign key(empno) references Employees(empno)

insert into Clients values(1001,'ACME utilities','Nodia',9567880032,'manufacturing','contact@acmeutil.com'),(1002,'Trackon consultants','Mumbai',8734210090,'consultant','consult@trackon.com'),(1003,'Moneysaver distributors','Kolkata',7799886655,'reseller','save@moneysaver.com'),(1004,'Lawful corp','Chennai',9210342219,'professional','justice@lawful.com')
insert into Clients (client_id, cname, address, phone, business, email)
values
    (1001,'ACME utilities','Nodia',9567880032,'manufacturing','contact@acmeutil.com'),
    (1002,'Trackon consultants','Mumbai',8734210090,'consultant','consult@trackon.com'),
    (1003,'Moneysaver distributors','Kolkata',7799886655,'reseller','save@moneysaver.com'),
    (1004,'Lawful corp','Chennai',9210342219,'professional','justice@lawful.com');


insert into Employees (empno, ename, job,salary, deptno)
values
    (7001,'sandeep','analyst',25000,10),
	(7002,'rajesh','designer',30000,10),
	(7003,'madhav','developer',40000,20),
	(7004,'manoj','developer',40000,20),
	(7005,'abhay','designer',35000,10),
	(7006,'uma','tester',30000,30),
	(7007,'gita','tech.writer',30000,40),
	(7008,'priya','tester',35000,30),
	(7009,'nutan','developer',45000,20),
	(7010,'smita','analyst',20000,10),
	(7011,'anand','project manager',65000,10)

insert into Departments(deptno, edname, loc)
values (10,'design','pune'),(20,'developement','pune'),(30,'testing','mumbai'),(40,'document','mumbai')


insert into Projects(project_id,descr,startdate,planned_end_date,actual_end_date,budget,client_id)
values(401,'Inventory',	'01-Apr-11','01-Oct-11','31-Oct-11',150000,1001),
(402,'Accounting','01-Aug-11','01-Jan-12',500000,1002),
(403,'Payroll','01-Oct-11','31-Dec-11',75000,1003),
(404,'Contact Mgmt','01-Nov-11','31-Dec-11',50000,1004)


insert into Empprojecttasks(project_id,empno,startdate,enddate,task,status)
values(401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed'),
(401,7002,'21-Apr-11','30-May-11','System Design','Completed'),
(401,7003,'01-Jun-11','15-Jul-11','Coding'	,'Completed'),
(401,7004,'18-Jul-11','01-Sep-11','Coding','Completed'),
(401,7006,'03-Sep-11','15-Sep-11','Testing','Completed'),
(401,7009,'18-Sep-11','05-Oct-11','Code Change','Completed'),
(401,7008,'06-Oct-11','16-Oct-11','Testing','Completed'),
(401,7007,'06-Oct-11','22-Oct-11','Documentation','Completed'),
(401,7011,'22-Oct-11','31-Oct-11','Sign off','Completed'),
(402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed'),
(402,7002,'22-Aug-11','30-Sep-11','System Design','Completed'),
(402,7004,'01-Oct-11',NULL,'Coding','In Progress')

drop table Clients
drop table Departments
drop table Employees
drop table Empprojecttasks
drop table Projects

create database AQ1
create table Clients(client_ID int primary key,cname varchar(40) not null,addresss varchar(30),email varchar(30) unique,phone varchar(10),business varchar(20) not null)
create table Departments(deptno int primary key,dname varchar(15) not null,loc varchar(20))
create table Employees(empno int primary key,ename varchar(20) not null,job varchar(15),salary float check (Salary>0),deptno int references Departments(deptno))
create table Projects(project_ID int primary key,descr varchar(30) not null,start_date DATE,planned_end_date DATE,actual_end_date DATE,budget float(10) check (budget>0),client_ID int references Clients(client_ID))
create table EmpProjectTasks(project_ID int,empno int,start_date DATE,end_date DATE,task varchar(25) not null,status varchar(15) not null
 PRIMARY KEY (project_ID, empno),
 CONSTRAINT FK_EmpProjTasks_projectID FOREIGN KEY (project_ID) REFERENCES Projects(project_ID),
 CONSTRAINT FK_EmpProjTasks_empno FOREIGN KEY (empno) REFERENCES Employees(empno))
 
insert into Clients values
(1001,'ACME Utilities','Noida','contact@acmeutil.com','9567880032','Manufacturing'),
(1002,'Trackon Consultants','Mumbai','consult@trackon.com', '8734210090','Consultant'),
(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com','7799886655','Reseller'),
(1004,'Lawful Corp','Chennai','justice@lawful.com','9210342219','Professional')
insert into Departments values
(10,'Design','Pune'),
(20,'Development','Pune'),
(30,'Testing','Mumbai'),
(40,'Document','Mumbai')
insert into Employees values
(7001, 'Sandeep', 'Analyst', 25000, 10),
(7002, 'Rajesh', 'Designer', 30000, 10),
(7003, 'Madhav', 'Developer', 40000, 20),
(7004, 'Manoj', 'Developer', 40000, 20),
(7005, 'Abhay', 'Designer', 35000, 10),
(7006, 'Uma', 'Tester', 30000, 30),
(7007, 'Gita', 'Tech. Writer', 30000, 40),
(7008, 'Priya', 'Tester', 35000, 30),
(7009, 'Nutan', 'Developer', 45000, 20),
(7010, 'Smita', 'Analyst', 20000, 10),
(7011, 'Anand', 'Project Mgr', 65000, 10)
insert into Projects values
(401, 'Inventory', '2011-04-01', '2011-10-01', '2011-10-31', 150000, 1001),
(402, 'Accounting', '2011-08-01', '2012-01-01', NULL, 500000, 1002),
(403, 'Payroll', '2011-10-01', '2011-12-31', NULL, 75000, 1003),
(404, 'Contact Mgmt', '2011-11-01', '2011-12-31', NULL, 50000, 1004)
insert into EmpProjectTasks values
(401, 7001, '2011-04-01', '2011-04-20', 'System Analysis', 'Completed'),
(401, 7002, '2011-04-21', '2011-05-30', 'System Design', 'Completed'),
(401, 7003, '2011-06-01', '2011-07-15', 'Coding', 'Completed'),
(401, 7004, '2011-07-18', '2011-09-01', 'Coding', 'Completed'),
(401, 7006, '2011-09-03', '2011-09-15', 'Testing', 'Completed'),
(401, 7009, '2011-09-18', '2011-10-05', 'Code Change', 'Completed'),
(401, 7008, '2011-10-06', '2011-10-16', 'Testing', 'Completed'),
(401, 7007, '2011-10-06', '2011-10-22', 'Documentation', 'Completed'),
(401, 7011, '2011-10-22', '2011-10-31', 'Sign off', 'Completed'),
(402, 7010, '2011-08-01', '2011-08-20', 'System Analysis', 'Completed'),
(402, 7002, '2011-08-22', '2011-09-30', 'System Design', 'Completed'),
(402, 7004, '2011-10-01', NULL, 'Coding', 'In Progress')

select * from Clients
select * from Departments
select * from Employees
select * from Projects
select * from EmpProjectTasks