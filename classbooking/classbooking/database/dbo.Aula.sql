CREATE TABLE [dbo].[Aula]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [note] VARCHAR(50) NOT NULL, 
    [disponibilita] BIT NOT NULL  , 
    [posti_disponibili] INT NOT NULL
)
