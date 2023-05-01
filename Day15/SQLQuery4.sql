 
DECLARE @salary INT;

DECLARE salary_cursor CURSOR

FOR

SELECT salary FROM employee ORDER BY salary;

OPEN salary_cursor;
FETCH NEXT FROM salary_cursor INTO @salary;

while @@fetch_status=0
begin
FETCH NEXT FROM salary_cursor INTO @salary;
FETCH NEXT FROM salary_cursor
INTO @salary; END
DEALLOCATE salary_cursor;
