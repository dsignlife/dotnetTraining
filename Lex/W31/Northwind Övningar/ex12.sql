--12. Give the name of employees and the city where they live for employees who have sold to customers in the same city. 


select e.FirstName, e.City, c.ContactName,c.City
from Employees e
join Orders o on o.EmployeeID = e.EmployeeID
join Customers c on c.CustomerID = o.CustomerID
where e.City = c.City