--14. Give the name of customers who bought all products with price less than 5. 

select distinct c.ContactName
from Customers c
join Orders o on o.CustomerID = c.CustomerID
join [Order Details] od on od.OrderID = o.OrderID
where od.UnitPrice > 5