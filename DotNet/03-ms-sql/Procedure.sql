USE Northwind
GO

IF OBJECT_ID('dbo.GreatestOrders') IS NOT NULL
     DROP PROCEDURE dbo.GreatestOrders
GO

IF OBJECT_ID('dbo.GreatestOrdersCur') IS NOT NULL
     DROP PROCEDURE dbo.GreatestOrdersCur
GO

IF OBJECT_ID('dbo.ShippedOrdersDiff') IS NOT NULL
     DROP PROCEDURE dbo.ShippedOrdersDiff
GO

IF OBJECT_ID('dbo.SubordinationInfo') IS NOT NULL
     DROP PROCEDURE dbo.SubordinationInfo
GO

IF OBJECT_ID('dbo.IsBoss') IS NOT NULL
     DROP FUNCTION dbo.IsBoss
GO

-- 1.a

CREATE PROCEDURE GreatestOrders @year INT, @recordsToReturn INT 
AS
SELECT TOP(@recordsToReturn)
   (SELECT CONCAT(FirstName, ' ', LastName) 
	FROM Employees 
	WHERE EmployeeID = o.EmployeeID) AS Seller,
	MAX(os.Subtotal) AS MaxSubtotal
FROM
	Orders AS o 
JOIN 
	[Order Subtotals] AS os ON o.OrderID = os.OrderID
WHERE
	DATEPART(YEAR, o.OrderDate) = @year
GROUP BY
	o.EmployeeID
ORDER BY
	MaxSubtotal DESC
GO

CREATE PROCEDURE GreatestOrdersCur @year INT, @recordsToReturn INT 
AS
DECLARE @GreatestOrdersTable TABLE (Seller NVARCHAR(50), MaxSubtotal MONEY)
DECLARE @Seller NVARCHAR(50)
DECLARE @MaxSubtotal MONEY
DECLARE @Counter INT
SET @Counter = 0

DECLARE GreatestOrdersCursor CURSOR FOR
SELECT
   (SELECT CONCAT(FirstName, ' ', LastName) 
	FROM Employees 
	WHERE EmployeeID = o.EmployeeID) AS Seller,
	MAX(os.Subtotal) AS MaxSubtotal
FROM
	Orders AS o 
JOIN 
	[Order Subtotals] AS os ON o.OrderID = os.OrderID
WHERE
	DATEPART(YEAR, o.OrderDate) = @year
GROUP BY
	o.EmployeeID
ORDER BY
	MaxSubtotal DESC

OPEN GreatestOrdersCursor

FETCH NEXT FROM GreatestOrdersCursor INTO @Seller, @MaxSubtotal

WHILE @@FETCH_STATUS = 0  
BEGIN
	IF @Counter >= @recordsToReturn
	BEGIN
		BREAK
	END

	SET @Counter = @Counter + 1

	INSERT INTO @GreatestOrdersTable VALUES (@Seller, @MaxSubtotal)
	FETCH NEXT FROM GreatestOrdersCursor INTO @Seller, @MaxSubtotal
END

CLOSE GreatestOrdersCursor
DEALLOCATE GreatestOrdersCursor

SELECT * FROM @GreatestOrdersTable
GO



-- 1.b

CREATE PROCEDURE ShippedOrdersDiff @specifiedDelay INT
AS
SELECT
	OrderID,
	OrderDate,
	ShippedDate,
	DATEDIFF(DAY, OrderDate, ShippedDate) AS ShippedDelay,
	@specifiedDelay AS SpecifiedDelay
FROM
	Orders AS o
WHERE
	DATEDIFF(DAY, OrderDate, ShippedDate) > @specifiedDelay
	OR
	ShippedDate IS NULL
GO



-- 1.c

CREATE PROCEDURE SubordinationInfo @employeeID INT
AS
DECLARE SubordinationInfoCursor CURSOR FOR
WITH SubordinationInfo_CTE (EmployeeID, ReportsTo, [Level]) AS 
(
-- Anchor member definition
    SELECT 
		EmployeeID, 
		ReportsTo, 
		0 AS [Level]
    FROM 
		Employees
    WHERE 
		EmployeeID = @employeeID

    UNION ALL

-- Recursive member definition
    SELECT 
		e.EmployeeID, 
		e.ReportsTo, 
		[Level] + 1
    FROM 
		Employees AS e
	JOIN 
		SubordinationInfo_CTE AS si ON e.ReportsTo = si.EmployeeID
)
-- Statement that executes the CTE
SELECT
	(SELECT CONCAT(FirstName, ' ', LastName) FROM Employees WHERE EmployeeID = si.EmployeeID) AS Employee,
	[Level]
FROM SubordinationInfo_CTE AS si

DECLARE @employee NVARCHAR(30)
DECLARE @level INT

OPEN SubordinationInfoCursor

FETCH NEXT FROM SubordinationInfoCursor INTO @employee, @level
WHILE @@FETCH_STATUS = 0
BEGIN   
	PRINT SPACE(@level * 4) + @employee
	FETCH NEXT FROM SubordinationInfoCursor INTO @employee, @level
END

CLOSE SubordinationInfoCursor
DEALLOCATE SubordinationInfoCursor
GO



-- 1.d

CREATE FUNCTION IsBoss (@employeeID INT)
RETURNS BIT 
AS
BEGIN
	IF EXISTS(SELECT 1 FROM Employees WHERE ReportsTo = @employeeID)
		RETURN 1
	RETURN 0
END
GO
