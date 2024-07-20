create database Assignment4
---1)Factorial-TSQL
DECLARE @inputNumber INT = 13;  
DECLARE @factorial BIGINT = 1;
DECLARE @counter INT = 1;
IF @inputNumber < 0
BEGIN
    PRINT 'The factorial function does not apply to negative integers.';
END
ELSE IF @inputNumber = 0
BEGIN
    SET @factorial = 1;
END
ELSE
BEGIN
    WHILE @counter <= @inputNumber
    BEGIN
        SET @factorial = @factorial * @counter;
        SET @counter = @counter + 1;
    END;
END;
SELECT @factorial AS FactorialOfNumber;

---2)Multiplication table-Stored procedure 
CREATE PROCEDURE GenerateMultiplicationTable1
    @baseNumber INT,
    @upToNumber INT
AS
BEGIN
    IF @baseNumber <= 0 OR @upToNumber <= 0
    BEGIN
        PRINT 'Both the inputs must be greater than zero.'
        RETURN
    END
    DECLARE @multiplier INT = 1
    DECLARE @result INT
    CREATE TABLE #MultiplicationTable (
        Multiplicand INT,
        Multiplier INT,
        Result INT
    )
    WHILE @multiplier <= @upToNumber
    BEGIN
        SET @result = @baseNumber * @multiplier
        INSERT INTO #MultiplicationTable (Multiplicand, Multiplier, Result)
        VALUES (@baseNumber, @multiplier, @result)
        SET @multiplier = @multiplier + 1
    END
    SELECT Multiplicand, Multiplier, Result
    FROM #MultiplicationTable
    ORDER BY Multiplier
    DROP TABLE #MultiplicationTable
END
GO
EXEC GenerateMultiplicationTable1 @baseNumber = 3, @upToNumber = 10;

---3)Trigger
CREATE TABLE Holiday (Holiday_date DATE PRIMARY KEY,Holiday_name VARCHAR(100))
INSERT INTO Holiday (Holiday_date, Holiday_name) VALUES ('2024-08-15', 'Independence Day'),('2024-09-07', 'Ganesh Chaturthi'),
('2024-10-10', 'Saraswathi Pooja'),('2024-10-24', 'Diwali'),('2024-12-25', 'Christmas')
SELECT * FROM Holiday

CREATE TABLE EMP (EmpID INT PRIMARY KEY,EmpName VARCHAR(100),EmpSalary DECIMAL(10, 2))

CREATE OR ALTER TRIGGER trg_prevent_holiday_manipulation
ON EMP
INSTEAD OF INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @IsHoliday BIT;
    DECLARE @HolidayName VARCHAR(100);
    SELECT @IsHoliday = CASE WHEN EXISTS (
            SELECT 1 
            FROM Holiday 
            WHERE Holiday_date = CONVERT(DATE, GETDATE())
        ) THEN 1 ELSE 0 END,
           @HolidayName = Holiday_name
    FROM Holiday 
    WHERE Holiday_date = CONVERT(DATE, GETDATE());

    IF @IsHoliday = 1
    BEGIN
        DECLARE @ErrorMessage VARCHAR(200);
        SET @ErrorMessage = 'Due to ' + @HolidayName + ', you cannot manipulate data.'
        RAISERROR(@ErrorMessage, 16, 1)
        ROLLBACK TRANSACTION
    END
    ELSE
    BEGIN
  
        IF EXISTS (SELECT * FROM inserted)
        BEGIN
            
           
			INSERT INTO EMP (EmpID, EmpName, EmpSalary) VALUES (1, 'John Doe', 50000.00)
            PRINT 'Data inserted successfully.'
        END
        ELSE IF EXISTS (SELECT * FROM deleted)
        BEGIN
           
           
			DELETE FROM EMP WHERE EmpID = 1
            PRINT 'Data deleted successfully.'
        END
        ELSE
        BEGIN
            
            
			UPDATE EMP SET EmpSalary = 55000.00 WHERE EmpID = 1
            PRINT 'Data updated successfully.'
        END
    END
END