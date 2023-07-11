create table employee(id int identity primary key, name varchar(500),
city varchar(500), address varchar(500))

create procedure AddEmp
(
@Name varchar(500),
@City varchar (500),
@Address varchar (500)
)
as begin 
insert into employee values(@Name, @City, @Address )
end
