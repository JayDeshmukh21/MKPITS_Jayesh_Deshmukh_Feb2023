create table salesman(salesman_id int,name varchar(20),city varchar(20),commission dec)
insert into salesman values(5001,'james hoong','New York',0.15)
insert into salesman values(5002,'nail knite','paris',0.13)
insert into salesman values(5005,'pit alex','London',0.11)
insert into salesman values(5006,'mc lyon','paris',0.14)
insert into salesman values(5007,'paul adam','Rome',0.13)
insert into salesman values(5003,'lauson hen','San Jose',0.12)

----------1------------
select * from salesman
----------2---------------

select name,commission from salesman

-------------3--------------



create table salesman1(order_no int,purch_amount int,ord_date varchar(20),customer_id int,salesman_id int)
insert into salesman1 values(7001,150.05,'2012-10-05',3005,5002)
insert into salesman1 values(7009,270.65,'2012-09-10',3001,5005)
insert into salesman1 values(7002,65.26,'2012-10-05',3002,5001)
insert into salesman1 values(7004,110.5,'2012-08-17',3009,5003)
insert into salesman1 values(7007,948.5,'2012-09-10',3005,5002)
insert into salesman1 values(7005,2400.6,'2012-07-27',3007,5001)
insert into salesman1 values(7008,5760,'2012-09-10',3002,5001)

select * from salesman1

select ord_date, salesman_id, order_no ,purch_amount from salesman1




---------------4--------------------------


select salesman_id from salesman1
order by salesman_id


----------------5--------------------------



create table salesman11(salesman_id int,name varchar(20),city varchar(20),comission float)
insert into salesman11 values(5001,'james hoog','new york',0.15)
insert into salesman11 values(5002,'nail knite','paris',0.15)
insert into salesman11 values(5005,'pit alex','london',0.15)
insert into salesman11 values(5006,'mc lyon','paris',0.15)
insert into salesman11 values(5007,'paul adam','rome',0.15)
insert into salesman11 values(5003,'lauson hen','san jose',0.15)

select name ,city from salesman11
where city='paris';

----------------------6-------------------------------

create table salesman12(customer_id int,cust_name varchar(20),city varchar(20),grade int,salesman_id int)
insert into salesman12 values(3002,'nick rimando','new york',100,5001)
insert into salesman12 values(3002,'brad davis','new york',200,5001)
insert into salesman12 values(3002,'graham zusi','california',200,5002)
insert into salesman12 values(3002,'julian green','london',300,5002)
insert into salesman12 values(3002,'fabian johnson','paris',300,5006)
insert into salesman12 values(3002,'geoff cameron','berlin',100,5003)
insert into salesman12 values(3002,'jozy altidor','moscow',200,5007)



select customer_id, cust_name, city, grade, salesman_id from salesman12
where grade=200;


---------------------------7------------------------------------------

create table salesman13(order_no int,purch_amt int,ord_date varchar(20),customer_id int,salesman_id int)
insert into salesman13 values(70001,150.5,'2012-05-05',3005,5002)
insert into salesman13 values(70009,270.5,'2012-10-10',3001,5005)
insert into salesman13 values(70002,65.5,'2012-05-05',3002,5001)
insert into salesman13 values(70004,110.5,'2012-17-17',3009,5003)
insert into salesman13 values(70007,948.5,'2012-10-10',3005,5002)
insert into salesman13 values(70005,2400.5,'2012-07-27',3007,5001)
insert into salesman13 values(70008,5760,'2012-09-10',3002,5001)


select order_no,ord_date, purch_amt from salesman13
where salesman_id=5001


--------------------8----------------------------------

create table salesman14(year int,subject varchar(20),winner varchar(20),country varchar(20),category varchar(20))
insert into salesman14 values(1970,'physics','hannes alfven','swedan','scientist')
insert into salesman14 values(1970,'physics','louis neel','france','scientist')
insert into salesman14 values(1972,'chemistry','luis federico leloir','france','scientist')
insert into salesman14 values(1970,'physiology','ulf von euler','swedan','scientist')
insert into salesman14 values(1973,'physiology','bernard katz','germany','scientist')
insert into salesman14 values(1970,'literature','aleksandr solzhenitsyn','russia','linguist')
insert into salesman14 values(1970,'economics','paul samuelson','usa','null')
insert into salesman14 values(1950,'physics','louis neel','france','scientist')
insert into salesman14 values(1974,'physics','louis neel','france','scientist')
insert into salesman14 values(1975,'physiology','ulf von euler','swedan','scientist')
insert into salesman14 values(1975,'physics','ulf von euler','swedan','scientist')



select year, subject, winner from salesman14
where year=1970




---------------------------------9--------------------------------------------------------------------------------------------------------------

select winner from salesman14
where subject='literature'and year=1970

------------------------10---------------------------------------------------

select year, subject from salesman14
where winner='bernard katz'

----------------------------11----------------------------------------------


select winner from salesman14
where subject='physics' and year=1950


-------------------------------12-----------------------------------------------------------------------------------------------------
select year ,subject ,winner ,country from salesman14
where year between 1965 and 1975 and
winner='chemistry'


-------------------------------------------13-----------------------------------
select year ,subject ,winner,country,category from salesman14
where subject='physics' and year>=1972
 

--------------------------------------------14-----------------------------------------------------------------------------------
select year, subject, winner, country,category from salesman14
where winner ='louis'



-----------------------------------------15---------------------------------------------------------------------------------

select year, subject, winner, country,category from salesman14
where

From the following table, write a SQL query to combine the winners in Physics, 1970 and in
Economics, 1971. Return year, subject, winner, country, and category

------------------------------------16--------------------------------------------
select year, subject, winner, country,category from salesman14
where year= 1970