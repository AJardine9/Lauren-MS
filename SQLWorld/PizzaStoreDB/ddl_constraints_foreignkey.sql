use PizzaStoreDB;
go

alter table PizzaStore.[User]
add constraint FK_User_AddressId foreign key (AddressId) references PizzaStore.[Address](AddressId)

alter table PizzaStore.[Order]
add OrderNumber int

alter table PizzaStore.[User]
add constraint FK_User_AccountId foreign key (AccountId) references PizzaStore.[Account](AccountId)

alter table PizzaStore.[User]
add constraint FK_User_LocationId foreign key (LocationId) references PizzaStore.[Location](LocationId)

alter table PizzaStore.[Order]
add constraint FK_Order_UserId foreign key (UserId) references PizzaStore.[User](UserId)

alter table PizzaStore.[Order]
add constraint FK_Order_LocationId foreign key (LocationId) references PizzaStore.[Location](LocationId)

alter table PizzaStore.[Location]
add constraint FK_Location_AccountId foreign key (AccountId) references PizzaStore.[Account](AccountId)

alter table PizzaStore.[Location]
add constraint FK_Location_AddressId foreign key (AddressId) references PizzaStore.[Address](AddressId)

alter table PizzaStore.[Inventory]
add constraint FK_Inventory_LocationId foreign key (LocationId) references PizzaStore.[Location](LocationId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_OrderId foreign key (OrderId) references PizzaStore.[Order](OrderId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_CrustId foreign key (CrustId) references PizzaStore.[Crust](CrustId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_SizeId foreign key (SizeId) references PizzaStore.[Size](SizeId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_ToppingId foreign key (ToppingId) references PizzaStore.[Topping](ToppingId)

alter table PizzaStore.[Size]
add constraint FK_Pizza_InventoryId foreign key (InventoryId) references PizzaStore.[Inventory](InventoryId)

alter table PizzaStore.[Topping]
add constraint FK_Pizza_InventoryId foreign key (InventoryId) references PizzaStore.[Inventory](InventoryId)

alter table PizzaStore.[Crust]
add constraint FK_Pizza_InventoryId foreign key (InventoryId) references PizzaStore.[Inventory](InventoryId)

alter table PizzaStore.[ToppingInventory]
add constraint FK_Pizza_InventoryId foreign key (InventoryId) references PizzaStore.[Inventory](InventoryId)

alter table PizzaStore.[Crust]
add constraint FK_Pizza_InventoryId foreign key (InventoryId) references PizzaStore.[Inventory](InventoryId)

alter table PizzaStore.[Crust]
add constraint FK_Pizza_InventoryId foreign key (InventoryId) references PizzaStore.[Inventory](InventoryId)

alter table PizzaStore.[CrustInventory]
add constraint FK_CrustInventory_LocationId foreign key (LocationId) references PizzaStore.[Location](LocationId)

alter table PizzaStore.[CrustInventory]
add constraint FK_CrustInventory_CrustId foreign key (CrustId) references PizzaStore.[Crust](CrustId)

alter table PizzaStore.[ToppingInventory]
add constraint FK_ToppingInventory_LocationId foreign key (LocationId) references PizzaStore.[Location](LocationId)

alter table PizzaStore.[ToppingInventory]
add constraint FK_ToppingInventory_ToppingId foreign key (ToppingId) references PizzaStore.[Topping](ToppingId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_SizeId foreign key (SizeId) references PizzaStore.[Size](SizeId)

alter table PizzaStore.[SizeInventory]
add constraint FK_SizeInventory_LocationId foreign key (LocationId) references PizzaStore.[Location](LocationId)

alter table PizzaStore.[SizeInventory]
add constraint FK_SizeInventory_SizeId foreign key (SizeId) references PizzaStore.[Size](SizeId)

alter table PizzaStore.[PizzaTopping]
add constraint FK_PizzaTopping_PizzaId foreign key (PizzaId) references PizzaStore.[Pizza](PizzaId)

alter table PizzaStore.[PizzaTopping]
add constraint FK_PizzaTopping_ToppingId foreign key (ToppingId) references PizzaStore.[Topping](ToppingId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_SizeId foreign key (SizeId) references PizzaStore.[Size](SizeId)

Delete from PizzaStore.[Pizza]
where SizeId = 1