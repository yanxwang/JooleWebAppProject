CREATE TABLE [dbo].[tblUser]
(
	[User_ID] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[User_Name] varchar (50) NULL,
	[User_Email] varchar (50),
	[User_Image] IMAGE,
	[User_Password] varchar (50)
)