--8. Give the customer name, the product name and the supplier name for customers 
--who live in London and suppliers whose name is ‘Pavlova, Ltd.’ or ‘Karkki Oy’. 

select distinct c.ContactName, p.ProductName, s.CompanyName
from Orders o
inner join Customers c on o.CustomerID = c.CustomerID
inner join [Order Details] od on o.OrderID = od.OrderID
inner join Products p on  od.ProductID = p.ProductID
inner join Suppliers s on p.SupplierID = s.SupplierID
where c.City = 'London'  and  (s.CompanyName = 'Pavlova, Ltd.' or s.CompanyName = 'Karkki Oy')
;