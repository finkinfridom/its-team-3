﻿CREATE TABLE [dbo].[SelectSoftware]
(
	[IDA] INT NOT NULL REFERENCES Aula(Id), 
    [IDS] INT NOT NULL REFERENCES Software(Id),
	PRIMARY KEY(IDA,IDS)
)
