--15. Give the name of the products sold by all employees. 


select distinct p.ProductName
from Orders o
inner join [Order Details] od
on o.OrderID = od.OrderID
inner join Products p
on od.ProductID = p.ProductID
inner join Employees e
on o.EmployeeID = e.EmployeeID

;