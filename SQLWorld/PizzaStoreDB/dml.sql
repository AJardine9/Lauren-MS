use PizzaStoreDB;
go

insert into [PizzaStore].[Crust]([Name], [Price], [Stock])
	values ('Thin', 1.0, 10), ('Regular', 1.50, 10), ('Cheese', 2.0, 10), ('Chicago', 2.0, 10);

	--SET Identity_Insert PizzaStore.[Crust] ON
	--insert into PizzaStore.[Crust](CrustId,InventoryId,PizzaId,Name,Stock,Price,Active)
	--values (1,
	--(select InventoryId from PizzaStore.[Inventory] where InventoryId = 1),
	--(select PizzaId from PizzaStore.[Pizza] where PizzaId = 1),
	--'thin',
	--10,
	--1,
	--'true'); 
	--SET Identity_Insert PizzaStore.[Crust] Off

insert into [PizzaStore].[Size]([Name], [Price], [Stock])
	values('Small', 5.0, 10), ('Medium', 6.0, 10), ('Large', 7.0, 10), ('ExtraLarge', 8.0, 10);

insert into [PizzaStore].[Topping]([Name], [Price], [Stock])
	values('cheeseCheddar', 1.0, 10), ('cheeseMozzarella', 1.0, 10), ('sauceTomato', 1.0, 10), ('sauceMarinara', 1.0, 10), ('sauceAlfredo', 1.0, 10), ('sauceBBQ', 1.0, 10), ('veggieRedOnion', 1.0, 10), ('veggieGreenPepper', 1.0, 10), ('veggieBlackOlive', 1.0, 10), ('veggieGreenOlive', 1.5, 10), 
	('veggieMushroom', 1.5, 10), ('veggieSpinach', 1.0, 10), ('veggiePineapple', 1.0, 10), ('veggieTomato', 1.0, 10), ('meatPepperoni', 1.25, 10), ('meatBacon', 2.0, 10), ('meatSausage', 1.75, 10), ('meatHam', 1.25, 10), ('meatEgg', 1.0, 10), ('meatChicken', 1.25, 10);

	SET Identity_Insert [PizzaStore].[Account] ON
	insert into [PizzaStore].[Account]([AccountId], [Active])
		values (1, 1)
	SET Identity_Insert [PizzaStore].[Account] OFF

	SET Identity_Insert [PizzaStore].[Address] ON
	insert into [PizzaStore].[Address]([AddressId], [Street], [State], [City])
		values (1, 'Fletcher', 'Florida', 'Tampa')
	SET Identity_Insert [PizzaStore].[Address] OFF

	SET Identity_Insert [PizzaStore].[Location] ON
	insert into [PizzaStore].[Location]([LocationId], [AccountId], [AddressId], [InventoryId], [OrderNumber])
		values (1, 1, 1, 1, 1)
	SET Identity_Insert [PizzaStore].[Location] OFF

	SET Identity_Insert [PizzaStore].[Inventory] ON
	insert into [PizzaStore].[Inventory]([InventoryId], [CrustId], [ToppingId], [SizeId])
		values (1, 1, 1, 1)
	SET Identity_Insert [PizzaStore].[Inventory] OFF

	SET Identity_Insert [PizzaStore].[User] ON
	insert into [PizzaStore].[User]([UserId], [AccountId], [LocationId], [AddressId], [Username], [Password], [LastLocationOrdered], [LastTimeOrdered])
	values (1, 1, 1, 1, 'Admin', 'Password', 'TestAddress', GetDate());
	SET Identity_Insert [PizzaStore].[User] OFF

	SET Identity_Insert [PizzaStore].[Order] ON
	insert into [PizzaStore].[Order]([OrderId], [UserId], [LocationId], [OrderNumber], [Username], [Total], [PurchaseTime], [LocationAddress])
	values (1, 1, 1, 1, 'Admin', 10, GetDate(), 'Test Address')
	SET Identity_Insert [PizzaStore].[Order] OFF

	SET Identity_Insert [PizzaStore].[Pizza] ON
	insert into [PizzaStore].[Pizza]([PizzaId], [OrderId], [CrustId], [SizeId], [ToppingId])
	values (1, 1, 1, 1, 1)
	SET Identity_Insert [PizzaStore].[Pizza] OFF