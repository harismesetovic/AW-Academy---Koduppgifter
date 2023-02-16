select FirstName, LastName, Info
from ContactInfo join People on People.ID = ContactInfo.PeopleID
where ID = 4

select *
from ContactInfo
where PeopleID = 3