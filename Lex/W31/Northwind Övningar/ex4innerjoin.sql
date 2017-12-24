--4. Give the name, address, city, and region of employees 
--that have placed orders to be delivered in
--Belgium. Write two versions of the query with join. 

use NORTHWND
--select distinct o.EmployeeID
select distinct o.EmployeeID, e.FirstName, e.LastName, e.Address, e.City, e.Region
from Orders o
inner join Employees e on o.EmployeeID = e.EmployeeID
where o.ShipCountry = 'Belgium' 

;
