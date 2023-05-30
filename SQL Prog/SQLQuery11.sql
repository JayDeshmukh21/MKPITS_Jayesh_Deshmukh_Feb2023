create table customer (customer_id int, cust_name varchar(20), city varchar(20), grade int, salesman_id int, primary key(customer_id, salesman_id))

insert into customer values(3002, 'Nick Rimando', 'New York',100,5001)
insert into customer values(3007, 'Brad Davis', 'New York',200,5001)
insert into customer values(3005, 'Graham Zusi', 'California',200,5002)
insert into customer values(3008, 'Julian Green', 'Landon',300,5002)
insert into customer values(3004, 'Fabian Johnson', 'Paris',300,5006)
insert into customer values(3009, 'Geoff Cameron', 'Berlin',100,5003)
insert into customer values(3003, 'Jozy Altidor', 'Moscow',200,5007)
insert into customer values(3001, 'Bard Guzan', 'London',000,5005)

select * from customer

create table salesman(salesman_id int, name varchar(20), city varchar(20), commission float,
constraint c1 unique(salesman_id))

insert into salesman values(5001,'James Hoog','New York',0.15)
insert into salesman values(5002,'Nail Knite','Paris',0.13)
insert into salesman values(5005,'Pit Alex','London',0.11)
insert into salesman values(5006,'Mc Lyon','Paris',0.14)
insert into salesman values(5003,'Lauson Hen','San Jose',0.12)
insert into salesman values(5007,'Paul Adam','Rome',0.13)

select *  from salesman


create table orders(ord_no int, purch_amt float, ord_date varchar(20), customer_id int, salesman_id int,
constraint c2 unique (customer_id, salesman_id))


insert into orders values (70001, 150.5 , 2012-10-05 , 3005 , 5002)
insert into orders values (70009, 270.65 , 2012-09-10 , 3001 , 5005)
insert into orders values (70002, 65.26 , 2012-10-05 , 3002 , 5001)
insert into orders values (70004, 110.5 , 2012-08-17 , 3009 , 5003)
insert into orders values (70007, 948.5, 2012-09-10 , 3005 , 5002)
insert into orders values (70005, 2400.6 , 2012-07-27 , 3007 , 5001)
insert into orders values (70008, 5760 , 2012-10-10 , 3002 , 5001)
insert into orders values (70010, 1983.43 , 2012-10-10 , 3004 , 5006)
insert into orders values (70003, 2480.4 , 2012-10-10 , 3009 , 5003)
insert into orders values (70012, 250.45 , 2012-06-27 , 3008 , 5002)
insert into orders values (70011, 75.29 , 2012-08-17 , 3003 , 5007)
insert into orders values (70013, 3045.6 , 2012-04-25 , 3002 , 5001)

select * from orders

-----------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------


create table salesman1(salesman_id int primary key, name varchar(20), city varchar(20), commission float)

insert into salesman1 values(5001,'James Hoog','New York',0.15)
insert into salesman1 values(5002,'Nail Knite','Paris',0.13)
insert into salesman1 values(5005,'Pit Alex','London',0.11)
insert into salesman1 values(5006,'Mc Lyon','Paris',0.14)
insert into salesman1 values(5003,'Lauson Hen','San Jose',0.12)
insert into salesman1 values(5007,'Paul Adam','Rome',0.13)


create table customer1 (customer_id int primary key, cust_name varchar(20), city varchar(20), grade int, salesman_id int,
constraint s1 foreign key (salesman_id) references salesman1(salesman_id))

insert into customer1 values(3002, 'Nick Rimando', 'New York',100,5001)
insert into customer1 values(3007, 'Brad Davis', 'New York',200,5001)
insert into customer1 values(3005, 'Graham Zusi', 'California',200,5002)
insert into customer1 values(3008, 'Julian Green', 'Landon',300,5002)
insert into customer1 values(3004, 'Fabian Johnson', 'Paris',300,5006)
insert into customer1 values(3009, 'Geoff Cameron', 'Berlin',100,5003)
insert into customer1 values(3003, 'Jozy Altidor', 'Moscow',200,5007)
insert into customer1 values(3001, 'Bard Guzan', 'London',000,5005)

truncate table order1

create table order2(ord_no int, purch_amt float, ord_date varchar(20), customer_id int, salesman_id int,
constraint s4 foreign key (customer_id) references customer1(customer_id),
constraint s5 foreign key (salesman_id) references salesman1(salesman_id))

insert into order2 values (70001, 150.5 , '2012-10-05' , 3005 , 5002)
insert into order2 values (70009, 270.65 , '2012-09-10' , 3001 , 5005)
insert into order2 values (70002, 65.26 , '2012-10-05' , 3002 , 5001)
insert into order2 values (70004, 110.5 , '2012-08-17' , 3009 , 5003)
insert into order2 values (70007, 948.5, '2012-09-10 ', 3005 , 5002)
insert into order2 values (70005, 2400.6 , '2012-07-27' , 3007 , 5001)
insert into order2 values (70008, 5760 , '2012-09-10' , 3002 , 5001)
insert into order2 values (70010, 1983.43 , '2012-10-10' , 3004 , 5006)
insert into order2 values (70003, 2480.4 , '2012-10-10' , 3009 , 5003)
insert into order2 values (70012, 250.45 , '2012-06-27' , 3008 , 5002)
insert into order2 values (70011, 75.29 , '2012-08-17' , 3003 , 5007)
insert into order2 values (70013, 3045.6 , 2012-04-25 , 3002 , 5001)

select * from salesman1

select * from customer1

select * from order2

-----------------------------------------------

--10>



SELECT * FROM salesman1
WHERE salesman_id IN(SELECT DISTINCT salesman_id FROM customer1 a
WHERE NOT EXISTS (SELECT * FROM customer1 b
WHERE a.salesman_id = b.salesman_id
AND a.cust_name < > b.cust_name))

SELECT ord_no, purch_amt, ord_date, salesman_id 
FROM orders 
WHERE salesman_id IN(
SELECT salesman_id 
FROM salesman
WHERE commission = (
SELECT MAX(commission) 
FROM salesman));

SELECT *
FROM order2
WHERE salesman_id =
    (SELECT DISTINCT salesman_id 
     FROM order2
     WHERE customer_id =3007);
