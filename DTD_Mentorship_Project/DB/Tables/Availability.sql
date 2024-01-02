﻿CREATE TABLE [dbo].[Availability]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[UserID] INT NOT NULL,
	[DayOfWeek] INT NULL,
	[FromTime] TIME NULL,
	[ToTime] TIME NULL,

	CONSTRAINT [FK_User_ID] FOREIGN KEY ([UserID]) REFERENCES [User]([UserId])

)
