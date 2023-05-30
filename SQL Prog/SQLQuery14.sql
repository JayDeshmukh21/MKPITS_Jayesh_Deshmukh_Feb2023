--1.Reference data table
create table TableNation(NationID int Primary key, NationName varchar(500))

insert into TableNation values(1,'India'),(2,'United-Nation'),(3,'Nepal'),(4,'Sri Lanka');


create table TableState( StateID int primary key, StateName varchar(500), NationID int,
constraint s1 foreign key (NationID) references TableNation (NationID))

insert into TableState values (101,'Andhra Pradesh',1),(102,'Punjab',1),(103,'California',2),(104,'Florida',2),(105,'Koshi',3),(106,'Bagmati',3),(107,'Colombo',4),(108,'Ratnapura',4);



create table TableCity( CityID int primary key, CityName varchar(500), StateID int,
constraint s2 foreign key (StateID) references TableState (StateID))


insert into TableCity values(1001,'Vishakhapatnam',101),(1002, 'Vijaywada',101),(1003, 'Guntur',101),(1004, 'Amritsar',102),( 1005, 'Jalandhar',102),(1006, 'Chandigarh' ,102),(1007,'Los Angeles',103),(1008,'San Jose',103),(1009,'San Diego',103),(1010, 'Jacksonville',104),(1011, 'Miami',104),(1012, 'Tampa',104),(1013, 'damak',105),(1014, 'Dharan',105),(1015, 'Biratnagar',105),(1016, 'Banepa',106),(1017, 'Bharatpur',106),(1018, 'Hetauda',106),(1019, 'Grandpass',107),(1020, 'Borella',107),(1021, 'Pettah',107),(1022, 'Balangoda',108),(1023, 'Kolonna',108)


--2.Tables
create table TableCourseRegDetails(CourseRegID int primary key identity, CategoryID int, FullName varchar(500), GenderID int)

insert into TableCourseRegDetails values 
(4,1,'mk',1),
(5,2,'mk2',2),
(6,1,'ravi',1),
(7,1,'anand',1),
(8,1,'gaurav',1),
(9,1,'pranjali',2),
(10,1,'mk3',1),
(11,1,'mk4',1),
(12,1,'mk5',1),
(13,1,'mk6',1),
(14,2,'dhanvijay',1),
(15,1,'m khan',1),
(16,2,'ananya',2)





create table TableRegAddress(RegAddressID int primary key identity , CourseRegID int , NationID int, StateID int, CityID int,
constraint s3 foreign key (CourseRegID) references TableCourseRegDetails (CourseRegID),
constraint s4 foreign key (NationID) references TableNation (NationID),
constraint s5 foreign key (StateID) references TableState (StateID),
constraint s6 foreign key (CityID) references TableCity (CityID))

insert into TableRegAddress values(1,11,4,102,1003),(2,11,4,104,1009),(3,11,4,102,1003),(4,11,4,104,1012),(5,11,2,104,1009),(6,11,2,104,1009),
(7,11,2,103,1009),(8,11,2,103,1007),(9,12,1,102,1006),(10,13,1,101,1001),(11,14,4,107,1021),(12,15,2,104,1012),(13,16,1,101,1002)

create table TableFeeDetail(FeeID int primary key identity, CourseRegID int, TotalAmount decimal, 
MinPer decimal, PaidAmount decimal, BalAmount decimal, PaidDate datetime,
constraint s7 foreign key (CourseRegID) references TableCourseRegDetails (CourseRegID))

insert into TableFeeDetail values
(1,11,1000,0,500,500,2023-04-10),
(2,11,3000,0,20,2980,2023-04-10),
(3,11,1000,0,200,800,2023-04-10),
(4,11,1000,0,500,500,2023-04-10),
(5,11,1000,0,500,500,2023-04-10),
(6,11,1000,0,500,500,2023-04-10),
(7,11,1000,0,500,500,2023-04-10),
(8,11,1000,0,500,500,2023-04-10),
(9,12,1000,0,600,400,2023-04-10),
(10,13,1000,500,600,400,2023-04-10),
(11,14,3000,2400,2400,600,2023-04-10),
(12,15,1000,500,500,500,2023-04-10),
(13,16,3000,2400,2500,500,2023-04-10)
