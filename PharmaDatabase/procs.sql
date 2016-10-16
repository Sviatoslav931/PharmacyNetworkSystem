GO

CREATE PROC spGetUserByLogin
	@Login VARCHAR(50),
	@Password VARCHAR(50)
AS

BEGIN

	SELECT 
		Id, 
		FirstName, 
		Surname, 
		[Login], 
		[Role],
		shopId,
		[Disabled] 
	FROM Users
	WHERE [Login] = @Login AND [Password] = @Password AND [Disabled] <> 1;

END;

GO

CREATE PROC spGetRangesFromCurrShopByCurrMedicament
	@MedicamentId INT,
	@ShopId INT
AS

BEGIN

	SELECT 
		Shops.shopAddress, 
		Products.productPrice, 
		Products.productNumber, 
		ROUND(SQRT (POWER (Shops.coordinateX - (SELECT TOP 1 coordinateX FROM Shops WHERE shopID = @ShopId), 2) + POWER (Shops.coordinateY - (SELECT TOP 1 coordinateY FROM Shops WHERE shopID = @ShopId), 2) ),2) AS "Range"
	FROM Shops
		INNER JOIN Products
		ON Shops.shopID = Products.shopID
		INNER JOIN Medicaments
		ON Products.medicamentID = Medicaments.medicamentID
	WHERE 
		Products.medicamentID = @MedicamentId
		AND Shops.shopDelete = 0
		AND Products.productDelete = 0
		AND Medicaments.medicamentDelete = 0
	ORDER BY SQRT (POWER (Shops.coordinateX - (SELECT TOP 1 coordinateX FROM Shops WHERE shopID = @ShopId), 2) + POWER (Shops.coordinateY - (SELECT TOP 1 coordinateY FROM Shops WHERE shopID = @ShopId), 2) );

END;

GO

CREATE PROC spGetAllAvailableMedicaments
	@ShopId INT,
	@MedicamentName VARCHAR (50)
AS

BEGIN

	SELECT 
		prodid, 
		medid, 
		Name, 
		Dose, 
		price, 
		Number
	FROM (
		SELECT 
			*, 
			ROW_NUMBER() OVER(PARTITION BY medid ORDER BY medid DESC) AS rownumber
		FROM 
		(
			Select 
				Products.productID AS prodid, 
				Medicaments.medicamentID AS medid, 
				Shops.shopID AS shopid,
				Medicaments.medicamentName AS Name, 
				Medicaments.medicamentDose AS Dose,
				Products.productPrice AS price, 
				Products.productNumber AS Number
			FROM Products
				INNER JOIN Medicaments
				ON Products.medicamentID = Medicaments.medicamentID
				INNER JOIN Shops
				ON Products.shopID = Shops.shopID
			WHERE 
				Products.productDelete = 0 
				AND Shops.shopDelete = 0 
				AND Medicaments.medicamentDelete = 0 
				AND Products.shopID = @ShopId
				AND Medicaments.medicamentName LIKE @MedicamentName
		UNION
			Select 
				DISTINCT 0 AS prodid,  
				Medicaments.medicamentID AS medid, 
				0 AS shopid,
				Medicaments.medicamentName AS Name, 
				Medicaments.medicamentDose AS Dose,
				0 AS price, 
				0 AS Number
			FROM Products
				INNER JOIN Medicaments
				ON Products.medicamentID = Medicaments.medicamentID
				INNER JOIN Shops
				ON Products.shopID = Shops.shopID
			WHERE 
				Products.productDelete = 0
				AND Shops.shopDelete = 0 
				AND Medicaments.medicamentDelete = 0 
				AND Products.shopID <> @ShopId
				AND Medicaments.medicamentName LIKE @MedicamentName
		) AS AllAvailableMedicamentsWithDublicateInCurrentShop
	) AS AllAvailableMedicamentsWithNoDublicateByFirstRowNumber
	WHERE rownumber = 1
	ORDER BY medid, shopid DESC

END;

GO

CREATE PROC spGetCustomerByCard
	@customerCard INT
AS

BEGIN

	SELECT * FROM Customers
	WHERE Customers.customerCard = @customerCard AND Customers.customerDelete = 0

END;

GO

CREATE PROC spGetLastIdInOrders
AS

BEGIN

	SELECT 
		TOP 1 orderId 
	FROM 
		Orders 
	ORDER BY orderId DESC

END;

GO

CREATE PROC spGetShopAddressById
	@shopID INT
AS

BEGIN

	SELECT shopAddress FROM Shops WHERE shopID = @shopID

END;

GO

CREATE PROC spGetProductNumberById
	@productID INT
AS

BEGIN

	SELECT productNumber FROM Products WHERE productID = @productID

END;

GO

CREATE PROC spGetAllUsersExcludeAdmin
AS

BEGIN

	SELECT id, FirstName, Surname, [Disabled] 
	FROM Users 
	WHERE [Role]='worker' AND [Disabled] = 0
	ORDER BY Surname

END;

GO

