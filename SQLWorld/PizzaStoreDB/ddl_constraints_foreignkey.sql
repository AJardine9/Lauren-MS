use PizzaStoreDB;
go

alter table PizzaStore.[User]
add constraint FK_User_AddressId foreign key (AddressId) references PizzaStore.[Address](AddressId)

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

alter table PizzaStore.[Location]
add constraint FK_Location_InventoryId foreign key (InventoryId) references PizzaStore.[Inventory](InventoryId)

alter table PizzaStore.[Inventory]
add constraint FK_Inventory_CrustId foreign key (CrustId) references PizzaStore.[Crust](CrustId)

alter table PizzaStore.[Inventory]
add constraint FK_Inventory_SizeId foreign key (SizeId) references PizzaStore.[Size](SizeId)

alter table PizzaStore.[Inventory]
add constraint FK_Inventory_ToppingId foreign key (ToppingId) references PizzaStore.[Topping](ToppingId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_OrderId foreign key (OrderId) references PizzaStore.[Order](OrderId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_CrustId foreign key (CrustId) references PizzaStore.[Crust](CrustId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_SizeId foreign key (SizeId) references PizzaStore.[Size](SizeId)

alter table PizzaStore.[Pizza]
add constraint FK_Pizza_ToppingId foreign key (ToppingId) references PizzaStore.[Topping](ToppingId)
