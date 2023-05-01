create or alter procedure showBanktb(@accno int) as
begin
select * from Banktb where AccNo = @accno;
end;

exec showBanktb 101
exec showBanktb 102