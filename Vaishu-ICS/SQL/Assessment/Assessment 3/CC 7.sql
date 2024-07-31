create database Assessment3
use Assessment3

create table Books(id int primary key,title varchar(50),author varchar(50),isbn int,published_date date)
create table Reviews(id int primary key,book_id int,reviewer_name varchar(50),content varchar(50),rating int,published_date date,foreign key(book_id)references Books(id))
create table Customers(id int primary key,name varchar(50),age int,address varchar(100),salary decimal(10,2))
create table Orders(oid int primary key,orderdate date,cutomer_id int,amount int,foreign key(cutomer_id)references Customers(id))
create table Employee(id int primary key,name varchar(50),age int,address varchar(100),salary decimal(10,2))
create table Studentdetails(sn_no int primary key,registerno int,studname varchar(50),age int,qualifications varchar(30),mobileno int,mail_id varchar(50),loc varchar(50),gender varchar(10)) 

alter table Books alter column published_date datetime
alter table Books alter column isbn bigint 

insert into Books values(1,'MyFirstSqlBook','Mary Parker',981483029127,'2012-02-22 12:08:17')
insert into Books values(2,'MySecondSqlBook','John Mayer',857300923713,'1972-07-03 09:22:45')
insert into Books values(3,'MyThirdSqlBook','Cary Flint',523120967812,'2015-10-18 14:05:44')

select * from Books

insert into Reviews values(1,1,'john smith','MyFirstReview',4,'2017-12-10 05:50:11')
insert into Reviews values(2,2,'john smith','MySecondtReview',5,'2017-10-13 15:05:12')
insert into Reviews values(3,2,'john smith','MyFirstReview',4,'2017-10-22 23:47:10')

select * from Reviews

insert into Customers values(1,'Ramesh',32,'ahmedabad',2000.00)
insert into Customers values(2,'khilan',25,'delhi',1500.00)
insert into Customers values(3,'kaushik',23,'kota',2000.00)
insert into Customers values(4,'chaitali',25,'mumbai',6500.00)
insert into Customers values(5,'hardik',27,'bhopal',8500.00)
insert into Customers values(6,'komal',22,'mp',4500.00)
insert into Customers values(7,'muffy',24,'indore',10000.00)

select * from Customers

insert into Orders values(102,'2009-10-08 00:00:00',3,3000)
insert into Orders values(100,'2009-10-08 00:00:00',3,1500)
insert into Orders values(101,'2009-11-20 00:00:00',2,1560)
insert into Orders values(103,'2089-05-20 00:00:00',4,2860)

select * from Orders

insert into Employee values(1,'Ramesh',32,'ahmedabad',2000.00)
insert into Employee values(2,'khilan',25,'delhi',1500.00)
insert into Employee values(3,'kaushik',23,'kota',2000.00)
insert into	Employee values(4,'chaitali',25,'mumbai',6500.00)
insert into Employee values(5,'hardik',27,'bhopal',8500.00)
insert into Employee values(6,'komal',22,'mp',null)
insert into Employee values(7,'muffy',24,'indore',null)

select * from Employee

--1
select b.title, b.author, r.reviewer_name from Books b JOIN Reviews r ON b.id = r.book_id
where b.author LIKE '%er';



--2
select reviewer_name from (
    select reviewer_name, COUNT(*) AS num_reviews from Reviews
    group by reviewer_name) AS ReviewCounts
where num_reviews > 1;


--3
select name from Customers
where address LIKE '%o%';



--4
select orderdate, COUNT(DISTINCT cutomer_id) AS TotalCustomers from Orders
GROUP BY orderdate;



--5
select LOWER(name) AS lowercase_name from Employee
where salary IS NULL;



--6
select gender, COUNT(*) AS TotalCount from Studentdetails
GROUP BY gender;
