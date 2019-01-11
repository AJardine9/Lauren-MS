use PizzaStoreDB;
go

alter table PizzaStore.[Order]
  add constraint CK_Order_PurchaseTime check(PurchaseTime <= sysutcdatetime())
go

