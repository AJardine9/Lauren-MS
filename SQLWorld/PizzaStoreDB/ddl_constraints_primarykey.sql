use PizzaStoreDB;
go

alter table PizzaStore.[Address]
	add constraint PK_Address_AddressId primary key (AddressId)

alter table PizzaStore.[User]
	add constraint PK_User_UserId primary key (UserId)

alter table PizzaStore.[Order]
	add constraint PK_Order_OrderId primary key (OrderId)

alter table PizzaStore.[Location]
	add constraint PK_Location_LocationId primary key (LocationId)

alter table PizzaStore.[Topping]
	add constraint PK_Topping_ToppingId primary key (ToppingId)

alter table PizzaStore.[Size]
	add constraint PK_Size_SizeId primary key (SizeId)

alter table PizzaStore.[Crust]
	add constraint PK_Crust_CrustId primary key (CrustId)

alter table PizzaStore.[Inventory]
	add constraint PK_Inventory_InventoryId primary key (InventoryId)

alter table PizzaStore.[Pizza]
	add constraint PK_Pizza_PizzaId primary key (PizzaId)

alter table PizzaStore.[Account]
	add constraint PK_Account_AccountId primary key (AccountId)

alter table PizzaStore.[CrustInventory]
	add constraint PK_CrustInventory_CrustInventoryId primary key (CrustInventoryId)

alter table PizzaStore.[SizeInventory]
	add constraint PK_SizeInventory_SizeInventoryId primary key (SizeInventoryId)

alter table PizzaStore.[ToppingInventory]
	add constraint PK_ToppingInventory_ToppingInventoryId primary key (ToppingInventoryId)

alter table PizzaStore.[PizzaTopping]
	add constraint PK_PizzaTopping_PizzaToppingId primary key (PizzaToppingId)
