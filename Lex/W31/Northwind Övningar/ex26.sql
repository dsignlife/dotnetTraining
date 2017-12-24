--26. Give the customer name and the product name such that the quantity of this product bought 
--by the customer in a single order is more than 5 times the average quantity 
--of this product bought in a single order among all clients.



select c.ContactName, p.ProductName, od.Quantity
from Customers c
join Orders o on o.CustomerID = c.CustomerID
join [Order Details] od on od.OrderID = o.OrderID
join Products p on p.ProductID = od.ProductID
