USE [database-basics]
GO

/****** Object:  Table [dbo].[User]    Script Date: 4/28/2021 6:23:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](150) NOT NULL,
	[Surname] [nchar](150) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Age]  AS (datediff(year,[BirthDate],getdate()))
)
GO
ALTER TABLE [dbo].[User]
ADD CONSTRAINT PK_User_UserID PRIMARY KEY CLUSTERED (UserID)
GO

INSERT INTO [dbo].[User] (FirstName, Surname, BirthDate) VALUES
('Mike', 'Thomson', '2000-05-19')
,('Eduard', 'Garcia', '1985-06-11')
,('James', 'Watson', '1993-07-23')
,('Mirelle', 'Heydens', '1989-11-12')
GO

CREATE TABLE Awards(
	[AwardID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](50) NOT NULL,
	[Description] [nchar](250) NULL
)
GO

ALTER TABLE Awards
ADD CONSTRAINT PK_Award_AwardID PRIMARY KEY CLUSTERED (AwardID)
GO

ALTER TABLE Awards
ADD CONSTRAINT DF_AwardTitle_Title_Unique UNIQUE (Title)
GO

INSERT INTO Awards(Title, Description) VALUES
('User of the month', 'Best user of the month')
,('Meh', 'Worst user of the month')
,('Not bad', 'Try harder next time')
GO



WITH cte AS (
SELECT 
	UserID, 
	FirstName, 
	Surname, 
	BirthDate, 
	Age, 
	ROW_NUMBER() OVER (
		PARTITION BY
			FirstName,
			Surname
		ORDER BY
			FirstName,
			Surname
		) row_num
	FROM
		[dbo].[User]
)
DELETE FROM cte
WHERE row_num > 1;

UPDATE [dbo].[User]
SET FirstName = 'Bruce' , Surname = 'Wayne'
WHERE FirstName = 'Mike';

UPDATE Awards
SET Description = 'GG'
WHERE Title = 'User of the month';

CREATE TABLE UserAward (
	Users_Id int NOT NULL,
	Award_Id int NOT NULL,
	FOREIGN KEY (Users_Id) REFERENCES [dbo].[User](UserID),
	FOREIGN KEY (Award_Id) REFERENCES Awards(AwardID)
	ON UPDATE CASCADE
	ON DELETE CASCADE
);

ALTER TABLE UserAward
ADD CONSTRAINT DF_UserAward_Award_Unique UNIQUE (Award_Id)
GO

INSERT INTO UserAward (Users_Id, Award_Id)
	VALUES (1,2);


INSERT INTO UserAward (Users_Id, Award_Id)
	VALUES (1,1);

INSERT INTO UserAward (Users_Id, Award_Id)
	VALUES (4,3);

SELECT * FROM [dbo].[User];
SELECT * FROM Awards;
SELECT * FROM UserAward;

SELECT [dbo].[User].FirstName, [dbo].[User].Surname, Awards.AwardID, Awards.Title
FROM ((UserAward
INNER JOIN [dbo].[User] ON UserAward.Users_Id = [dbo].[User].UserID)
INNER JOIN Awards ON UserAward.Award_Id = Awards.AwardID);