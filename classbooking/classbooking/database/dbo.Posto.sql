CREATE TABLE [dbo].[Posto]
(
	[Id] INT NOT NULL, 
    [pc] BIT NOT NULL, 
    [manutenzione] BIT NOT NULL, 
    [disponibilita] BIT NOT NULL, 
    [note] VARCHAR(100) NOT NULL, 
    [IDA] INT NOT NULL REFERENCES Aula(Id), 
    [email] VARCHAR(30) NOT NULL REFERENCES Utente(email), 
    [oraE] DATETIME NOT NULL, 
    [oraU] DATETIME NOT NULL,
	PRIMARY KEY(id,IDA)
)
