use shopping


select  category,count(Book_No) from book 
group by category

select * from book
select * from issue

select book_no,count(lib_issue_id) Issuedcount from issue 
group by book_no
order by issuedcount

select * from member	
select max(Penalty_Amount)from member

select max(Penalty_Amount) Max ,min(penalty_amount) Min,sum(penalty_amount) Sum,avg(penalty_Amount) Avg  from Member

select member_id, book_no,count(lib_issue_id) Issuedcount from issue 
group by book_no,Member_Id
order by issuedcount desc

select month(issue_date) month,count(book_no) bookcount from Issue
group by month(issue_date)
order by bookcount desc
select book_no from issue where Issue_Date is  null

select m.Member_Id,i.Member_Id "DEPT"
from member m inner join issue i
on m.Member_Id=i.Member_Id

select member_id ,max(lib_issue_id) Max,min(lib_issue_id) Min from issue
group by member_id

select * from issue
where month(issue_date) in ('12','7')

use shopping
select b.Book_No,b.book_name,i.Issue_Date,b.Category
from Book b inner join issue i
on b.Book_No=i.Book_No
where month(issue_date)=9 and b.Category='database'

select m.Member_Id,m.member_name, count(i.lib_issue_id) Issuecount
from member m inner join issue i
on m.Member_Id=i.Member_Id
group by rollup( m.Member_Id ,m.member_name)
order by Issuecount desc


select b.Book_No,b.book_name,i.Issue_Date,i.Return_date
from Book b inner join issue i
on b.Book_No=i.Book_No
where b.author='loni'

select m.Member_Id, m.Member_Name
from member m inner join  issue i
on  m.Member_Id=i.Member_Id
inner join Book b
on i.Book_No=b.Book_No
where b.Category='system'

select category,max(cost) from book
group by (Category)

select distinct i.* from issue i,member m where i.issue_date not between m.acc_open_date and i.return_date

select member_id from member intersect select member_id from issue

select member_id from member
except
select member_id from issue


select*from issue
select*from member
select*from book


use Northwind
select*from Customers
select distinct count(customerid)from customers

select distinct count(customerid)from customers
where ContactName like '%s%'

select distinct count(customerid)from customers
where ContactName like 'b%'

select distinct city,count(customerid)from customers
group by(City)


select AVG(Cost) FROM Book
where Category = "Database";