create table country (countryId int primary key, countryName varchar(20))

insert into country values (1, 'india' )
insert into country values (2,'Usa')

create table state (stateId int primary key, stateName varchar(20), cId int,
constraint c1 foreign key (cId) references country(countryId))

insert into state values (1, 'maharashtra' , 1)
insert into state values (2, 'mp' , 1)
insert into state values (3, 'washington' , 2)
insert into state values (4, 'lowa' , 2)

create table city (cityId int primary key, cityName varchar(20), stId int,
constraint s1 foreign key (stId) references state(stateId))

insert into city values (1,'nagpur' , 1)
insert into city values (2,'pune' , 1)
insert into city values (3,'bhopal' , 2)
insert into city values (4,'indore' , 2)
insert into city values (5,'Seattle' , 3)
insert into city values (6,'Spokane' , 3)
insert into city values (7,'Des Moines' , 4)
insert into city values (8,'Davenport' , 4)

-- to find country name state name using inner join on id --

select 
c1.countryId , c1.countryName,
s1.stateId , s1.stateName
from
country c1 inner join state s1
on 
c1.countryId = s1.cId
where
c1.countryName='India'


select 
c1.countryId, c1.countryName,
s1.stateId, s1.stateName
from 
country c1 inner join state s1
on 
countryId = s1.cId
where
c1.countryName='usa'

--to find only state--

select
s1.stateId, s1.stateName
from
country c1 inner join state s1
on 
countryId = cId
where
countryName = 'india'

--to find city by using state id--

select
ct.cityName
from
city ct inner join state s1
on 
stId = stateId
where
stateName = 'mp'

--to find state--

select stateName from state
where 
cId = (select countryId from country
		where
		countryName='india')


select cityName from city
where
stId = (select stateId from state
where stateName= 'maharashtra')
