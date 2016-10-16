CREATE DATABASE PharmaDB
GO
USE PharmaDB

create table Shops (
	[shopID]      INT            NOT NULL,
    [shopAddress] NVARCHAR (50)   NOT NULL,
    [coordinateX] DECIMAL (6, 4) NOT NULL,
    [coordinateY] DECIMAL (6, 4) NOT NULL,
    [shopDelete]  BIT            NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_Shops_Id] PRIMARY KEY ([shopID]),
	CONSTRAINT [UQ_Shops_Login] UNIQUE ([shopAddress])
);

create table Users (
	Id int not null,
	FirstName nvarchar(50) not null,
	Surname nvarchar(50) not null,
	[Login] varchar(50) not null,
	[Password] varchar(50) not null,
	[Role] varchar(50) not null,
	[shopId]    INT           NULL DEFAULT NULL,
	[Disabled] BIT NOT NULL DEFAULT 0,
	constraint PK_Users_Id primary key (Id),
	constraint UQ_Users_Login unique ([Login]),
	CONSTRAINT [FK_ShopUsers] FOREIGN KEY ([shopId]) REFERENCES Shops(shopID)
);

create table Customers (
	[customerID] INT NOT NULL, 
    [customerCard] INT NOT NULL, 
    [customerTotalSumm] DECIMAL(10, 2) NOT NULL DEFAULT 0, 
    [customerDiscount] INT NOT NULL DEFAULT 0, 
    [customerDelete] BIT NOT NULL DEFAULT 0,
	CONSTRAINT PK_Customers_Id PRIMARY KEY (customerID),
	CONSTRAINT [UQ_Customers_Card] UNIQUE ([customerCard])
);

create table Medicaments (
	[medicamentID]     INT          NOT NULL,
    [medicamentName]   VARCHAR (50) NOT NULL,
    [medicamentDose]   VARCHAR (50) NULL DEFAULT NULL,
    [medicamentDelete] BIT          NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_Medicaments] PRIMARY KEY ([medicamentID])
);

create table Products (
	[productID]     INT             NOT NULL,
    [medicamentID]  INT             NOT NULL,
    [shopID]        INT             NOT NULL,
    [productNumber] INT             NOT NULL DEFAULT 0,
    [productPrice]  DECIMAL (10, 2) NOT NULL DEFAULT 0,
    [productDelete] BIT             NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_Products] PRIMARY KEY ([productID]),
	CONSTRAINT [FK_ShopProds] FOREIGN KEY ([shopID]) REFERENCES Shops(shopID),
	CONSTRAINT [FK_MedProds] FOREIGN KEY ([medicamentID]) REFERENCES Medicaments(medicamentID)
);

CREATE TABLE Orders
(
	orderId INT NOT NULL, 
	orderDate DATETIME NOT NULL, 
    customerId INT NULL DEFAULT NULL, 
    userId INT NOT NULL, 
    shopId INT NOT NULL, 
    orderSumm DECIMAL(10, 2) NOT NULL, 
    orderDiscount INT NULL DEFAULT NULL, 
    orderDelete BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_Orders_Id] PRIMARY KEY ([orderId]),
	CONSTRAINT [FK_CustOrders] FOREIGN KEY ([customerId]) REFERENCES Customers(customerID),
	CONSTRAINT [FK_UserOrders] FOREIGN KEY ([userId]) REFERENCES Users(id),
	CONSTRAINT [FK_ShopOrders] FOREIGN KEY ([shopId]) REFERENCES Shops(shopID),
)