use AQ1
select * from Employees

CREATE PROCEDURE GeneratePayslip2
    @EmployeeID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @EmployeeName NVARCHAR(50)
    DECLARE @Salary DECIMAL(18, 2)
    DECLARE @HRA DECIMAL(18, 2)
    DECLARE @DA DECIMAL(18, 2)
    DECLARE @PF DECIMAL(18, 2)
    DECLARE @IT DECIMAL(18, 2)
    DECLARE @Deductions DECIMAL(18, 2)
    DECLARE @GrossSalary DECIMAL(18, 2)
    DECLARE @NetSalary DECIMAL(18, 2)

    -- Check if EmployeeID exists
    IF NOT EXISTS (SELECT 1 FROM Employees WHERE empno = @EmployeeID)
    BEGIN
        PRINT 'Employee not found.';
        RETURN;
    END

    -- Retrieve employee details
    SELECT @EmployeeName = ename,
           @Salary = Salary
    FROM Employees
    WHERE empno = @EmployeeID;

    -- Calculate HRA, DA, PF, IT based on given percentages
    SET @HRA = @Salary * 0.1;
    SET @DA = @Salary * 0.2;
    SET @PF = @Salary * 0.08;
    SET @IT = @Salary * 0.05;

    -- Calculate Deductions and Gross Salary
    SET @Deductions = @PF + @IT;
    SET @GrossSalary = @Salary + @HRA + @DA;
    SET @NetSalary = @GrossSalary - @Deductions;

    -- Print the payslip
    PRINT '---------------------------';
    PRINT '        Payslip';
    PRINT '---------------------------';
    PRINT 'Employee Name: ' + @EmployeeName;
    PRINT '---------------------------';
    PRINT 'Basic Salary  : ' + CAST(@Salary AS NVARCHAR(20));
    PRINT 'HRA           : ' + CAST(@HRA AS NVARCHAR(20));
    PRINT 'DA            : ' + CAST(@DA AS NVARCHAR(20));
    PRINT '---------------------------';
    PRINT 'Gross Salary  : ' + CAST(@GrossSalary AS NVARCHAR(20));
    PRINT 'PF (8%)       : ' + CAST(@PF AS NVARCHAR(20));
    PRINT 'IT (5%)       : ' + CAST(@IT AS NVARCHAR(20));
    PRINT '---------------------------';
    PRINT 'Deductions    : ' + CAST(@Deductions AS NVARCHAR(20));
    PRINT '---------------------------';
    PRINT 'Net Salary    : ' + CAST(@NetSalary AS NVARCHAR(20));
    PRINT '---------------------------';

END

EXEC GeneratePayslip2 @EmployeeID =7003;


