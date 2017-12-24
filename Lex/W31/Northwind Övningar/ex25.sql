--25. Give the names of employees who sell the products of more than 7 suppliers. 



select distinct e.FirstName
from Employees e
inner join Orders o on o.EmployeeID = e.EmployeeID
inner join [Order Details] od on o.OrderID = od.OrderID
inner join Products p on od.ProductID = p.ProductID
inner join Suppliers s on s.SupplierID = p.SupplierID



group by e.FirstName
having count(distinct s.SupplierID) > 7
order by e.FirstName
;


