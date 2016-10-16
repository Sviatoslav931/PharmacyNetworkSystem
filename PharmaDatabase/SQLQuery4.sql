SELECT Medicaments.medicamentName, COUNT(Products.productID)
FROM Medicaments
LEFT JOIN Products
ON Products.medicamentID = Medicaments.medicamentID
GROUP BY Medicaments.medicamentName
;


