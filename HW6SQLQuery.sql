select pr.ProductID
       ,pr.ProductName
	   ,sum(od.UnitPrice*od.Quantity) AS 'Kazanılan Toplam Miktar' 
from Products as pr 
inner join [Order Details] as od on pr.ProductID=od.ProductID
inner join Orders as o on od.OrderID=o.OrderID
group by pr.ProductID,pr.ProductName 
order by pr.ProductID