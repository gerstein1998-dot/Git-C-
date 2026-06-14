/*
use master
go
drop database knightsGUI
go
*/

CREATE DATABASE KnightsGUI
Go

Use knightsGUI
GO

CREATE TABLE  KnightsTable
(	
	[ID]			int	identity (1,1)		NOT NULL,
	[FirstName]		nvarchar(100)			NOT NULL,
	[LastName]		nvarchar(100)			NOT NULL,
	[Power]			nvarchar(500)			NOT NULL
)
GO

ALTER TABLE dbo.KnightsTable
ADD
CONSTRAINT pk_KnightsTble PRIMARY KEY (ID)
GO

insert KnightsTable values ('Richard', 'The Lionheart', 'Ice Knight')
insert KnightsTable values ('Philip', 'Red Beard', 'Fire Knight')
insert KnightsTable values ('William', 'The Evil', 'Dark Knight')
go


--======================================================
select * from KnightsTable
go

create proc ShowByPower
@power nvarchar(500)
as
	select * from KnightsTable where [Power] = @power
go

EXEC ShowByPower 'ice knight'
go

---------