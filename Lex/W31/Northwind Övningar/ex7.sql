--7. Give the name and title of employees and the name and title of the person to which they refer (or null for the latter values if they don’t refer to another employee). 


select e.FirstName, e.Title, e.ReportsTo, ee.FirstName, ee.Title

from Employees e

left join Employees ee 
on e.ReportsTo = ee.EmployeeID


