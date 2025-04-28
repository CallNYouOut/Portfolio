CREATE TABLE [dbo].[States]
(
	[StateId] INT NOT NULL PRIMARY KEY, 
    [State] NVARCHAR(50) NULL, 
    [Population] BIGINT NULL, 
    [State Flag Description] NVARCHAR(50) NULL, 
    [State Flower] NVARCHAR(50) NULL, 
    [State Bird] NVARCHAR(50) NULL, 
    [State Colors] NVARCHAR(50) NULL, 
    [Top 3 Largest Cities] NVARCHAR(MAX) NULL, 
    [State Capitol] NVARCHAR(50) NULL, 
    [Median Income] MONEY NULL, 
    [Percentage of Computer-Related Jobs Offered] INT NULL
)
