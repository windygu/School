﻿CREATE TABLE [Configuration].[Relationship] (
    [Id]        BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50) NOT NULL
    CONSTRAINT [PK_Relationship] PRIMARY KEY CLUSTERED ([Id] ASC)
);
