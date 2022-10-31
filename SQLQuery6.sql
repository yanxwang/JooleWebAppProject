
CREATE TABLE [dbo].[tblUser]
(
	[User_ID] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[User_Name] varchar (50) NULL,
	[User_Email] varchar (50) NULL,
	[User_Image] varchar (50) NULL,
	[User_Password] varchar (50)
)

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

CREATE TABLE [dbo].[tblProduct]
(
	[Product_ID] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [Product_Name] VARCHAR(50) NULL, 
    [Product_Image] VARCHAR(50) NULL, 
    [Manufacturer_Name] VARCHAR(50) NULL,
    [SubCategory_Name] VARCHAR(50) NULL,
    [Category_Name] VARCHAR(50) NULL,
    [Series] VARCHAR(50) NULL, 
    [Model] VARCHAR(50) NULL, 
    [ModeL_Year] INT NULL, 
    [Type] VARCHAR(50) NULL,
    [Application] VARCHAR(50) NULL, 
    [Mounting_Location] VARCHAR(50) NULL, 
    [Accessories] VARCHAR(50) NULL,
    [Air_Flow] INT NULL,
    [Power_Min] INT NULL, 
    [Power_Max] INT NULL,
    [Operating_Voltage_Min] INT NULL,
    [Operating_Voltage_Max] INT NULL,
    [Fan_Speed_Min] INT NULL, 
    [Fan_Speed_Max] INT NULL,
    [Number_Of_Fan_Speed] INT NULL, 
    [Sound_At_Max_Speed] INT NULL, 
    [Fan_Sweep_Diameter] INT NULL, 
    [Height_Min] INT NULL, 
    [Height_Max] INT NULL, 
    [Weight] INT NULL,
    [Document_Path] VARCHAR(50) NULL
)


CREATE TABLE [dbo].[tblProjToProd]
(
	[P2P_ID] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [Project_ID] INT NOT NULL foreign key references tblProject (Project_ID), 
    [Product_ID] INT NOT NULL foreign key references tblProduct (Product_ID), 
    [Quantity] INT NULL
)




MERGE INTO tblUser AS Target 
USING (VALUES 
        (1, 'Yan Wang', 'prcywang@gmail.com', '/images/person1.png', 'yw0724'), 
        (2, 'Zha Zheng', 'yanxwang@gmail.com', '/images/person1.png', 'zz0627'), 
        (3, 'Xuan Chu', 'yanxxwang@gmail.com', '/images/person1.png', 'xc0408')
) 
AS Source (User_ID, User_Name, User_Email, User_Image, User_Password) 
ON Target.User_ID = Source.User_ID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (User_Name, User_Email, User_Image, User_Password)  
VALUES (User_Name, User_Email, User_Image, User_Password) ;



MERGE INTO tblProduct AS Target
USING (VALUES 
	(1, 'BigAss', '/images/fans1.jpg', 'CIA', 'Fans', 'Mechanical','Haiku H', 'S3-150-S0-BC-O4-01-C-01', 2016, 'Commercial', 'Indoor', 'Roof', 'With Light', 5467, 1.95, 21.14, 100, 240, 35, 200, 7, 35, 60, 12.3, 57, 13, null),
	(2, 'Emerson', '/images/fans2.jpg', 'MI9', 'Fans', 'Mechanical','Luray Eco', 'CF860', 2014, 'Commercial', 'Indoor', 'Roof', 'With Light', 9527, 2.15, 19.14, 100, 240, 10, 180, 5, 20, 40, 5, 50, 8, null),
	(3, 'Minka', '/images/fans3.jpeg', 'FBI', 'Fans', 'Mechanical','Aviation', 'F853-RW', 2015, 'Commercial', 'Indoor', 'Roof', 'With Light', 8848, 2.5, 20.14, 100, 240, 30, 300, 9, 45, 80, 10, 60, 21, null)
)
AS Source (Product_ID, Product_Name, Product_Image, Manufacturer_Name, SubCategory_Name, Category_Name, Series, Model, ModeL_Year, Type, Application, Mounting_Location, Accessories, Air_Flow, Power_Min, Power_Max, Operating_Voltage_Min, Operating_Voltage_Max, Fan_Speed_Min, Fan_Speed_Max, Number_Of_Fan_Speed, Sound_At_Max_Speed, Fan_Sweep_Diameter, Height_Min, Height_Max, Weight, Document_Path)
ON Target.Product_ID = Source.Product_ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Product_Name, Product_Image, Manufacturer_Name, SubCategory_Name, Category_Name, Series, Model, ModeL_Year, Type, Application, Mounting_Location, Accessories, Air_Flow, Power_Min, Power_Max, Operating_Voltage_Min, Operating_Voltage_Max, Fan_Speed_Min, Fan_Speed_Max, Number_Of_Fan_Speed, Sound_At_Max_Speed, Fan_Sweep_Diameter, Height_Min, Height_Max, Weight, Document_Path)
VALUES (Product_Name, Product_Image, Manufacturer_Name, SubCategory_Name, Category_Name, Series, Model, ModeL_Year, Type, Application, Mounting_Location, Accessories, Air_Flow, Power_Min, Power_Max, Operating_Voltage_Min, Operating_Voltage_Max, Fan_Speed_Min, Fan_Speed_Max, Number_Of_Fan_Speed, Sound_At_Max_Speed, Fan_Sweep_Diameter, Height_Min, Height_Max, Weight, Document_Path);



MERGE INTO tblProject AS Target
USING (VALUES 
(1, 'p1', 1, '1155 Twenty-first Street NW.', null, 'Washington, DC', null, 20581),
(2, 'my project', 1, '1155 Twenty-first Street NW.', null, 'Washington, DC', null, 20581),
(3, 'my order', 3, '935 Pennsylvania Avenue NW', null, 'Washington, DC', null, 20535),
(4, 'For home', 2, 'G. Mennen Williams Building', '525 W. Ottawa St', 'Lansing', 'Michigan', 48933),
(5, 'Too much money', 3, '935 Pennsylvania Avenue NW', null, 'Washington, DC', null, 20535),
(6, 'Refunitured', 3, '935 Pennsylvania Avenue NW', null, 'Washington, DC', null, 20535)
)
AS Source (Project_ID, Project_Name, User_id, Project_Address1, Project_Address2, Project_City, Project_State, Project_Postal_Code)
ON Target.Project_ID = Source.Project_ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Project_Name, User_id, Project_Address1, Project_Address2, Project_City, Project_State, Project_Postal_Code)
VALUES (Project_Name, User_id, Project_Address1, Project_Address2, Project_City, Project_State, Project_Postal_Code);



MERGE INTO tblProjToProd AS Target 
USING (VALUES
	(1, 1, 1, 1),
	(2, 2, 2, 1), 
	(3, 3, 3, 2),
	(4, 5, 1, 5)
) 
AS Source (P2P_ID, Project_ID, Product_ID, Quantity) 
ON Target.P2P_ID = Source.P2P_ID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Project_ID, Product_ID, Quantity)  
VALUES (Project_ID, Product_ID, Quantity) ;