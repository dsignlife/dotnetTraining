--20. Give the identifier and the name of the companies that provide more than 3 products.  

select p.SupplierID, s.CompanyName
from Products p
inner join Suppliers s on s.SupplierID = p.SupplierID
group by p.SupplierID, s.CompanyName
having count(p.SupplierID) > 3
;