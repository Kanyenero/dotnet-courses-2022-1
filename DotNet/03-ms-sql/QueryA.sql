USE Northwind
GO

-- [Работа с типами данных Date, NULL значениями, трехзначная логика.]

-- 1.a 
-- Выбрать в таблице Orders заказы, которые были доставлены после 6 мая 1998 года (колонка ShippedDate) включительно и
-- которые доставлены с ShipVia >= 2. Формат указания даты должен быть верным при любых региональных настройках, согласно
-- требованиям статьи “Writing International Transact-SQL Statements” в Books Online раздел “Accessing and Changing Relational Data
-- Overview”. Этот метод использовать далее для всех заданий. Запрос должен высвечивать только колонки OrderID, ShippedDate
-- и ShipVia.

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

-- Q: Пояснить почему сюда не попали заказы с NULL-ом в колонке ShippedDate.
-- A: Потому что к NULL нельзя применять операции сравнения.

-- 1.b
-- Написать запрос, который выводит только недоставленные заказы из таблицы Orders. В результатах запроса высвечивать для
-- колонки ShippedDate вместо значений NULL строку ‘Not Shipped’ – использовать системную функцию CASЕ. Запрос должен
-- высвечивать только колонки OrderID и ShippedDate.

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
-- Выбрать в таблице Orders заказы, которые были доставлены после 6 мая 1998 года (ShippedDate), не включая эту дату, или
-- которые еще не доставлены. В запросе должны высвечиваться только колонки OrderID (переименовать в Order Number) и
-- ShippedDate (переименовать в Shipped Date). В результатах запроса высвечивать для колонки ShippedDate вместо значений
-- NULL строку ‘Not Shipped’, для остальных значений высвечивать дату в формате по умолчанию.

SELECT
	OrderID AS [Order Number],
	CASE
		WHEN ShippedDate IS NULL THEN 'Not Shipped'
		ELSE CONVERT(NVARCHAR(20), ShippedDate, 0)	-- 0 - формат по умолчанию для datetime и smalldatetime
	END AS [Shipped Date]
FROM
	Orders
WHERE 
	DATEPART(YEAR, ShippedDate) >= 1998 AND DATEPART(MONTH, ShippedDate) >= 5 AND DATEPART(DAY, ShippedDate) > 6
	OR 
	ShippedDate IS NULL
GO



-- [Использование операторов IN, DISTINCT, ORDER BY, NOT]

-- 2.a
-- Выбрать из таблицы Customers всех заказчиков, проживающих в USA и Canada. Запрос сделать только с помощью оператора
-- IN. Высвечивать колонки с именем пользователя и названием страны в результатах запроса. Упорядочить результаты запроса
-- по имени заказчиков и по месту проживания.

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
-- Выбрать из таблицы Customers всех заказчиков, не проживающих в USA и Canada. Запрос сделать с помощью оператора IN.
-- Высвечивать колонки с именем пользователя и названием страны в результатах запроса. Упорядочить результаты запроса по
-- имени заказчиков.

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
-- Выбрать из таблицы Customers все страны, в которых проживают заказчики. Страна должна быть упомянута только один раз, и
-- список отсортирован по убыванию. Не использовать предложение GROUP BY. Высвечивать только одну колонку в результатах
-- запроса.

SELECT DISTINCT
	Country
FROM
	Customers
ORDER BY
	Country DESC
GO



-- [Использование оператора BETWEEN, DISTINCT]

-- 3.a
-- Выбрать все заказы (OrderID) из таблицы Order Details (заказы не должны повторяться), где встречаются продукты с
-- количеством от 3 до 10 включительно – это колонка Quantity в таблице Order Details. Использовать оператор BETWEEN. Запрос
-- должен высвечивать только колонку OrderID.

SELECT DISTINCT
	OrderID
FROM
	[Order Details]
WHERE
	Quantity BETWEEN 3 AND 10
GO

-- 3.b
-- Выбрать всех заказчиков из таблицы Customers, у которых название страны начинается на буквы из диапазона b и g.
-- Использовать оператор BETWEEN. Проверить, что в результаты запроса попадает Germany. Запрос должен высвечивать
-- только колонки CustomerID и Country и отсортирован по Country.

-- 3.c
-- Выбрать всех заказчиков из таблицы Customers, у которых название страны начинается на буквы из диапазона b и g, не
-- используя оператор BETWEEN. С помощью опции “Execution Plan” определить какой запрос предпочтительнее 3.2 или 3.3 – для
-- этого надо ввести в скрипт выполнение текстового Execution Plan-a для двух этих запросов, результаты выполнения Execution
-- Plan надо ввести в скрипт в виде комментария и по их результатам дать ответ на вопрос – по какому параметру было
-- проведено сравнение. Запрос должен высвечивать только колонки CustomerID и Country и отсортирован по Country.

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

-- 1 запрос
-- |--Sort(ORDER BY:([Northwind].[dbo].[Customers].[Country] ASC))
--        |--Clustered Index Scan(OBJECT:([Northwind].[dbo].[Customers].[PK_Customers]), 
--			WHERE:(substring([Northwind].[dbo].[Customers].[Country],(1),(1))>=N'b'
--			AND substring([Northwind].[dbo].[Customers].[Country],(1),(1))<=N'g'))

-- 2 запрос
-- |--Sort(ORDER BY:([Northwind].[dbo].[Customers].[Country] ASC))
--        |--Clustered Index Scan(OBJECT:([Northwind].[dbo].[Customers].[PK_Customers]), 
--			WHERE:(substring([Northwind].[dbo].[Customers].[Country],(1),(1))>=N'b' 
--			AND substring([Northwind].[dbo].[Customers].[Country],(1),(1))<=N'g'))

-- Q: Какой запрос предпочтительнее?
-- A: Предпочтительнее 1-й запрос с BETWEEN, поскольку он более удобочитаемый, при этом транслируется в тоже самое, что и 2-й запрос.
-- Q: По какому параметру было проведено сравнение?
-- A: 

-- [Использование оператора LIKE]

-- 4.a
-- В таблице Products найти все продукты (колонка ProductName), где встречается подстрока 'chocolade'. Известно, что в
-- подстроке 'chocolade' может быть изменена одна буква 'c' в середине - найти все продукты, которые удовлетворяют этому
-- условию. Подсказка: результаты запроса должны высвечивать 2 строки.

SELECT
	ProductName
FROM
	Products
WHERE
	ProductName LIKE '%cho%olade'
GO



-- [Использование агрегатных функций (SUM, COUNT)]

-- 5.а
-- Найти общую сумму всех заказов из таблицы Order Details с учетом количества закупленных товаров и скидок по ним. Результат
-- округлить до сотых и высветить в стиле 1 для типа данных money. Скидка (колонка Discount) составляет процент из стоимости
-- для данного товара. Для определения действительной цены на проданный продукт надо вычесть скидку из указанной в колонке
-- UnitPrice цены. Результатом запроса должна быть одна запись с одной колонкой с названием колонки 'Totals'.

SELECT
	CONVERT(NVARCHAR, CAST(SUM(UnitPrice * (1 - Discount) * Quantity) AS MONEY), 1) AS Totals
FROM
	[Order Details]
GO

-- 5.b
-- По таблице Orders найти количество заказов, которые еще не были доставлены (т.е. в колонке ShippedDate нет значения даты
-- доставки). Использовать при этом запросе только оператор COUNT. Не использовать предложения WHERE и GROUP.
-- Несколько вариантов (прежде чем смотреть подсказки, сделайте своё решение):
	-- Можно использовать CASE, чтобы «преобразовать» заполненность ShippedDate в 1 или NULL.
	-- Можно посчитать количество всех заказов и количество заказов, у которых не заполнено ShippedDate.

SELECT
	COUNT(OrderID) - COUNT(ShippedDate) AS UndeliveredOrders
FROM
	Orders
GO

-- 5.c
-- По таблице Orders найти количество различных покупателей (CustomerID), сделавших заказы. Использовать функцию COUNT и
-- не использовать предложения WHERE и GROUP.

SELECT
	COUNT(DISTINCT CustomerID) AS CustomerCount
FROM
	Orders
GO



-- [Явное соединение таблиц, самосоединения, использование агрегатных функций и предложений GROUP BY и HAVING]

-- 6.a
-- По таблице Orders найти количество заказов с группировкой по годам. В результатах запроса надо высвечивать две колонки c
-- названиями Year и Total. Написать проверочный запрос, который вычисляет количество всех заказов.

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
-- По таблице Orders найти количество заказов, cделанных каждым продавцом. Заказ для указанного продавца – это любая
-- запись в таблице Orders, где в колонке EmployeeID задано значение для данного продавца. В результатах запроса надо
-- высвечивать колонку с именем продавца (Должно высвечиваться имя полученное конкатенацией LastName & FirstName. Эта
-- строка LastName & FirstName должна быть получена отдельным запросом в колонке основного запроса. Также основной запрос
-- должен использовать группировку по EmployeeID.) с названием колонки ‘Seller’ и колонку c количеством заказов высвечивать с
-- названием 'Amount'. Результаты запроса должны быть упорядочены по убыванию количества заказов.

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
-- По таблице Orders найти количество заказов, cделанных каждым продавцом и для каждого покупателя. Необходимо
-- определить это только для заказов сделанных в 1998 году. В результатах запроса надо высвечивать колонку с именем
-- продавца (название колонки ‘Seller’), колонку с именем покупателя (название колонки ‘Customer’) и колонку c количеством
-- заказов высвечивать с названием 'Amount'. В запросе необходимо использовать специальный оператор языка T-SQL для
-- работы с выражением GROUP (Этот же оператор поможет выводить строку “ALL” в результатах запроса). Группировки должны
-- быть сделаны по ID продавца и покупателя. Результаты запроса должны быть упорядочены по продавцу, покупателю и по
-- убыванию количества продаж. В результатах должна быть сводная информация по продажам. Т.е. в результирующем наборе
-- должны присутствовать дополнительно к информации о продажах продавца для каждого покупателя следующие строчки:
-- Seller	Customer	Amount
-- ALL		ALL			<общее число продаж>
-- <имя>	ALL			<число продаж для данного продавца>
-- ALL		<имя>		<число продаж для данного покупателя>
-- <имя>	<имя>		<число продаж данного продавца для данного покупателя>

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
-- Найти покупателей и продавцов, которые живут в одном городе. Если в городе живут только один или несколько продавцов или
-- только один или несколько покупателей, то информация о таких покупателя и продавцах не должна попадать в
-- результирующий набор. Не использовать конструкцию JOIN. В результатах запроса необходимо вывести следующие заголовки
-- для результатов запроса: ‘Person’, ‘Type’ (здесь надо выводить строку ‘Customer’ или ‘Seller’ в зависимости от типа записи),
-- ‘City’. Отсортировать результаты запроса по колонке ‘City’ и по ‘Person’.
-- Прежде чем смотреть подсказки, сделайте своё решение:
--		Тут надо выбрать только тех покупателей, которые живут в городах, в которых есть «продавцы».
--		Потом выбрать только тех «продавцов», которые живут в городах, в которых есть покупатели.
--		И объединить два результата с сортировкой.

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
-- Найти всех покупателей, для которых есть другие покупатели, живующие в том же городе. В запросе использовать соединение
-- таблицы Customers c собой - самосоединение. Высветить колонки CustomerID и City. Запрос не должен высвечивать
-- дублируемые записи. Для проверки написать запрос, который высвечивает города, которые встречаются более одного раза в
-- таблице Customers. Это позволит проверить правильность запроса.

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
-- По таблице Employees найти для каждого продавца его руководителя, т.е. кому он делает репорты. Высветить колонки с
-- именами 'User Name' (LastName) и 'Boss'. В колонках должны быть высвечены имена из колонки LastName.
-- Ответьте на вопрос "Высвечены ли все продавцы в этом запросе?"
-- Для этого на основе вышеуказанного запроса сделайте запрос, который выводит всех продавцов, которые не
-- отчитываются.
-- Используйте оператор EXCEPT
-- https://docs.microsoft.com/en-us/sql/t-sql/language-elements/set-operators-except-and-intersect-transact-sql?view=sql-server-2017

SELECT
	e1.LastName AS [User Name],
	e2.LastName AS Boss
FROM
	Employees AS e1,
	Employees AS e2
WHERE
	e2.EmployeeID = e1.ReportsTo

-- Q: Высвечены ли все продавцы в этом запросе?
-- A: Не высвечены продавцы у которых ReportsTo = null. Первичный ключ EmployeeID не может быть null. Соответственно WHERE игнорирует это.

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



-- [Использование Inner JOIN]

-- 7.a
-- Определить продавцов, которые обслуживают регион 'Western' (таблица Region). Результаты запроса должны высвечивать два
-- поля: 'LastName' продавца и название обслуживаемой территории ('TerritoryDescription' из таблицы Territories). Запрос должен
-- использовать JOIN в предложении FROM. Для определения связей между таблицами Employees и Territories надо использовать
-- графические диаграммы для базы Northwind.

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



-- [Использование Outer JOIN]

-- 8.a
-- Высветить в результатах запроса имена всех заказчиков из таблицы Customers и суммарное количество их заказов из таблицы
-- Orders. Принять во внимание, что у некоторых заказчиков нет заказов, но они также должны быть выведены в результатах
-- запроса. Упорядочить результаты запроса по возрастанию количества заказов.

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



-- [Использование подзапросов]

-- 9.a
-- Высветить всех поставщиков колонка CompanyName в таблице Suppliers, у которых нет хотя бы одного продукта на складе
-- (UnitsInStock в таблице Products равно 0). Использовать вложенный SELECT для этого запроса с использованием оператора IN.
-- Можно ли использовать вместо оператора IN оператор '=' ?

SELECT
	CompanyName
FROM
	Suppliers
WHERE
	SupplierID IN (SELECT SupplierID FROM Products WHERE UnitsInStock = 0)
GO

-- Q: Можно ли использовать вместо оператора IN оператор '=' ?
-- A: В данном случае нет, поскольку подзапрос возвращает несколько значений. 
--    Оператор '=' можно использовать с подзапросом во время присваивания значения столбца в SELECT.



-- [Коррелированный запрос]

-- 10.a
-- Высветить всех продавцов, которые имеют более 150 заказов. Использовать вложенный коррелированный SELECT.

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



-- [Использование EXISTS]

-- 11.a
--Высветить всех заказчиков (таблица Customers), которые не имеют ни одного заказа (подзапрос по таблице Orders).
--Использовать коррелированный SELECT и оператор EXISTS.

SELECT
	ContactName
FROM
	Customers AS c
WHERE NOT EXISTS
	(SELECT * FROM Orders AS o WHERE o.CustomerID = c.CustomerID)
GO



-- [Использование строковых функций]

-- 12.a
--Для формирования алфавитного указателя Employees высветить из таблицы Employees список только тех букв алфавита, с
--которых начинаются фамилии Employees (колонка LastName ) из этой таблицы. Алфавитный список должен быть отсортирован
--по возрастанию.

SELECT DISTINCT
	LEFT(LastName, 1) AS AlphabeticalIndex
FROM
	Employees
ORDER BY
	AlphabeticalIndex ASC
GO
