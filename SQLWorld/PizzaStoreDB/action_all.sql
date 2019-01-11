use PizzaStoreDB;
go

-- view
create view vw_GetCrusts with schemabinding
as
(
  select Name
  from PizzaStore.Crust as c
  inner join PizzaStore.Size as s on s.SizeId = c.CrustId 
);
go

select * from vw_GetCrusts;
go

-- function
create function fn_CountCrusts(@countId int)
returns int
as
begin
  declare @counter int;

  select @counter = count(*)
  from PizzaStore.Crust
  where CrustId <= @countId

  return @counter
end;
go

select * from PizzaStore.Crust where CrustId = dbo.fn_CountCrusts(1);
go

create function fn_CountCrusts2(@id int)
returns table
as
  return
  select Name
  from PizzaStore.Crust
  where CrustId >= @id
go

select * from dbo.fn_CountCrusts2(2);
go

-- stored procedures // sequencial set of actions set to happen in particular order
create procedure pr_SetUser(@name nvarchar (50), @street nvarchar (50), @city nvarchar (50), @addressId int output)
as
begin
	declare @addressId;
	
	select @addressId = AddressId
	from PizzaStore.Address
	where Street = @street, City = @city;

	set isolation_level_on  repreatable_read -- read documentation on understanding isolation levels
	begin transaction
		begin try
			if(@addressId > 0)
			begin
				insert into PizzaStore.[User]([Username], [AddressId])
				values (@username, @addressId)
			end
			else
			begin
				insert into PizzaStore.[Address]([City], [Street])
				values (@username, @addressId)
			end
			raiserror (50000, -1, -1, 'this is an error')
			throw ('The record does not exist.', 50000)
		commit transaction
	end try
	begin catch
		rollback transaction
		print error_severity();
		print error_message();
	end catch
end;
go

declare @id int;

execute pr_SetUser 'fred', 'fowler', 'tampa bay', @id output;

-- execute dbo.pr_SetUser 'fred', 'fowler', 'tampa bay', @id