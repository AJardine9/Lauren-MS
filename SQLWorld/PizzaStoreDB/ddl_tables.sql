use PizzaStoreDB;
go

create table PizzaStore.[Address]
(
	[AddressId] int not null identity(1,1)
	,[Street] nvarchar(200) not null
	,[City] nvarchar(100) not null
	,[State] nvarchar(100) not null
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null
);

create table PizzaStore.[User]
(
	[UserId] int not null identity(1,1)
	,[AccountId] int not null
	,[LocationId] int
	,[AddressId] int not null
    ,[Username] nvarchar(100) not null
    ,[Password] nvarchar(100) not null
    ,[LastLocationOrdered] nvarchar(100)
    ,[LastTimeOrdered] datetime2
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null

);

create table PizzaStore.[Order]
(
	[OrderId] int not null identity(1,1)
	,[UserId] int not null
	,[LocationId] int not null
    ,[OrderNumber] int not null
	,[Username] nvarchar (100) not null
    ,[Total] money not null
    ,[PurchaseTime] datetime2
    ,[LocationAddress] nvarchar(100) not null
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null
);

create table PizzaStore.[Location]
(
	[LocationId] int not null identity(1,1)
	,[AccountId] int not null
	,[AddressId] int not null
	,[InventoryId] int not null
	,[OrderNumber] int not null
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null
);

create table PizzaStore.[Topping]
(
	[ToppingId] int not null identity(1,1)
	,[Name] nvarchar(50) not null
	,[Stock] int not null
	,[Price] money not null
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null
);

create table PizzaStore.[Size]
(
	[SizeId] int not null identity(1,1)
	,[Name] nvarchar(50) not null
	,[Stock] int not null
	,[Price] money not null
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null
);

create table PizzaStore.[Crust]
(
	[CrustId] int not null identity(1,1)
	,[Name] nvarchar(50) not null
	,[Stock] int not null
	,[Price] money not null
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null
);

create table PizzaStore.[Inventory]
(
	[InventoryId] int not null identity(1,1)
	,[CrustId] int not null
	,[ToppingId] int not null
	,[SizeId] int not null
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null
);

create table PizzaStore.[Pizza]
(
	[PizzaId] int not null identity(1,1)
	,[OrderId] int not null
	,[CrustId] int not null
    ,[SizeId] int not null
	,[ToppingId] int not null
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null
	
);

create table PizzaStore.[Account]
(
	[AccountId] int not null identity(1,1)
	,[DateModified] as sysutcdatetime()
	,[Active] bit not null
);