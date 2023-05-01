create or alter trigger num on Banktb
after insert
as
select 'row added'

insert into Banktb 
Values (105,'Krishna',9000,104);