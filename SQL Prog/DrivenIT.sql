 create table ItemMaster(ItemID int primary key identity not null,ItemDescr  nvarchar(100)null,BalQty int null,CreatedOn DateTime)
 insert into ItemMaster values ('fridge',20,'12/12/2023')
 insert into ItemMaster values ('Mona',18,15/11/2023)
 insert into ItemMaster values ('Sanjivani',7,14/11/2023)
 insert into ItemMaster values ('Shiva',8,10/11/2023)
 insert into ItemMaster values ('Raghav',9,12/11/2023)


 

  

 create table transactions1 (TransID int primary key identity not null,ItemID int not null, constraint c2 foreign key (ItemID) references ItemMaster(ItemID),
 TransType char(1) not null,TransQty int,TransDate datetime)


select * from ItemMaster
select * from transactions