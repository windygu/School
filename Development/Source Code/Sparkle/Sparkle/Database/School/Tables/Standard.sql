﻿CREATE TABLE [School].[Standard] (
    [Id]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [IsActive] BIT          CONSTRAINT [DF_Standard_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Standard] PRIMARY KEY CLUSTERED ([Id] ASC)
);

