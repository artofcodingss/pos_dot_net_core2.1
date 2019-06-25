-- create database quickpos﻿;

create TABLE Customer(
	Id int NOT NULL PRIMARY KEY auto_increment,
	Name varchar(50),
	Address varchar(100),
	Phone varchar(50),
	Email varchar(50)
    );
    
    create TABLE Vendor(
	Id int NOT NULL PRIMARY KEY auto_increment,
	Name varchar(50),
	Address varchar(100),
	Phone varchar(50),
	Email varchar(50)
    );

create table Manufacturer(
	Id int NOT NULL PRIMARY KEY auto_increment,
	Name varchar(50),
    Address varchar(100),
	Phone varchar(50),
	Email varchar(50)
);
create table Category(
	Id int NOT NULL PRIMARY KEY auto_increment,
	Name varchar(50),
    FK_Parent_Id int,
	FOREIGN KEY (FK_Parent_Id) references Category(Id)
);

create table Rack(
	Id int NOT NULL PRIMARY KEY auto_increment,
	Name varchar(50)
);
    create TABLE Product(
	Id int NOT NULL PRIMARY KEY auto_increment,
	Name varchar(100),
    Barcode varchar(50),
	Purchase_Price float,
    Sale_Price float,
    Discount float,
	Description varchar(200),
    Quantity float,
    Type varchar(15), /* Product,Service,Deal,Recipe,Raw */
    ActiveOnSale Bit(1),
    ActiveOnPurchase Bit(1),
    SKU int,
    FK_Vendor_Id int,
    FK_Manufacturer_Id int,
    FK_Category_Id int,
    FK_Rack_Id int,
    FOREIGN KEY (FK_Vendor_Id) REFERENCES Vendor(Id),
    FOREIGN KEY (FK_Manufacturer_Id) REFERENCES Manufacturer(Id),
    FOREIGN KEY (FK_Category_Id) REFERENCES Category(Id),
    FOREIGN KEY (FK_Rack_Id) REFERENCES Rack(Id),
    LowInventoryNotification float
    );
    
    
   create TABLE DealProductOrRecipeRaw(
	Id int NOT NULL PRIMARY KEY auto_increment,
    Quantity float,
	FK_Main_Id int,
    FOREIGN KEY (FK_Main_Id) REFERENCES Product(Id),
	FK_Sub_Id int,
    FOREIGN KEY (FK_Sub_Id) REFERENCES Product(Id)
    );
    
    
create table Finance_Account(
Id int NOT NULL PRIMARY KEY auto_increment,
Name varchar(30),
Finance_Account_Type varchar(50),
FK_Parent_Id int,
FOREIGN KEY (FK_Parent_Id) references Finance_Account(Id)
);


create table Finance_Transaction(
Id int NOT NULL PRIMARY KEY auto_increment,
Group_Id int,
Name varchar(50),
Amount float,
Status varchar(50),
DateTime datetime,
ChildOf int,
User_Type varchar(50),
FK_aspnetusers_Id varchar(200),
PaymentMethod varchar(30),
ReferenceNumber varchar(50),
Bank varchar(50),
Branch varchar(100),
ChequeDate datetime,
OtherDetail varchar(200),
OherDetails2 varchar(200),
User_Id int,
FK_Finance_Account_Id int,
foreign key (FK_Finance_Account_Id) references Finance_Account(Id),
foreign key (FK_aspnetusers_Id) references aspnetusers(Id)

);



create table Image(
Id int NOT NULL PRIMARY KEY auto_increment,
Scope varchar(50),
Name varchar(50),
Related_Id int,
Path varchar(200)
);

create table Product_Batch(
Id int NOT NULL PRIMARY KEY auto_increment,
Batch varchar(50),
Description varchar(100),
Quantity float,
Expiry datetime,
FK_Product_Id int,
foreign key (FK_Product_Id) references Product(Id)
);


create table Product_Transaction(
Id int NOT NULL PRIMARY KEY auto_increment,
Price float,
Quantity float,
Total float,
Product_Batch_Id int,
FK_Product_Id int,
FK_Finance_Transaction_Id int,
foreign key (FK_Product_Id) references Product(Id),
foreign key (FK_Finance_Transaction_Id) references Finance_Transaction(Id)
);


create table Settings(
Id int NOT NULL PRIMARY KEY auto_increment,
Name varchar(100),
Scope varchar(50),
UserType varchar(50),
UserId int,
FloatValue float,
DateValue float,
Boolvalue boolean,
VarcharValue varchar(200),
VarcharValue2 varchar(200),
VarcharValue3 varchar(200)
);


create table Closing(
Id int NOT NULL PRIMARY KEY auto_increment,
DateTime datetime,
Expence float,
Income float,
ClosingBalance float,
Comment varchar(200),
Note1 int,
Note2 int,
Note3 int,
Note4 int,
Note5 int,
Note6 int,
Note7 int,
Note8 int,
Note9 int,
FK_aspnetusers_Id varchar(200),
foreign key (FK_aspnetusers_Id) references aspnetusers(Id)
);

create table Notification(
	Id int NOT NULL PRIMARY KEY auto_increment,
	CreatedDate datetime,
    Text text,
    Title nvarchar(100),
    Type varchar(50)
);



/* Asset Accounts */
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(101,'Bank','Asset',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(1011,'Meezan Bank','Asset',101);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(1012,'Faisal Bank','Asset',101);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(102,'Cash','Asset',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(103,'Petty Cash','Asset',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(104,'Undeposited Funds','Asset',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(105,'Account Receivables','Asset',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(106,'Fixed Assets','Asset',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(107,'Current Assets','Asset',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(108,'Other Assets','Asset',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(109,'Inventory','Asset',null);
/*Liabilities Accounts */
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(201,'Notes Payable','Liabilities',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(202,'Account Payable','Liabilities',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(203,'Tax Payable','Liabilities',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(204,'Salaries Payable','Liabilities',null);
/*Equity Accounts */
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(301,'Owner Equity','Equity',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(302,'Share Capital','Equity',null);
/*Income Accounts */
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(401,'Products Sale','Income',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(402,'Services Sale','Income',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(403,'Other Income','Income',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(405,'Inventory Gain','Income',null);
/*Expence Accounts */
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(501,'Operating Expences','Expence',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(502,'Salaries','Expence',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(503,'Paid Taxes','Expence',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(504,'Cost Of Goods Sold','Expence',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(509,'Discounts','Expence',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(510,'Other Expences','Expence',null);
insert into Finance_Account(Id,Name,Finance_Account_Type,FK_Parent_Id) values(511,'Inventory Loss','Expence',null);


-- demo data
insert into Category(Name) Values ('Drinks'),('Bakery'),('General Items'),('Stationary'),('Spicies'),('Dairy');
insert into Manufacturer(Name) Values ('Unilever'),('Nestle'),('Shan'),('Coke'),('Pepsi');
insert into Vendor(Name) Values ('Vendor 1'),('Vendor 2'),('Vendor 3');
insert into Customer(Name) Values ('Customer 1'),('Customer 2'),('Customer 2');

-- insert into Product(Id,Name,Sale_Price,Purchase_Price,Discount,Quantity,Type,ActiveOnSale,ActiveOnPurchase) Values
-- (1,'Surf Excel 250 g',50,40,0,0,'Product',1,1),
-- (2,'Milk Pack 500 ml',50,40,5,0,'Product',1,1),
-- (3,'Shan Biryani Masala 50 g',50,40,0,0,'Product',1,1),
-- (4,'Pepsi 500 ml',50,40,0,0,'Product',1,1),
-- (5,'Deal 1',90,80,0,0,'Deal',1,0),
-- (6,'Onion',0,10,0,0,'Raw',0,1),
-- (7,'Cheeze',0,90,0,0,'Raw',0,1),
-- (8,'Pizza Small',90,50,0,0,'Recipe',1,0);


-- insert into DealProductOrRecipeRaw(FK_Main_Id,FK_Sub_Id,Quantity) Values
-- (5,1,1),
-- (5,2,1),
-- (8,6,2),
-- (8,7,1);


-- update statment for Product table. Added Type varchar(15)  column
-- alter table Product add column Type varchar(15) ;
-- UPDATE Product SET Type = 'Product' where Id>0;

-- alter table Product add column ActiveOnSale Bit(1) ;
-- UPDATE Product SET ActiveOnSale = 1 where Id>0;


-- alter table Product add column ActiveOnPurchase Bit(1) ;
-- UPDATE Product SET ActiveOnPurchase = 1 where Id>0;

 -- alter table Product add column SKU int;

 -- alter table Product add column FK_Rack_Id int;



-- update Assets to Asset
 -- UPDATE Finance_Account SET Finance_Account_Type = 'Asset' where Id>0 and Finance_Account_Type='Assets';