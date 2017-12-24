--RESTORE FILELISTONLY
--FROM DISK = 'C:\Users\TomzPC\Desktop\NET\W31\Northwind.bak'
-- validate data




RESTORE database Northwnd
FROM DISK = 'C:\Users\TomzPC\Desktop\NET\W31\Northwind.bak'

WITH MOVE 'Northwind' TO 'C:\Users\TomzPC\Desktop\NET\W31\Northwind.mdf',
MOVE 'Northwind_log' TO 'C:\Users\TomzPC\Desktop\NET\W31\Northwind.ldf',
REPLACE;