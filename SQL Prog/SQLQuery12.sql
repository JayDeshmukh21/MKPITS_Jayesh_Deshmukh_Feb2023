create table 
departments(
dept_id int, 
dept_name varchar(20), 
manager_id int, 
location_id int)

insert into departments values(10,'administration',200,1700)
insert into departments values(20,'marketing',201,1800)
insert into departments values(30,'purchasing',114,1700)
insert into departments values(40,'human resources',203,2400)
insert into departments values(50,'shipping',121,150)
insert into departments values(60,'IT',103,1400)
insert into departments values(70,'public relation',204,2700)
insert into departments values(80,'sales',145,2500)
insert into departments values(90,'executive',100,1700)
insert into departments values(100,'finance',108,1700)
insert into departments values(110,'accounting',205,1700)
insert into departments values(120,'Treasury',0,1700)
insert into departments values(130,'corporate tax',0,1700)
insert into departments values(140,'control and crtedit',0,1700)
insert into departments values(150,'shareholder services',0,1700)
insert into departments values(160,'benefits',0,1700)
insert into departments values(170,'manufacturing',0,1700)
insert into departments values(180,'construction',0,1700)
insert into departments values(190,'contracting',0,1700)
insert into departments values(200,'operations',0,1700)
insert into departments values(210,'IT Support',0,1700)
insert into departments values(220,'NOC',0,1700)
insert into departments values(230,'IT Helpdesk',0,1700)
insert into departments values(240,'Goverment sales',0,1700)
insert into departments values(250,'retail sales',0,1700)
insert into departments values(260,'payroll',0,1700)

select * from departments

create table
employees(
emp_id int,
first_name varchar(20),
last_name varchar(20),
email varchar(20),
phone_no int,
hire_date varchar(20),
job_id int,
salary float,
commission_ptc float,
manager_id int,
dept_id int)

insert into employees values (100,'steven','king', 'sking',5151234567,'2023-06-17','ad_pres',24000.00,0,0,90)
insert into employees values (100,'steven','king', 'sking',5151234567,'2023-06-17','ad_pres',24000.00,0,0,90)
insert into employees values (102

INSERT INTO employees (LOCATION_ID, STREET_ADDRESS, POSTAL_CODE, CITY, STATE_PROVINCE, COUNTRY_ID)
VALUES
(1000, '1297 Via Cola di Rie', '989', 'Roma', '', 'IT'),
(1100, '93091 Calle della Testa', '10934', 'Venice', '', 'IT'),
(1200, '2017 Shinjuku-ku', '1689', 'Tokyo', 'Tokyo Prefecture', 'JP'),
(1300, '9450 Kamiya-cho', '6823', 'Hiroshima', '', 'JP'),
(1400, '2014 Jabberwocky Rd', '26192', 'Southlake', 'Texas', 'US'),
(1500, '2011 Interiors Blvd', '99236', 'South San Francisco', 'California', 'US'),
(1600, '2007 Zagora St', '50090', 'South Brunswick', 'New Jersey', 'US'),
(1700, '2004 Charade Rd', '98199', 'Seattle', 'Washington', 'US'),
(1800, '147 Spadina Ave', 'M5V 2L7', 'Toronto', 'Ontario', 'CA'),
(1900, '6092 Boxwood St', 'YSW 9T2', 'Whitehorse', 'Yukon', 'CA'),
(2000, '40-5-12 Laogianggen', '190518', 'Beijing', '', 'CN'),
(2100, '1298 Vileparle (E)', '490231', 'Bombay', 'Maharashtra', 'IN'),
(2200, '12-98 Victoria Street', '2901', 'Sydney', 'New South Wales', 'AU'),
(2300, '198 Clementi North', '540198', 'Singapore', '', 'SG'),
(2400, '8204 Arthur St', '', 'London', '', 'UK'),
(2500, 'Magdalen Centre, The Oxford Science Park', 'OX9 9ZB', 'Oxford', 'Oxford', 'UK'),
(2600, '9702 Chester Road', '9629850293', 'Stretford', 'Manchester', 'UK'),
(2700, 'Schwanthalerstr. 7031', '80925', 'Munich', 'Bavaria', 'DE'),
(2800, 'Rua Frei Caneca 1360', '01307-002', 'Sao Paulo', 'Sao Paulo', 'BR'),
(2900, '20 Rue des Corps-Saints', '1730', 'Geneva', 'Geneve', 'CH'),
(3000, 'Murtenstrasse 921', '3095', 'Bern', 'BE', 'CH'),
(3100, 'Pieter Breughelstraat 837', '3029SK', 'Utrecht', 'Utrecht', 'NL'),
(3200, 'Mariano Escobedo 9991', '11932', 'Mexico City', 'Distrito Federal', 'MX');






