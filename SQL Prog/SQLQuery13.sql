
--Table 1 Product GST Detail

create table TableProductGSTDetails(Product_Gst_ID int primary key, 
Gst_Detail_Name varchar(500), CGST Decimal,SGST Decimal, IGST Decimal)

insert into TableProductGSTDetails values(601,'AC and Fridge',14,14,14),(602,'Computers',9,9,9),(603,'Printers',9,9,9),(604,'Mobiles',6,6,6)



--Table 2 Product Category 

create table TableProductCategory(Product_Category_ID int primary key, 
Product_Type_Name varchar(500), Product_Gst_ID int,
constraint c1 foreign key (Product_Gst_ID) 
references TableProductGSTDetails(Product_Gst_ID))

insert into TableProductCategory values(1001,'Computers',602),(1002,'Mobile',604),(1003,'Printers',603),(1004,'AC and Fridge',601)
select * from TableProductCategory


--Table 3 Product 

create table TableProduct(Product_ID int primary key, 
Product_Type_ID int, Product_Name varchar(500),Product_Price decimal,
constraint c2 foreign key (Product_Type_ID) references TableProductCategory(Product_Category_ID))

insert into TableProduct values(210,1002,'Apple',40000),(211,1002,'Lenovo',25000),(212,1003,'Samsung',50000),(213,1004,'IFB',20000),(214,1004,'LG',30000),(215,1001,'Sony',60000)



--Table 4 Invoice Detail 

create table TableInvoiceDetails(Invoice_Detail_ID int primary key, 
Customer_Name varchar(500), customer_Contact varchar(500), 
Product_Category_ID int, Product_ID int, 
Residential_Type_ID int, Invoice_Date DateTime, 
Quantity Decimal,Product_Price Decimal,CGST Decimal,
SGST Decimal,IGST Decimal,CGST_Value Decimal,
SGST_Value Decimal,IGST_Value Decimal,Total_Amount Decimal,
constraint c3 foreign key (Product_Category_ID) references TableProductCategory(Product_Category_ID),
constraint c4 foreign key (Product_ID) references TableProduct(Product_ID))


insert into TableInvoiceDetails values(1,'Rahul',9852132210,1002,210,3001,2023-04-04,1,50000,6,6,12,3000,3000,6000,56000),
(2,'Nikita',7861232210,1001,211,3002,2023-04-08,1,65000,9,9,18,11700,5850,5850,76700),
(12,'Bharti',1234567890,1001,215,3003,2023-04-12,1,60000,9,9,18,5400,5400,10800,70800),
(13,'Trupti',1234567890,1002,210,3004,2023-04-12,1,40000,6,6,6,2400,2400,2400,42400)