select count(*), slc.firstname, sla.city, sla.StateProvince
from SalesLT.Customer as slc
left join SalesLT.CustomerAddress as slca on slca.CustomerID = slc.CustomerID
left join SalesLT.Address as sla on sla.AddressID = slca.AddressID
group by slc.CustomerID, FirstName, sla.City, sla.StateProvince
having count(*) > 1

select * from SalesLT.Customer

select *
from SalesLT.Product;

select *
from SalesLT.Customer as slc
left join SalesLT.CustomerAddress as slca on slca.CustomerID = slc.CustomerID
where slca.AddressID is null;

-- where a customer bought something
select slc.CustomerID, slc.LastName
from SalesLT.Customer as slc
inner join SalesLT.SalesOrderHeader as soh on soh.CustomerID = slc.CustomerID

select slc.CustomerID, slc.LastName, pro.Name
from SalesLT.Customer as slc
inner join SalesLT.SalesOrderHeader as soh on soh.CustomerID = slc.CustomerID
inner join SalesLT.SalesOrderDetail as sod on soh.SalesOrderID = sod.SalesOrderID
inner join SalesLT.Product as pro on sod.ProductID = pro.ProductID

-- name is James cost of order > 25 turing product
select slc.CustomerID, slc.LastName, pro.Name
from SalesLT.Customer as slc
inner join SalesLT.SalesOrderHeader as soh on soh.CustomerID = slc.CustomerID
inner join SalesLT.SalesOrderDetail as sod on soh.SalesOrderID = sod.SalesOrderID
inner join SalesLT.Product as pro on sod.ProductID = pro.ProductID
where slc.FirstName like 'j%'
and soh.TotalDue > 100
and pro.Name like '%touring%';

select slc.CustomerID, slc.LastName, pro.Name
from SalesLT.Customer as slc
inner join
(
	select CustomerID, TotalDue, SalesOrderID 
	from SalesLT.SalesOrderHeader
	where TotalDue > 100
) as soh on soh.CustomerID = slc.CustomerID
inner join SalesLT.SalesOrderDetail as sod on soh.SalesOrderID = sod.SalesOrderID
inner join 
(
	select ProductID, Name
	from SalesLT.Product
	where Name like '%touring%'
) as pro on sod.ProductID = pro.ProductID
where slc.FirstName like 'j%'

-- any touring product that sold a qty 1
select slc.CustomerID, slc.LastName, pro.Name
from SalesLT.Customer as slc
inner join
(
	select CustomerID, TotalDue, SalesOrderID 
	from SalesLT.SalesOrderHeader
	where TotalDue > 100
) as soh on soh.CustomerID = slc.CustomerID
inner join 
(
	select SalesOrderID, OrderQty, ProductID
	from SalesLT.SalesOrderDetail
	where OrderQty = 1
) as sod on soh.SalesOrderID = sod.SalesOrderID
inner join 
(
	select ProductID, Name
	from SalesLT.Product
	where Name like '%touring%'
) as pro on sod.ProductID = pro.ProductID
where slc.FirstName like 'j%';

-- challenge over lunch
select slc.FirstName, sla.AddressLine1
from SalesLT.Customer as slc
inner join 
(
	select CustomerID, AddressID
	from SalesLT.CustomerAddress
) as slca on slca.CustomerID = slc.CustomerID
left join
(
	select AddressID, AddressLine1
	from SalesLT.Address
) as sla on slca.AddressID = sla.AddressID
inner join
(
	select CustomerID, OrderDate, SalesOrderID
	from SalesLT.SalesOrderHeader
	where month(OrderDate) = 7
) as slsoh on slc.CustomerID = slsoh.CustomerID
inner join
(
	select SalesOrderID, ProductID
	from SalesLT.SalesOrderDetail
) as slsod on slsod.SalesOrderID = slsoh.SalesOrderID
inner join
(
	select ProductID, ListPrice
	from SalesLT.Product
	where ListPrice > 10
) as slp on slp.ProductID = slsod.ProductID;

-- check Fred code on with checks on Common Table Expression

-- all customers where their firstname is a customer's last name

select slc.FirstName, slc.LastName, slc2.FirstName, slc2.LastName
from SalesLT.Customer as slc
inner join SalesLT.Customer as slc2 on slc.FirstName = slc2.LastName
order by slc.FirstName;

select firstname
from SalesLT.Customer
union all
select lastname
from SalesLT.Customer;

select firstname
from SalesLT.Customer
except
select lastname
from SalesLT.Customer;

select firstname
from SalesLT.Customer
intersect
select lastname
from SalesLT.Customer;

-- find firstname that is a lastname
select firstname
from SalesLT.Customer
where FirstName in
(
	select LastName
	from SalesLT.Customer
);

select firstname
from SalesLT.Customer
where FirstName not in
(
	select LastName
	from SalesLT.Customer
);

select firstname
from SalesLT.Customer as slc1
where exists
(
	select LastName
	from SalesLT.Customer as slc2
	where slc1.FirstName = slc2.LastName
);

select firstname
from SalesLT.Customer as slc1
where not exists
(
	select LastName
	from SalesLT.Customer as slc2
	where slc1.FirstName = slc2.LastName
);

select TotalDue, ModifiedDate
from SalesLT.SalesOrderHeader as slsoh
where ModifiedDate between '2008-06-08 00:00:00:002' and getdate();
