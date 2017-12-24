--18. Give the average price of products by category. 

select Avg(p.UnitPrice) as AvgPrice
from Categories c
inner join Products p on c.CategoryID = p.CategoryID
group by p.CategoryID, c.CategoryName


;
