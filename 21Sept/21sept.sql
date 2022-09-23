use Library

select Member_name 
from Member
where YEAR(Acc_open_date)=2006;


SELECT Book_Name 
from Book
where Author=Loni AND Cost<600;

SELECT * 
FROM Issue
where Return_date is NULL;

SELECT ISNULL(Return_date, '31-Dec-06')
FROM Issue
where Lib_Issue_Id NOT IN (7005,7006);

