﻿CREATE PROCEDURE [Utility].[AppointmentTypeRead]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Name
	FROM Utility.AppointmentType WITH (NOLOCK)
	WHERE Id = @Id   
	
END