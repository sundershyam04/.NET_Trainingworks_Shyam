CREATE DATABASE Shopping;
USE Shopping;

CREATE TABLE Customer(
CustiD INT PRIMARY KEY,
CustName VARCHAR(20),
City VARCHAR(20),
CustState VARCHAR(20))

CREATE TABLE PRODUCTS(
ProdID INT PRIMARY KEY,
ProdName VARCHAR(20),
UnitPrice INT,
QntinStock INT )

--c) Create a table sales_header
--invno,invdate,invamt,disPercent

CREATE TABLE Sales_Header(
InvoNo int PRIMARY KEY,
InvDate date,
Invamt int,
DisPercent int )


--d) create a table sales_detail
--invno,custid,prodid,qtysold

CREATE TABLE Sales_Details(
InvoNo int ,
CustId int,
ProdId int,
QtySold int)

--e) Create foreign key of invno in the sales_detail table.

alter table Sales_Details
add foreign key( InvoNo) references Sales_Header(InvoNo)

--3) alter the sales_detail to apply a foreign key to custid and prodid.

alter table Sales_Details
add foreign key(CustId) references Customer(CustiD) 

ALTER TABLE Sales_Details
add foreign key(prodId) references PRODUCTS(ProdId)


--4) Drop a column qtySold.

alter table Sales_Details
drop column QtySold

--5) Add a column Qty.

alter table Sales_Details
add  Qty int

--6) rename qty to Quantity(InNos)