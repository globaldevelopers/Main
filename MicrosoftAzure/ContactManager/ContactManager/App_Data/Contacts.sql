;with source as
(
Select Name = 'Shalin', Address = '36, Simplemarsh Road', City = 'Addlestone', Zip = 'KT151QJ'
Union All Select 'Shraddha', 'Captans wharf', 'Woking', 'Gu3LT'
)
Merge into dbo.Contacts c
using(select * from source) s on s.Name = c.Name
when matched then 
	Update set c.Address = s.Address, c.City = s.City, c.Zip = s.Zip
when not matched by target then
	Insert(Name, Address, City, Zip) values (s.Name, s.Address, s.City, s.Zip)
when not matched by source then
	Delete;
