--24. Give the identifier, name, and total sales of employees, ordered by the employee identifier for employees who have sold more than 70 different products. 


select o.EmployeeID, e.FirstName, count(o.OrderID) as Ordered
from Orders o
inner join Employees e on o.EmployeeID = e.EmployeeID
group by o.EmployeeID , e.FirstName  
having count(o.OrderID) > 70
order by o.EmployeeID

;