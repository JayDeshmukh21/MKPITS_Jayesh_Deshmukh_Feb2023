create table emp(empid int, empname varchar(20))
insert into emp values(11,'rakshita')
insert into emp values(12,'vanshika')
insert into emp values(13,'asawari')

select * from emp



create trigger emp
on emp
for insert
as 
insert into
EmpLog (empid,operation,UpdatedData)

select empid, 'insert' , GETDATE()
from inserted;

insert into emp values(14,'jay')
select * from emp
