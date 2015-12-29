﻿CREATE PROCEDURE [Configuration].[FrequencyInsert]
(  
	@Name Varchar(50),
	@IsActive BIT,
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Frequency(Name,IsActive)
	VALUES(@Name,@IsActive)
   
	SET @Id = @@IDENTITY

END