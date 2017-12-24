--2. Give the name, address, city, and region of employees living in USA 

use NORTHWND
select FirstName, LastName, City, Region 
from Employees where Country = 'USA';