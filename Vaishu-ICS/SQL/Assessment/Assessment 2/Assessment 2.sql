create database EmployeeManagement 

create table EmployeeDetails(Empno int primary key,Empname varchar(50) not null,Empsal numeric(10,2) check(Empsal>=25000),Emptype char(1) check(Emptype in('F','P')))
select * from EmployeeDetails

--create procedure EmployeeInsert1 
--@Empname varchar(50),@Empsal numeric(10,2),@Emptype char(1)
--as
--begin
--declare @newEmpno int
--insert into EmployeeDetails(Empname,Empsal,Emptype) values (@Empname,@Empsal,@Emptype);
--set @newEmpno=SCOPE_IDENTITY()
--select @newEmpno as newEmpno
--end

--alter procedure EmployeeInsert1 
--@Empname varchar(50),@Empsal numeric(10,2),@Emptype char(1)
--as
--begin
--declare @newEmpno int
--insert into EmployeeDetails(Empname,Empsal,Emptype) values (@Empname,@Empsal,@Emptype);
--set @newEmpno=@newEmpno +1 
--select @newEmpno as newEmpno
--end

create or alter proc Add_Employee @Empname varchar(50), @Empsal numeric(10, 2), @Emptype char(1)
as
begin
declare @Empno int
    select @Empno=COALESCE(max(Empno), 0) + 1 from EmployeeDetails
    insert into	EmployeeDetails values (@Empno, @Empname, @Empsal, @Emptype)
    select * from EmployeeDetails
end

exec Add_Employee
@Empname='Vaishu',@Empsal=30000,@Emptype='F'