create table store(store_id int primary key,store_name varchar(20),phone int,email varchar(20),city varchar(20),
state varchar(20),zip_code int)
insert into store values (1,'mkpit',12345,'m@gmail.com','nagpur','mh',440001)



create table categories(category_id int primary key, category_name varchar(20))
insert into categories values (1,'electronics')


create table brands(brand_id int primary key, brand_name varchar(20))
insert into brands values (1,'hitachi')


create table products(product_id int primary key, product_name varchar(20),brand_id int, 
model_year int, list_price int,category_id int,
constraint s1 foreign key(brand_id) references brands(brand_id), 
constraint s2 foreign key(category_id) references categories(category_id))

insert into products values (1,'AC',1,2023,25000,1)


create table stocks(store_id int, quantity int,product_id int,
constraint s3 foreign key(store_id) references store(store_id),  
constraint s4 foreign key (product_id) references products(product_id))

insert into stocks values (1,99,1)


create table customers(customer_id int primary key, first_name varchar(20), last_name varchar(20), phone int,
email varchar(20), street varchar(20),
city varchar(20), state varchar(20), zip_code int)

insert into stocks values (01,'Narendra','Modi',9253130921,'Nmo_official@gmail.com','Sector 18 kpjy, delhi''Delhi', 'chandigad', 000011)


create table staffs(staff_id int primary key, first_name varchar(20), last_name varchar(20), email varchar(20), 
phone int, active varchar(20), 
store_id int, manager_id int,
constraint s5 foreign key(store_id) references store(store_id))

insert into staffs values(001,'Amit','shah','amitshahofficial@gmail.com',9164578954,'current/leave',1,0001)



create table orders(order_id int primary key, customer_id int, order_status varchar(20), order_date date, 
required_date date, shipped_id int, store_id int, staff_id int,
constraint s6 foreign key (customer_id) references customers(customer_id),
constraint s7 foreign key (store_id) references store(store_id),
constraint s8 foreign key (staff_id) references staffs(staff_id))

insert into orders values(001,01,'delivered','18/5/2023','21/5/2023',23,1,001)

create table order_items (order_id int, item_id int, product_id int, quantity int, list_price int, discount varchar(20),
constraint s9 foreign key (order_id) references orders(order_id),
constraint s10 foreign key (product_id) references products(product_id))

insert into order_items values(001,2110,1,8,2100,'20%')


select * from store,categories,brands,products,stocks,customers,staffs,orders,order_items

