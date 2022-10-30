CREATE TABLE [dbo].[tblProjToProd]
(
	[P2P_ID] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [Project_ID] INT NOT NULL foreign key references tblProject (Project_ID), 
    [Product_ID] INT NOT NULL foreign key references tblProduct (Product_ID), 
    [Quantity] INT NULL
)