create table People
(
	ID int primary key identity not null,
	SSN nvarchar(13) unique not null, -- ÅÅÅÅMMDD-NNNN
	FirstName nvarchar(20) null,
	LastName nvarchar(20) null,
	YearOfBirth int null,
	MonthOfBirth int null,
	DayOfBirth int null,
	AnnualIncome money null,
	[State] nvarchar(20) null,
	City nvarchar(25) null,
	Profession nvarchar(64) null
)
go
