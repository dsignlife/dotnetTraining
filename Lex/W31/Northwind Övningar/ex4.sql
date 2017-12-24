--4. Give the name, address, city, and region of employees 
--that have placed orders to be delivered in
--Belgium. Write two versions of the query without join. 

use NORTHWND
--select distinct Orders.EmployeeID, 
select distinct e.FirstName, e.LastName, e.Address, e.City, e.Region
from Employees e, Orders o
where o.ShipCountry = 'Belgium' AND e.EmployeeID = o.EmployeeID

;
