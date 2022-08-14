USE Northwind
GO

-- [������ � ������ ������ Date, NULL ����������, ����������� ������.]

-- 1.a 
-- ������� � ������� Orders ������, ������� ���� ���������� ����� 6 ��� 1998 ���� (������� ShippedDate) ������������ �
-- ������� ���������� � ShipVia >= 2. ������ �������� ���� ������ ���� ������ ��� ����� ������������ ����������, ��������
-- ����������� ������ �Writing International Transact-SQL Statements� � Books Online ������ �Accessing and Changing Relational Data
-- Overview�. ���� ����� ������������ ����� ��� ���� �������. ������ ������ ����������� ������ ������� OrderID, ShippedDate
-- � ShipVia.

SELECT
	OrderID,
	ShippedDate,
	ShipVia
FROM
	Orders
WHERE 
	DATEPART(YEAR, ShippedDate) >= 1998 AND DATEPART(MONTH, ShippedDate) >= 5 AND DATEPART(DAY, ShippedDate) >= 6 
	AND 
	ShipVia >= 2
GO

-- Q: �������� ������ ���� �� ������ ������ � NULL-�� � ������� ShippedDate.
-- A: ������ ��� � NULL ������ ��������� �������� ���������.

-- 1.b
-- �������� ������, ������� ������� ������ �������������� ������ �� ������� Orders. � ����������� ������� ����������� ���
-- ������� ShippedDate ������ �������� NULL ������ �Not Shipped� � ������������ ��������� ������� CAS�. ������ ������
-- ����������� ������ ������� OrderID � ShippedDate.

SELECT
	OrderID,
	CASE
		WHEN ShippedDate IS NULL THEN 'Not Shipped'
	END AS ShippedDate
FROM
	Orders
WHERE 
	ShippedDate IS NULL
GO

-- 1.c
-- ������� � ������� Orders ������, ������� ���� ���������� ����� 6 ��� 1998 ���� (ShippedDate), �� ������� ��� ����, ���
-- ������� ��� �� ����������. � ������� ������ ������������� ������ ������� OrderID (������������� � Order Number) �
-- ShippedDate (������������� � Shipped Date). � ����������� ������� ����������� ��� ������� ShippedDate ������ ��������
-- NULL ������ �Not Shipped�, ��� ��������� �������� ����������� ���� � ������� �� ���������.

SELECT
	OrderID AS [Order Number],
	CASE
		WHEN ShippedDate IS NULL THEN 'Not Shipped'
		ELSE CONVERT(NVARCHAR(20), ShippedDate, 0)	-- 0 - ������ �� ��������� ��� datetime � smalldatetime
	END AS [Shipped Date]
FROM
	Orders
WHERE 
	DATEPART(YEAR, ShippedDate) >= 1998 AND DATEPART(MONTH, ShippedDate) >= 5 AND DATEPART(DAY, ShippedDate) > 6
	OR 
	ShippedDate IS NULL
GO



-- [������������� ���������� IN, DISTINCT, ORDER BY, NOT]

-- 2.a
-- ������� �� ������� Customers ���� ����������, ����������� � USA � Canada. ������ ������� ������ � ������� ���������
-- IN. ����������� ������� � ������ ������������ � ��������� ������ � ����������� �������. ����������� ���������� �������
-- �� ����� ���������� � �� ����� ����������.

SELECT
	ContactName,
	Country
FROM
	Customers
WHERE
	Country IN ('USA', 'Canada')
ORDER BY
	ContactName ASC, Address ASC
GO

-- 2.b
-- ������� �� ������� Customers ���� ����������, �� ����������� � USA � Canada. ������ ������� � ������� ��������� IN.
-- ����������� ������� � ������ ������������ � ��������� ������ � ����������� �������. ����������� ���������� ������� ��
-- ����� ����������.

SELECT
	ContactName,
	Country
FROM
	Customers
WHERE
	Country NOT IN ('USA', 'Canada')
ORDER BY
	ContactName ASC
GO

-- 2.c
-- ������� �� ������� Customers ��� ������, � ������� ��������� ���������. ������ ������ ���� ��������� ������ ���� ���, �
-- ������ ������������ �� ��������. �� ������������ ����������� GROUP BY. ����������� ������ ���� ������� � �����������
-- �������.

SELECT DISTINCT
	Country
FROM
	Customers
ORDER BY
	Country DESC
GO



-- [������������� ��������� BETWEEN, DISTINCT]

-- 3.a
-- ������� ��� ������ (OrderID) �� ������� Order Details (������ �� ������ �����������), ��� ����������� �������� �
-- ����������� �� 3 �� 10 ������������ � ��� ������� Quantity � ������� Order Details. ������������ �������� BETWEEN. ������
-- ������ ����������� ������ ������� OrderID.

SELECT DISTINCT
	OrderID
FROM
	[Order Details]
WHERE
	Quantity BETWEEN 3 AND 10
GO

-- 3.b
-- ������� ���� ���������� �� ������� Customers, � ������� �������� ������ ���������� �� ����� �� ��������� b � g.
-- ������������ �������� BETWEEN. ���������, ��� � ���������� ������� �������� Germany. ������ ������ �����������
-- ������ ������� CustomerID � Country � ������������ �� Country.

-- 3.c
-- ������� ���� ���������� �� ������� Customers, � ������� �������� ������ ���������� �� ����� �� ��������� b � g, ��
-- ��������� �������� BETWEEN. � ������� ����� �Execution Plan� ���������� ����� ������ ���������������� 3.2 ��� 3.3 � ���
-- ����� ���� ������ � ������ ���������� ���������� Execution Plan-a ��� ���� ���� ��������, ���������� ���������� Execution
-- Plan ���� ������ � ������ � ���� ����������� � �� �� ����������� ���� ����� �� ������ � �� ������ ��������� ����
-- ��������� ���������. ������ ������ ����������� ������ ������� CustomerID � Country � ������������ �� Country.

SET SHOWPLAN_TEXT ON
GO

SELECT
	CustomerID,
	Country
FROM
	Customers
WHERE
	LEFT(Country, 1) BETWEEN 'b' AND 'g'
ORDER BY
	Country ASC
GO

SELECT
	CustomerID,
	Country
FROM
	Customers
WHERE
	LEFT(Country, 1) >= 'b' AND LEFT(Country, 1) <= 'g'
ORDER BY
	Country ASC
GO

SET SHOWPLAN_TEXT OFF
GO

-- 1 ������
-- |--Sort(ORDER BY:([Northwind].[dbo].[Customers].[Country] ASC))
--        |--Clustered Index Scan(OBJECT:([Northwind].[dbo].[Customers].[PK_Customers]), 
--			WHERE:(substring([Northwind].[dbo].[Customers].[Country],(1),(1))>=N'b'
--			AND substring([Northwind].[dbo].[Customers].[Country],(1),(1))<=N'g'))

-- 2 ������
-- |--Sort(ORDER BY:([Northwind].[dbo].[Customers].[Country] ASC))
--        |--Clustered Index Scan(OBJECT:([Northwind].[dbo].[Customers].[PK_Customers]), 
--			WHERE:(substring([Northwind].[dbo].[Customers].[Country],(1),(1))>=N'b' 
--			AND substring([Northwind].[dbo].[Customers].[Country],(1),(1))<=N'g'))

-- Q: ����� ������ ����������������?
-- A: ���������������� 1-� ������ � BETWEEN, ��������� �� ����� �������������, ��� ���� ������������� � ���� �����, ��� � 2-� ������.
-- Q: �� ������ ��������� ���� ��������� ���������?
-- A: 

-- [������������� ��������� LIKE]

-- 4.a
-- � ������� Products ����� ��� �������� (������� ProductName), ��� ����������� ��������� 'chocolade'. ��������, ��� �
-- ��������� 'chocolade' ����� ���� �������� ���� ����� 'c' � �������� - ����� ��� ��������, ������� ������������� �����
-- �������. ���������: ���������� ������� ������ ����������� 2 ������.

SELECT
	ProductName
FROM
	Products
WHERE
	ProductName LIKE '%cho%olade'
GO



-- [������������� ���������� ������� (SUM, COUNT)]

-- 5.�
-- ����� ����� ����� ���� ������� �� ������� Order Details � ������ ���������� ����������� ������� � ������ �� ���. ���������
-- ��������� �� ����� � ��������� � ����� 1 ��� ���� ������ money. ������ (������� Discount) ���������� ������� �� ���������
-- ��� ������� ������. ��� ����������� �������������� ���� �� ��������� ������� ���� ������� ������ �� ��������� � �������
-- UnitPrice ����. ����������� ������� ������ ���� ���� ������ � ����� �������� � ��������� ������� 'Totals'.

SELECT
	CONVERT(NVARCHAR, CAST(SUM(UnitPrice * (1 - Discount) * Quantity) AS MONEY), 1) AS Totals
FROM
	[Order Details]
GO

-- 5.b
-- �� ������� Orders ����� ���������� �������, ������� ��� �� ���� ���������� (�.�. � ������� ShippedDate ��� �������� ����
-- ��������). ������������ ��� ���� ������� ������ �������� COUNT. �� ������������ ����������� WHERE � GROUP.
-- ��������� ��������� (������ ��� �������� ���������, �������� ��� �������):
	-- ����� ������������ CASE, ����� ��������������� ������������� ShippedDate � 1 ��� NULL.
	-- ����� ��������� ���������� ���� ������� � ���������� �������, � ������� �� ��������� ShippedDate.

SELECT
	COUNT(OrderID) - COUNT(ShippedDate) AS UndeliveredOrders
FROM
	Orders
GO

-- 5.c
-- �� ������� Orders ����� ���������� ��������� ����������� (CustomerID), ��������� ������. ������������ ������� COUNT �
-- �� ������������ ����������� WHERE � GROUP.

SELECT
	COUNT(DISTINCT CustomerID) AS CustomerCount
FROM
	Orders
GO



-- [����� ���������� ������, ��������������, ������������� ���������� ������� � ����������� GROUP BY � HAVING]

-- 6.a
-- �� ������� Orders ����� ���������� ������� � ������������ �� �����. � ����������� ������� ���� ����������� ��� ������� c
-- ���������� Year � Total. �������� ����������� ������, ������� ��������� ���������� ���� �������.

SELECT
	DATEPART(YEAR, OrderDate) AS [Year],
	COUNT(OrderID) AS OrderCount
FROM
	Orders
GROUP BY
	DATEPART(YEAR, OrderDate)
ORDER BY 
	[Year]
GO

SELECT
	COUNT(OrderID) AS OrderCount
FROM
	Orders
GO

-- 6.b
-- �� ������� Orders ����� ���������� �������, c�������� ������ ���������. ����� ��� ���������� �������� � ��� �����
-- ������ � ������� Orders, ��� � ������� EmployeeID ������ �������� ��� ������� ��������. � ����������� ������� ����
-- ����������� ������� � ������ �������� (������ ������������� ��� ���������� ������������� LastName & FirstName. ���
-- ������ LastName & FirstName ������ ���� �������� ��������� �������� � ������� ��������� �������. ����� �������� ������
-- ������ ������������ ����������� �� EmployeeID.) � ��������� ������� �Seller� � ������� c ����������� ������� ����������� �
-- ��������� 'Amount'. ���������� ������� ������ ���� ����������� �� �������� ���������� �������.

SELECT
   (SELECT CONCAT(LastName, ' ', FirstName) FROM Employees AS e WHERE o.EmployeeID = e.EmployeeID) AS Seller,
	COUNT(OrderID) AS Amount
FROM
	Orders AS o
GROUP BY
	EmployeeID
ORDER BY
	Amount DESC
GO

-- 6.c
-- �� ������� Orders ����� ���������� �������, c�������� ������ ��������� � ��� ������� ����������. ����������
-- ���������� ��� ������ ��� ������� ��������� � 1998 ����. � ����������� ������� ���� ����������� ������� � ������
-- �������� (�������� ������� �Seller�), ������� � ������ ���������� (�������� ������� �Customer�) � ������� c �����������
-- ������� ����������� � ��������� 'Amount'. � ������� ���������� ������������ ����������� �������� ����� T-SQL ���
-- ������ � ���������� GROUP (���� �� �������� ������� �������� ������ �ALL� � ����������� �������). ����������� ������
-- ���� ������� �� ID �������� � ����������. ���������� ������� ������ ���� ����������� �� ��������, ���������� � ��
-- �������� ���������� ������. � ����������� ������ ���� ������� ���������� �� ��������. �.�. � �������������� ������
-- ������ �������������� ������������� � ���������� � �������� �������� ��� ������� ���������� ��������� �������:
-- Seller	Customer	Amount
-- ALL		ALL			<����� ����� ������>
-- <���>	ALL			<����� ������ ��� ������� ��������>
-- ALL		<���>		<����� ������ ��� ������� ����������>
-- <���>	<���>		<����� ������ ������� �������� ��� ������� ����������>

--SET SHOWPLAN_ALL ON
--GO

SELECT
	CASE 
		WHEN GROUPING(EmployeeID) = 0 THEN (SELECT CONCAT(LastName, ' ', FirstName) FROM Employees AS e WHERE o.EmployeeID = e.EmployeeID)
		ELSE 'ALL'
	END AS Seller,
	CASE 
		WHEN GROUPING(CustomerID) = 0 THEN (SELECT ContactName FROM Customers AS c WHERE o.CustomerID = c.CustomerID)
		ELSE 'ALL'
	END AS Customer,
	COUNT(OrderID) AS Amount
FROM
	Orders AS o
WHERE
	DATEPART(YEAR, OrderDate) = 1998
GROUP BY
	CUBE (EmployeeID, CustomerID)
ORDER BY
	Seller ASC, Customer ASC, Amount DESC
GO

--SET SHOWPLAN_ALL OFF
--GO

-- 6.d
-- ����� ����������� � ���������, ������� ����� � ����� ������. ���� � ������ ����� ������ ���� ��� ��������� ��������� ���
-- ������ ���� ��� ��������� �����������, �� ���������� � ����� ���������� � ��������� �� ������ �������� �
-- �������������� �����. �� ������������ ����������� JOIN. � ����������� ������� ���������� ������� ��������� ���������
-- ��� ����������� �������: �Person�, �Type� (����� ���� �������� ������ �Customer� ��� �Seller� � ����������� �� ���� ������),
-- �City�. ������������� ���������� ������� �� ������� �City� � �� �Person�.
-- ������ ��� �������� ���������, �������� ��� �������:
--		��� ���� ������� ������ ��� �����������, ������� ����� � �������, � ������� ���� ����������.
--		����� ������� ������ ��� ����������, ������� ����� � �������, � ������� ���� ����������.
--		� ���������� ��� ���������� � �����������.

SELECT
	CONCAT(e.FirstName, ' ', e.LastName) AS Person,
	'Seller' AS [Type],
	e.City
FROM 
	Employees AS e,
	Customers AS c
WHERE
	e.City = c.City

UNION ALL

SELECT
	c.ContactName AS Person,
	'Customer' AS [Type],
	c.City
FROM 
	Employees AS e,
	Customers AS c
WHERE
	e.City = c.City
ORDER BY
	City ASC, Person ASC
GO

-- 6.e
-- ����� ���� �����������, ��� ������� ���� ������ ����������, �������� � ��� �� ������. � ������� ������������ ����������
-- ������� Customers c ����� - ��������������. ��������� ������� CustomerID � City. ������ �� ������ �����������
-- ����������� ������. ��� �������� �������� ������, ������� ����������� ������, ������� ����������� ����� ������ ���� �
-- ������� Customers. ��� �������� ��������� ������������ �������.

SELECT DISTINCT
	c1.CustomerID,
	c1.City
FROM
	Customers AS c1,
	Customers AS c2
WHERE
	c1.CustomerID != c2.CustomerID AND c1.City = c2.City
GO
	
SELECT DISTINCT
	City
FROM
	Customers
GROUP BY
	City
HAVING
	COUNT(City) > 1
GO

-- 6.f
-- �� ������� Employees ����� ��� ������� �������� ��� ������������, �.�. ���� �� ������ �������. ��������� ������� �
-- ������� 'User Name' (LastName) � 'Boss'. � �������� ������ ���� ��������� ����� �� ������� LastName.
-- �������� �� ������ "��������� �� ��� �������� � ���� �������?"
-- ��� ����� �� ������ �������������� ������� �������� ������, ������� ������� ���� ���������, ������� ��
-- ������������.
-- ����������� �������� EXCEPT
-- https://docs.microsoft.com/en-us/sql/t-sql/language-elements/set-operators-except-and-intersect-transact-sql?view=sql-server-2017

SELECT
	e1.LastName AS [User Name],
	e2.LastName AS Boss
FROM
	Employees AS e1,
	Employees AS e2
WHERE
	e2.EmployeeID = e1.ReportsTo

-- Q: ��������� �� ��� �������� � ���� �������?
-- A: �� ��������� �������� � ������� ReportsTo = null. ��������� ���� EmployeeID �� ����� ���� null. �������������� WHERE ���������� ���.

SELECT 
	LastName AS [User Name]
FROM 
	Employees
EXCEPT
SELECT
	e1.LastName AS [User Name]
FROM
	Employees AS e1,
	Employees AS e2
WHERE
	e2.EmployeeID = e1.ReportsTo
GO



-- [������������� Inner JOIN]

-- 7.a
-- ���������� ���������, ������� ����������� ������ 'Western' (������� Region). ���������� ������� ������ ����������� ���
-- ����: 'LastName' �������� � �������� ������������� ���������� ('TerritoryDescription' �� ������� Territories). ������ ������
-- ������������ JOIN � ����������� FROM. ��� ����������� ������ ����� ��������� Employees � Territories ���� ������������
-- ����������� ��������� ��� ���� Northwind.

--SET SHOWPLAN_ALL ON
--GO

SELECT
	e.LastName,
	t.TerritoryDescription
FROM
	Employees AS e
JOIN 
	EmployeeTerritories AS et ON e.EmployeeID = et.EmployeeID
JOIN 
	Territories as t ON et.TerritoryID = t.TerritoryID
JOIN 
	Region as r ON t.RegionID = r.RegionID
WHERE
	r.RegionDescription = 'Western'
GO

--SET SHOWPLAN_ALL OFF
--GO



-- [������������� Outer JOIN]

-- 8.a
-- ��������� � ����������� ������� ����� ���� ���������� �� ������� Customers � ��������� ���������� �� ������� �� �������
-- Orders. ������� �� ��������, ��� � ��������� ���������� ��� �������, �� ��� ����� ������ ���� �������� � �����������
-- �������. ����������� ���������� ������� �� ����������� ���������� �������.

SELECT
	c.ContactName AS Customer,
	COUNT(o.OrderID) AS Orders
FROM
	Customers AS c
LEFT JOIN
	Orders AS o ON c.CustomerID = o.CustomerID
GROUP BY
	c.CustomerID, c.ContactName
ORDER BY
	Orders ASC
GO



-- [������������� �����������]

-- 9.a
-- ��������� ���� ����������� ������� CompanyName � ������� Suppliers, � ������� ��� ���� �� ������ �������� �� ������
-- (UnitsInStock � ������� Products ����� 0). ������������ ��������� SELECT ��� ����� ������� � �������������� ��������� IN.
-- ����� �� ������������ ������ ��������� IN �������� '=' ?

SELECT
	CompanyName
FROM
	Suppliers
WHERE
	SupplierID IN (SELECT SupplierID FROM Products WHERE UnitsInStock = 0)
GO

-- Q: ����� �� ������������ ������ ��������� IN �������� '=' ?
-- A: � ������ ������ ���, ��������� ��������� ���������� ��������� ��������. 
--    �������� '=' ����� ������������ � ����������� �� ����� ������������ �������� ������� � SELECT.



-- [��������������� ������]

-- 10.a
-- ��������� ���� ���������, ������� ����� ����� 150 �������. ������������ ��������� ��������������� SELECT.

SELECT 
	CONCAT(e.FirstName, ' ', e.LastName) AS Seller
FROM 
	Employees AS e
WHERE 
	e.EmployeeID = (SELECT o.EmployeeID 
					FROM Orders AS o 
					WHERE o.EmployeeID = e.EmployeeID 
					GROUP BY o.EmployeeID 
					HAVING COUNT(o.OrderID) >= 150)
GO



-- [������������� EXISTS]

-- 11.a
--��������� ���� ���������� (������� Customers), ������� �� ����� �� ������ ������ (��������� �� ������� Orders).
--������������ ��������������� SELECT � �������� EXISTS.

SELECT
	ContactName
FROM
	Customers AS c
WHERE NOT EXISTS
	(SELECT * FROM Orders AS o WHERE o.CustomerID = c.CustomerID)
GO



-- [������������� ��������� �������]

-- 12.a
--��� ������������ ����������� ��������� Employees ��������� �� ������� Employees ������ ������ ��� ���� ��������, �
--������� ���������� ������� Employees (������� LastName ) �� ���� �������. ���������� ������ ������ ���� ������������
--�� �����������.

SELECT DISTINCT
	LEFT(LastName, 1) AS AlphabeticalIndex
FROM
	Employees
ORDER BY
	AlphabeticalIndex ASC
GO
