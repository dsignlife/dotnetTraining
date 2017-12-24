--11. Give the name of employees who work longer than any employee of London. 

select distinct e.FirstName, e.City , datediff(year,e.HireDate,GETDATE()) as HIREAGE
from Employees e, Employees d
where e.FirstName in (select FirstName from Employees where City != 'London') and e.HireDate > d.HireDate
;
