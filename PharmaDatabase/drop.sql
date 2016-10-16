drop proc spGetUserByLogin;
drop proc spGetRangesFromCurrShopByCurrMedicament;
drop proc spGetAllAvailableMedicaments;
drop proc spGetCustomerByCard;
drop proc spGetAllUsersExcludeAdmin;
drop proc spGetLastIdInOrders;
drop proc spGetProductNumberById;
drop proc spGetShopAddressById;

ALTER TABLE Products
DROP CONSTRAINT FK_ShopProds;
ALTER TABLE Products
DROP CONSTRAINT FK_MedProds;
ALTER TABLE Users
DROP CONSTRAINT FK_ShopUsers;
ALTER TABLE Orders
DROP CONSTRAINT FK_CustOrders;
ALTER TABLE Orders
DROP CONSTRAINT FK_UserOrders;
ALTER TABLE Orders
DROP CONSTRAINT FK_ShopOrders;

drop table Users;
drop table Medicaments;
drop table Products;
drop table Customers;
drop table Shops;
drop table Orders;