--10. Give the names of employees who are strictly older than: (a) an employee who lives in London. (b) any employee who lives in London. 

select distinct e.FirstName, e.City , datediff(year,e.BirthDate,GETDATE()) as age
from Employees e, Employees d
where e.FirstName in (select FirstName from Employees where City != 'London') and e.BirthDate > d.BirthDate
;
