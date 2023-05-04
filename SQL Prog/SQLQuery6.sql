create table teachers(teacher_id int primary key, age int )
create table subjects(teacher_id int, subjects varchar(20),
constraint t1 foreign key(teacher_id) references teachers(teacher_id)) 

insert into teachers values(1,21)
insert into subjects values (1,'chemistry')
insert into subjects values (1,'maths')

insert into teachers values(2,25)
insert into subjects values(2,'biology')
insert into subjects values(2,'english')

insert into teachers values(3,30)
insert into subjects values(3,'computer')

select * from teachers
select * from subjects

create table product(order_no int primary key, order_date varchar(20), customer_id int) 

create table product_detail(order_no int,product_id int, rate int, quantity int,
constraint p1 foreign key(order_no) references product(order_no))

insert into product values(4,'2022/12/12',212)
insert into product_detail values (4,123,200,2)
insert into product_detail values (4,124,500,1)

insert into product values(5,'2023/1/12',213)
insert into product_detail values (5,123,200,1)
insert into product_detail values (5,125,600,2)

insert into product values(6,'2023/2/12',214)
insert into product_detail values (6,125,600,1)

select * from product
select * from product_detail


