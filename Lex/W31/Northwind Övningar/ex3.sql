--3. Give the name, address, city, and region of employees older than 50 years old 

use NORTHWND
select FirstName, LastName, Address, City, Region
--select datediff(year,BirthDate,GETDATE()) AS DiffYear
from Employees
where datediff(year,BirthDate,GETDATE()) > 50

;
