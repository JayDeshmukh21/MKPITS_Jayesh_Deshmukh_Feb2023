create table intern (rno int,first_name varchar(10),last_name varchar(10),city varchar(10),cource varchar(10))
insert into intern values (01,'Jayesh','Deshmukh','Amravati','Dot_Net')
insert into intern values (02,'Prasanna','Varhade','Amravati','Dot_Net')
insert into intern values (03,'Prasham','Thokal','Akola','Java')
insert into intern values (04,'Vaishnavi','Deshmukh','Wardha','Python')
insert into intern values (05,'Raj','Varhade','Wardha','Java')
insert into intern values (06,'Jay','Deshpande','Nagpur','Dot_Net')
insert into intern values (07,'Rushi','Hirulkar','Amravati','Java')
insert into intern values (08,'Krishna','kale','Akola','Python')
insert into intern values (09,'Sanjay','Dongre','Akola','Python')
insert into intern values (10,'Mahesh','kale','Nagpur','Dot_Net')

select * from intern 
select * from intern order by first_name desc
select * from intern order by last_name desc
select * from intern order by city desc
select * from intern order by city desc
select * from intern order by rno desc


--quary to find records whose name is Rushi

select * from intern where first_name ='Rushi'

select * from intern where first_name ='Jayesh'

select * from intern where rno=01
select * from intern where rno>02
select * from intern where rno<04
select * from intern where rno<=6
select * from intern where rno>=5

select * from intern where first_name = 'mahesh' and last_name = 'kale'

select * from intern where city='amravati'

select * from intern where city='Nagpur' order by first_name desc

--quary to count no of student on course whose 
--city is nagpur 

select cource , count (*) from intern where city ='akola' group by cource
select cource , count (*) from intern where city ='amravati' group by cource

select cource , count (*) from intern where city ='nagpur' group by cource

--quary to count no of student on course whose
--city is not nagpur

select cource , count(*) from intern where city <> 'amravati' group by cource order by cource

--select city , count (*) from intern where cource ='java' group by city having count(*)>4






