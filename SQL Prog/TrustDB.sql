CREATE TABLE Item_master (Item_Id int IDENTITY(1,1) primary key, Item_Name varchar(500), Category varchar(500), Rate int, Balance_quantity int)

Select * From Item_master

CREATE TABLE Department_mast (Department_Id int IDENTITY(1,1) primary key, Department_Name varchar(500))
select * from  Department_mast

CREATE TABLE Vendor_mast (Vendor_Id int IDENTITY(1,1) primary key, Vendor_Name varchar(500))
Select * From Vendor_mast


CREATE TABLE Transactions (Transaction_Id int IDENTITY(1,1) primary key,
Item_Id int,Transaction_Date DateTime, Department_Id int,Vendor_Id int, Quantity int,
CONSTRAINT C1 FOREIGN KEY (Item_Id) REFERENCES Item_master(Item_Id),
CONSTRAINT C2 FOREIGN KEY (Department_Id) REFERENCES Department_mast(Department_Id),
CONSTRAINT C3 FOREIGN KEY (Vendor_Id) REFERENCES Vendor_mast(Vendor_Id))