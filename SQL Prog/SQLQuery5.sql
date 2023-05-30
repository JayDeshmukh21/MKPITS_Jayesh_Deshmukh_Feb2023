create table store(store_id int primary key,store_name varchar(20),phone int,email varchar(20),city varchar(20),
state varchar(20),zip_code int)
insert into store values (1,'mkpit',12345,'m@gmail.com','nagpur','mh',440001)
insert into store values (2,'haldiram',67890,'hald@gmail.com','mumbai','mh',440021)
insert into store values (3,'dmart',42155,'dmart@gmail.com','amravati','mh',440601)
insert into store values (4,'shreeji',45678,'shree@gmail.com','mumbai','mh',440021)
insert into store values (5,'mahalakshmi',67890,'mhl@gmail.com','pune','mh',440085)


create table categories(category_id int primary key, category_name varchar(20))
insert into categories values (1,'electronics')
insert into categories values (2,'Food')
insert into categories values (3,'grocery')
insert into categories values (4,'sweet')
insert into categories values (5,'cosmetics')




create table brands(brand_id int primary key, brand_name varchar(20))
insert into brands values (1,'hitachi')
insert into brands values (2,'haldiram')
insert into brands values (3,'jp')
insert into brands values (4,'shree sweets')
insert into brands values (5,'sugar')
insert into brands values (5,'lakme')
insert into brands values (5,'garnier')




create table products(product_id int primary key, product_name varchar(20),brand_id int, 
model_year int, list_price int,category_id int,
constraint s1 foreign key(brand_id) references brands(brand_id), 
constraint s2 foreign key(category_id) references categories(category_id))

insert into products values (1,'AC',1,2023,25000,1)
insert into products values (2,'Rasmalai',2,2023,400,2)
insert into products values (3,'grains biscuit etc',3,2023,500,3)
insert into products values (4,'gulabjamun',4,2023,350,4)
insert into products values (5,'Foundation',5,2023,800,5)




create table stocks(store_id int, quantity int,product_id int,
constraint s3 foreign key(store_id) references store(store_id),  
constraint s4 foreign key (product_id) references products(product_id))

insert into stocks values (1,99,1)
insert into stocks values (2,145,2)
insert into stocks values (3,200,3)
insert into stocks values (4,245,4)
insert into stocks values (5,190,5)



create table customers(customer_id int primary key, first_name varchar(20), last_name varchar(20), phone int,
email varchar(20), street varchar(20),
city varchar(20), state varchar(20), zip_code int)

insert into customers values (01,'Narendra','Modi',123,'Nmo@gmail.com','Sector 18','Delhi', 'chandigad', 000011)
insert into customers values (02,'Tanmay','patil',146,'tan@gmail.com','manevada','nagpur', 'maharashtra', 440011)
insert into customers values (03,'sahil','kalwe',457,'sk@gmail.com','lad square','nagpur', 'maharashtra', 661011)
insert into customers values (04,'yasmin','sheikh',875,'ys@gmail.com','csm square','nagpur', 'maharashtra', 450011)
insert into customers values (05,'tanushree','meshram',945,'tm@gmail.com','IT park','nagpur', 'maharashtra', 710011)




create table staffs(staff_id int primary key, first_name varchar(20), last_name varchar(20), email varchar(20), 
phone int, active varchar(20), 
store_id int, manager_id int,
constraint s5 foreign key(store_id) references store(store_id))

insert into staffs values(001,'Amit','shah','amitshah@gmail.com',125,'current',1,01)
insert into staffs values(002,'ram','shinde','ram@gmail.com',1234,'current',2,02)
insert into staffs values(003,'rajesh','patil','raj@gmail.com',5678,'current',3,03)
insert into staffs values(004,'ashish','shinde','ash@gmail.com',9101,'current',4,04)
insert into staffs values(005,'sarikha','patil','sp@gmail.com',1121,'current',5,05)




create table orders(order_id int primary key, customer_id int, order_status varchar(20), order_date varchar(20), 
required_date varchar(20), shipped_id int, store_id int, staff_id int,
constraint s6 foreign key (customer_id) references customers(customer_id),
constraint s7 foreign key (store_id) references store(store_id),
constraint s8 foreign key (staff_id) references staffs(staff_id))

insert into orders values(001,01,'delivered','2023-5-18','2023-5-21',23,1,001)
insert into orders values(002,02,'dispatch','2023-5-15','2023-5-20',17,2,002)
insert into orders values(003,03,'delivered','2023-5-12','2023-5-14',51,3,003)
insert into orders values(004,04,'recived','2023-5-20','2023-5-22',52,4,004)
insert into orders values(005,05,'delivered','2023-5-26','2023-5-28',53,5,005)



create table order_items (order_id int, item_id int, product_id int, quantity int, list_price int, discount varchar(20),
constraint s9 foreign key (order_id) references orders(order_id),
constraint s10 foreign key (product_id) references products(product_id))

insert into order_items values(001,2110,1,8,2100,'20%')
insert into order_items values(002,217,2,5,400,'15%')
insert into order_items values(003,257,3,12,400,'25%')
insert into order_items values(004,281,4,10,400,'18%')
insert into order_items values(005,238,5,2,400,'12%')



select * from store
select * from categories
select * from brands
select * from products
select * from stocks
select * from customers
select * from staffs
select * from orders
select * from order_items

SELECT orders.order_id, orders.order_status,orders.order_date, orders.required_date,
orders.store_id,store.store_name, store.city
    FROM orders   
    INNER JOIN store ON orders.store_id=  store.store_id;    
	
select products.product_id, products.product_name, products.model_year, products.list_price, 
customers.customer_id, customers.first_name
from products
inner join customers
on products.product_id = customers.customer_id



	--order_items.order_id, order_items.quantity, order_id.list_price, store.store_name, store.phone, 
--product.product_name, customer.customer_name6