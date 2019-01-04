use adventureworks2019; -- reinforce that it will run for adventureworks2019 ONLY. do not on other database
go --creating a context for database we want to use. Run this in own thread in isolation

-- select just computes
select 1 + 1;
select 'lauren', 'Lauren2';
select 'lauren' + 'benson';
-- select 'lauren' + 1;

select * -- all columns, not all the records
from SalesLT.Customer; -- all records

select FirstName, LastName, CustomerID-- case insensitive because we set this database up as such --select clause
from SalesLT.Customer
where FirstName = 'john'; -- filters on rows -- select statement, ends with ;

select FirstName, MiddleName, LastName, CustomerID
from SalesLT.Customer
where (FirstName = 'john'
or FirstName = 'james')
and MiddleName is null; -- can't equal something that doesn't exist, but you can BE something that doesn't exist.

select FirstName, MiddleName, LastName, CustomerID
from SalesLT.Customer
where (FirstName = 'john'
or FirstName = 'james')
and MiddleName is not null;

select FirstName, MiddleName, LastName
from SalesLT.Customer
where FirstName = 'john'
and LastName <> 'beaver';

select FirstName, MiddleName, LastName
from SalesLT.Customer
where FirstName > 'a' and FirstName < 'b'; -- works like a dictionary

select FirstName, MiddleName, LastName
from SalesLT.Customer
where LastName like '%a';

select FirstName, MiddleName, LastName
from SalesLT.Customer
where LastName like '%ber%'
or FirstName like '%ber%'
or MiddleName like '%ber%';

select FirstName, MiddleName, LastName
from SalesLT.Customer
where LastName like '%e_';

select FirstName + ' ' + isNull(MiddleName, '') + ' ' + LastName -- strictly for SQL server -- takes only the first value if not null, else returns second value
from SalesLT.Customer;

select FirstName + ' ' + coalesce(MiddleName, '') + ' ' + LastName -- for any SQL dialect -- takes a collection of values and returns the first that is not null
from SalesLT.Customer;

select count(*), FirstName, LastName
from SalesLT.Customer
where FirstName = 'John'
group by FirstName, LastName;

-- average min and max id # any name ending with R
select avg(CustomerID), min(CustomerID), max(CustomerID)
from SalesLT.Customer
where FirstName like '%r'
or LastName like '%r';

-- count of a person first&lastname where lastname starts w/ k
select count(*), FirstName, LastName
from SalesLT.Customer
where LastName like '[km]%' -- from/where
group by firstname, lastname
having count(*) = 1; -- group/having

select count(*) as Number, FirstName, LastName
from SalesLT.Customer
where LastName like '[km]%' -- from/where
group by firstname, lastname
having count(*) = 1
order by FirstName desc, LastName asc;

-- order of execution
-- from
-- where
-- group by
-- having
-- select
-- order by

select count(StateProvince) as CityAboveAvg, StateProvince
from SalesLT.Address
where City like '%t%'
and CountryRegion = 'United States'-- only states above average -- min and max in order 
group by StateProvince 
order by CityAboveAvg desc

select count(*), slc.firstname, sla.city, sla.StateProvince
from SalesLT.Customer as slc
left join SalesLT.CustomerAddress as slca on slca.CustomerID = slc.CustomerID
left join SalesLT.Address as sla on sla.AddressID = slca.AddressID
group by slc.CustomerID, FirstName, sla.City, sla.StateProvince
having count(*) > 1

select * from SalesLT.Customer

select AddressID
from SalesLT.Address