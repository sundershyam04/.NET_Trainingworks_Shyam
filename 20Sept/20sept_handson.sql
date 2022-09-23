--use pubs

select * from titles
where type like 'business';

select * from titles
where  pubdate >'1991-06-12' and type != 'business'

-- <> or != can be used 

select * from titles
where pub_id != 1389
order by pub_id desc , title_id asc;

select * from titles
where pub_id != 1389
order by pub_id desc , advance asc;


--Aggregate functions

select COUNT(emp_id)as Emp_Count from employee

select COUNT(titles.title) as Book_Count from titles
where type like 'business'

select sum(advance) from titles
where advance = 5000;

select min(advance) from titles
select max(advance) from titles

select AVG(advance) from titles

-- minimum advance => each type

select min(advance) as minimum_Advance,type  from titles
group by type


--Other task:

use Shopping;

--Add reference column to issue table

alter table Lib_Issue
add  Reference char(30)

--from reference column

alter table Lib_Issue
drop column Reference;

--Insert 5 values to member table
insert into Member values(101,'siva','2010-01-10',4,00.5)
insert into Member values(102,'sundr','2019-04-12',5,55.89)
insert into Member values(103,'gayatri','2017-02-13',4,200.09)
insert into Member values(104,'ramya','2016-08-14',5,10.09)
insert into Member values(105,'Satvika','2019-03-8',5,89.09)
insert into Member values(106,'ganesh','2018-08-13',115,89.99)
select * from Member

--Insert values to Book table
--sp_help Book

insert into Book values(101,'Let us c','Denis',450,'System')
insert into Book values(102,'Oracle Complete Ref','Loni',550,'Database')
insert into Book values(103,'Mastering SQL','Loni',250,'Database')
insert into Book values(104,'Mastering SQL','Mastering SQL',750,'Database')
select * from Book
insert into Book values (105,'  National Geographic', 'Adis Scott', 1000,  'Science')

--Modify the book data 
Update Book
set Cost = 300, Category = 'RDBMS'
WHERE Book_No = 103;

--copy 

select * into Member101 from Member

--Insert data to Lib_Issue table

insert into Lib_Issue values(7001, 101, 1,'10-Dec-06',null)
insert into Lib_Issue values(7002, 102, 2,'25-Dec-06',null)
insert into Lib_Issue values(7003, 104, 1,'15-Jan-06',null)
insert into Lib_Issue values(7004, 101, 1,'04-Jul-06',null)
insert into Lib_Issue values(7005, 104, 2,'15-Nov-06',null)
insert into Lib_Issue values(7006, 101, 3,'18-Feb-06',null)

alter table Lib_Issue 
drop constraint FK__Issue__Member_Id__5AEE82B9

select * from Lib_Issue

update Lib_Issue
set Return_date = DATEADD(DAY,15,Issue_Date)
where Lib_Issue_Id = 7004 or Lib_Issue_Id = 7005;

select * from Member

--Update Penalty

update Member
set Penalty_Amount=100
where Member_Name ='sundr';

--remove from issue 

delete  from Lib_Issue
where Member_Id = 1 and Issue_Date <'10-Dec-06';

--remove from book

delete from Book
where Category != 'RDBMS' AND Category!= 'Database'

alter table Lib_Issue
drop constraint "FK__Issue__Book_NO__5BE2A6F2"

drop table Member101;

--drop table Book101;

sp_help Lib_Issue
sp_help Book
sp_help Member

--List all the tables in the current database

select * from INFORMATION_SCHEMA.TABLES
===================================================
--Only year comparison

select * from Member
WHERE YEAR( Acc_Open_Date) = 2006;

--List all the books that are written by Author Loni and has price  less then 600.
select * from Lib_Issue
select Book.Book_Name from Book
where Author = 'Loni' and Cost<600;

--List the Issue details for the books that are not returned yet
select  distinct lib_Issue.Book_NO , Book.Book_Name from Lib_Issue,Book
where Return_date is null

update Lib_Issue
set Return_date = '30-Dec-06' 
where Lib_Issue_Id != 7005 and Lib_Issue_Id != 7006

select * from Lib_Issue
where DATEDIFF(day,Issue_Date,Return_date) > 15;

select * from Book
where Cost between 500 and 700  and Category = 'Database'

select * from book 
where Category in ('Science', 'Database', 'Fiction', 'Management')

select * from Member
order by Penalty_Amount desc

select * from Book
order by Category , Cost desc

select * from Book
where Book_Name like '%SQL%'

select * from Member
where ( (Member_Name like 'r%' or Member_Name like 'g% ) and Member_Name like '%i%')