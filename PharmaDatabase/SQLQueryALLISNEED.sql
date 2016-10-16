SELECT Medicaments.medicamentName, COUNT(Products.productID)
FROM Medicaments
INNER JOIN Products
ON Products.medicamentID = Medicaments.medicamentID
GROUP BY Medicaments.medicamentName
;

Select * from Products
INNER JOIN Medicaments
ON Products.medicamentID = Medicaments.medicamentID
INNER JOIN Shops
ON Products.shopID = Shops.shopID
WHERE Products.shopID <> 202
ORDER BY Medicaments.medicamentName
;



Select Products.productID AS prodid, Medicaments.medicamentID AS medid, Shops.shopID AS shopid,
Medicaments.medicamentName AS Name, Medicaments.medicamentDose AS Dose,
Products.productPrice AS price, Products.productNumber AS Number
FROM Products
INNER JOIN Medicaments
ON Products.medicamentID = Medicaments.medicamentID
INNER JOIN Shops
ON Products.shopID = Shops.shopID
WHERE Products.productDelete = 0 AND Shops.shopDelete = 0 AND Medicaments.medicamentDelete = 0 AND
Products.shopID = 201
AND Medicaments.medicamentName LIKE '%nat%'
UNION
Select DISTINCT 0 AS prodid,  Medicaments.medicamentID AS medid, 0 AS shopid,
Medicaments.medicamentName AS Name, Medicaments.medicamentDose AS Dose,
0 AS price, 0 AS Number
FROM Products
INNER JOIN Medicaments
ON Products.medicamentID = Medicaments.medicamentID
INNER JOIN Shops
ON Products.shopID = Shops.shopID
WHERE Products.productDelete = 0 AND Shops.shopDelete = 0 AND Medicaments.medicamentDelete = 0 AND
Products.shopID <> 201
AND Medicaments.medicamentName LIKE '%nat%'
ORDER BY Medicaments.medicamentName, shopid DESC
;
