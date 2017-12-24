--21. Give the identifier, name, and number of orders of employees, ordered by the employee identifier.


select o.EmployeeID, e.FirstName, count(o.OrderID) as Ordered
from Orders o
inner join Employees e on o.EmployeeID = e.EmployeeID
group by o.EmployeeID , e.FirstName  
order by o.EmployeeID

;