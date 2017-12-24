--9. Give the name of products that were bought or sold by people who live in London. Write two versions of the query, with and without union. 


select p.ProductName
from Orders o
inner join Employees e on o.EmployeeID = e.EmployeeID
inner join [Order Details] od on  o.OrderID = od.OrderID
inner join Products p on p.ProductID = od.ProductID
join Customers c on c.CustomerID = o.CustomerID
where e.City = 'London'

union

select p.ProductName
from Orders o
inner join Employees e on o.EmployeeID = e.EmployeeID
inner join [Order Details] od on  o.OrderID = od.OrderID
inner join Products p on p.ProductID = od.ProductID
join Customers c on c.CustomerID = o.CustomerID
where c.City = 'London'

;