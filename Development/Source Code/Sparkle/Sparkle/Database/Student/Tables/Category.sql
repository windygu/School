﻿CREATE TABLE Student.Category(
	Id   BIGINT       IDENTITY (1, 1) NOT NULL,
    Name VARCHAR (50) NOT NULL,
    CONSTRAINT PK_Category PRIMARY KEY CLUSTERED (Id ASC)
);