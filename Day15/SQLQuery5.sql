

DECLARE @salary INT;

DECLARE salary_cursor CURSOR

FOR

SELECT salary FROM employee ORDER BY salary;

OPEN salary_cursor;

FETCH NEXT FROM salary_cursor INTO @salary;

CLOSE salary_cursor

DEALLOCATE salary_cursor;

exec @salary=@salary output









