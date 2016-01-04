﻿CREATE TABLE [Configuration].[Caste] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Caste] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Caste] UNIQUE NONCLUSTERED ([Name] ASC)
);

