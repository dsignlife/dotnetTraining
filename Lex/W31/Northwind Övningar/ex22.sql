--22. For each employee give the identifier, name, and the number of distinct products sold, ordered by the employee identifier. 

select distinct p.ProductID,p.ProductName, o.EmployeeID as OrderBy 
from Products p
inner join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on od.OrderID = o.OrderID
inner join Employees e on o.EmployeeID = e.EmployeeID


--group by  p.ProductID, p.ProductName, o.EmployeeID
order by o.EmployeeID
;