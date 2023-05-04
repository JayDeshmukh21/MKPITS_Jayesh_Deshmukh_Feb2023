create table customer_Entity(customer_id int,customer_name varchar(60),contact_no double,customer_username varchar(60),customer_password varchar(60),customer_city varchar(60))
insert into customer_Entity values(1,'Jayesh Deshmukh',124579854,'Jaydesh','jay123','Amravati')

select * from customer_entity

delete from customer_entity

insert into customer_Entity values(1,'Jayesh deshmukh',124579854,'Jaydesh','jay123','Pune')
insert into customer_Entity values(2,'Riyan kadu',124794245,'riyank','riya123','Amravati')
insert into customer_Entity values(3,'Jayesh varhade',986245678,'jayvv','jay113','Mumbai')
insert into customer_Entity values(4,'Prasanna deshmukh',798467953,'prasv','prasa123','Nagpur')
insert into customer_Entity values(5,'Samkash chandure',97346472,'samkc','sam123','Mumbai')
insert into customer_Entity values(6,'Prasanna varhade',458565452,'prvar','pvar123','Pune')
insert into customer_Entity values(7,'Prathmesh kubde',569978515,'prathk','pratyh123','Amravati')
insert into customer_Entity values(8,'Prasham thokal',794516497,'prasht','prash123','Amravati')
insert into customer_Entity values(9,'Kshitija varhade',792164975,'kshitivar','kashiti123','Pune')
insert into customer_Entity values(10,'Vedanti raut',451249884,'vedrt','ved123','Nagpur')

select * from customer_Entity

SELECT
customer_name
FROM
customer_Entity
ORDER BY
LEN(customer_name)

SELECT TOP 5
customer_name,
customer_city
FROM
customer_Entity
ORDER BY
customer_city DESC

SELECT TOP 5
customer_name,
customer_city
FROM
customer_Entity
ORDER BY
customer_city

SELECT TOP 50 PERCENT
customer_name,
customer_city
FROM
customer_Entity
ORDER BY
customer_city DESC

SELECT DISTINCT
customer_city
FROM
customer_Entity;

SELECT
customer_name
FROM
customer_Entity
WHERE
customer_id BETWEEN 1 AND 8

SELECT TOP 5
customer_name,
customer_city
FROM
customer_Entity
ORDER BY
customer_city DESC

select * from customer_Entity where customer_id in (1,3,5)

select * from customer_Entity where customer_name like '%ra%'

select * from customer_Entity where customer_name like '%a%'


create table booking_Entity(booking_id int, booking_type varchar(30), booking_ticket int, booking_date int) 

insert into booking_Entity values(01,'sleeper',)



