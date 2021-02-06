--Select
select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

select * from Customers where City = 'Berlin'

--case insensitive
select * from products where CategoryID=1 or CategoryID=3

select * from products where CategoryID=1 and UnitPrice>=10 and UnitPrice<=20

Select * from Products where UnitPrice<=60 and UnitsInStock<=10 order by CategoryID,UnitPrice desc  --ascending asc --descending desc

select COUNT(*) Adet from Products where CategoryID = 8

select categoryId,count(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--inner join sadece iki tabloda eşleşen data varsa görür
--DTO Data Transformation Object

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.orderId = od.OrderId

select * from Customers c left join Orders o
on c.CustomerId = o.CustomerID
where o.CustomerID is null




