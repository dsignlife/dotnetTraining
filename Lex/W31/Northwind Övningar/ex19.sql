--19. Given the name of the categories and the average price of products in each category. 

select Avg(p.UnitPrice) as AvgPrice, c.CategoryName
from Categories c
inner join Products p on c.CategoryID = p.CategoryID
group by p.CategoryID, c.CategoryName


;
