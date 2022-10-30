CREATE TABLE [dbo].[tblProject]
(
	[Project_ID] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [Project_Name] VARCHAR(50) NULL, 
    [User_id] int NULL foreign key references tblUser (User_ID), 
    [Project_Address1] VARCHAR(50) NULL,
    [Project_Address2] VARCHAR(50) NULL,
    [Project_City] VARCHAR(50) NULL, 
    [Project_State] VARCHAR(50) NULL, 
    [Project_Postal_Code] int NULL
)