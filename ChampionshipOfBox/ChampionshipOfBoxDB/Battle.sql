CREATE TABLE [dbo].[Battle]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BattleDateTime] DATETIME2 NOT NULL, 
    [Winner] NVARCHAR(50) NOT NULL, 
    [Loser] NVARCHAR(50) NOT NULL, 
    [RefereePoints] INT NOT NULL
)
