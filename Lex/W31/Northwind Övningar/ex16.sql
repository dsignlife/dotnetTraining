--16. Give the name of customers who bought all products purchased by the customer whose identifier is ‘LAZYK’ 

select distinct c.ContactName
from Customers c
join Orders o on c.CustomerID = o.CustomerID
where c.CustomerID = 'LAZYK'