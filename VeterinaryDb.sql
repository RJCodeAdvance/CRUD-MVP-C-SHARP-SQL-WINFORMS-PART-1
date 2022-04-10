create database VeterinaryDb 
go
use VeterinaryDb
go
create table Pet
(
	Pet_Id int identity (100000,1) primary key,
	Pet_Name nvarchar (50) not null,
	Pet_Type nvarchar (50) not null,
	Pet_Colour nvarchar (50) not null,	
)
go
insert into Pet values('Buttons', 'Dog', 'White')
insert into Pet values('Coda', 'Cat', 'Multicolor')
insert into Pet values('Merlin', 'Parrot', 'Green-Yellow')
insert into Pet values('Nina', 'Turtle', 'Dark Gray')
insert into Pet values('Domino', 'Rabbit', 'White')
insert into Pet values('Luna', 'Hamster', 'Orange')
insert into Pet values('Lucy', 'Monkey', 'Brown')
insert into Pet values('Daysi', 'Horse', 'White')
insert into Pet values('Zoe', 'Snake', 'Yellow white')
insert into Pet values('Max', 'Budgie', 'Yellow')
insert into Pet values('Charlie', 'Mouse', 'White')
insert into Pet values('Rocky', 'Squirrel', 'Brown-Orange')
insert into Pet values('Leo', 'Dog', 'White-Black')
insert into Pet values('Loki', 'Cat', 'Black')
insert into Pet values('Jasper', 'Dog', 'Silver')
go
select *from Pet