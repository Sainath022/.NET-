CREATE TABLE  "Department" 
   (	
    "dept_id" int NOT NULL primary key,
	 dept_name char(20),
	 salary money ,
   );

CREATE TABLE  "Employee" 
   (	
    "emp_id" int NOT NULL PRIMARY KEY, 
	"first_name" CHAR(40), 
	"last_name" CHAR(35),
	"dept_id" int NOT NULL Foreign key references Department(dept_id),
	 );

