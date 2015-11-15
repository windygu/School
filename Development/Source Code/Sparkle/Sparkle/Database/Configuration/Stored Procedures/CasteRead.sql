﻿CREATE PROCEDURE [Configuration].[CasteRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name,ReligionId
   FROM Configuration.Caste WITH (NOLOCK)
   WHERE Id = @Id
   
END