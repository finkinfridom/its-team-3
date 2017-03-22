CREATE TABLE [dbo].[PrenotaAule] (
    [IDA]        INT          NOT NULL,
    [email]      VARCHAR (30) NOT NULL,
    [oraE]       DATETIME     NOT NULL,
    [oraU]       DATETIME     NOT NULL,
    [insegnante] VARCHAR (30) NOT NULL,
    [materia]    VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([IDA] ASC, [email] ASC),
    FOREIGN KEY ([IDA]) REFERENCES [dbo].[Aula] ([Id]),
    FOREIGN KEY ([email]) REFERENCES [dbo].[Utente] ([email])
);

