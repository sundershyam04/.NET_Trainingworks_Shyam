--Library assignment

CREATE TABLE Member (
Member_Id int PRIMARY KEY ,
Member_Name char(25),
Acc_Open_Date date,
Max_Books_Allowed int,
Penalty_Amount Decimal(7,2))

create table Book(
Book_No int primary key,
Book_Name varchar(30),
Author varchar(30),
Cost Decimal(7,2),
Category	Char(10)
)

create table Issue(
Lib_Issue_Id int primary key,
Book_NO int,
Member_Id int ,
Issue_Date date,
Return_date date
)

alter table Issue
 add  foreign key (Book_No)
 references Book(Book_No);

 alter table Issue 
 add  foreign key (Member_Id)
 references Member(Member_Id)