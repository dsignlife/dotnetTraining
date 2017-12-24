--5. Give the employee name and the customer name
-- for orders that are sent by the company ‘Speedy Express’ 
--to customers who live in London. 

use NORTHWND
select  e.FirstName, c.ContactName, s.CompanyName
from Orders o
inner join Employees e on o.EmployeeID = e.EmployeeID
inner join Customers c on o.CustomerID = c.CustomerID
inner join Shippers s on o.ShipVia = s.ShipperID  
where o.ShipVia = 1 and c.City = 'London'

;