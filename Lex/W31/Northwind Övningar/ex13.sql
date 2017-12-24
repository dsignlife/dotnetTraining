--13. Give the name of customers who have not purchased any product. 

select distinct c.ContactName
from Customers c
join Orders o on o.CustomerID = c.CustomerID
where c.CustomerID != o.CustomerID