SELECT top 1 percent [State], City
FROM People
where City != 'Richmond' and [State] = 'Virginia'

SELECT *
FROM People
WHERE YearOfBirth !< 2000

SELECT GETDATE()

declare
	@currentDate DateTime,
	@currentYear int

set
	@currentDate = GETDATE()

set
	@currentYear = DATEPART(year, @currentDate)

select FirstName as Förnamn, LastName as Efternamn, @currentYear - YearOfBirth as Ålder
from People
where FirstName = 'Mark' and [State] != 'Kentucky'
order by Ålder
go

select *
from People
Where Profession like '%Mobile%' and [State] = 'Virginia'