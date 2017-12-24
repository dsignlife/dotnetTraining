--17. Give the name of customers who bought exactly the same products as the customer whose identifier is ‘LAZYK’ 

select c.ContactName
from Orders o
join Customers c on c.CustomerID = o.CustomerID
join [Order Details] od on o.OrderID = od.OrderID
join Products p on p.ProductID = od.ProductID
where p.ProductID in (select ProductID from [Order Details] where c.CustomerID = 'LAZYK')
