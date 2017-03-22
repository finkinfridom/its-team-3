CREATE TABLE [dbo].[Utente]
(
	[email] VARCHAR(30) NOT NULL PRIMARY KEY, 
    [pwr] NVARCHAR(30) NOT NULL, 
    [mone] VARCHAR(30) NOT NULL, 
    [cognome] VARCHAR(30) NOT NULL, 
    [tipo]  TIMESTAMP NOT NULL 

)
