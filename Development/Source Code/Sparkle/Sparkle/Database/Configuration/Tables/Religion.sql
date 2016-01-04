﻿CREATE TABLE [Configuration].[Religion] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Religion] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Religion] UNIQUE NONCLUSTERED ([Name] ASC)
);

