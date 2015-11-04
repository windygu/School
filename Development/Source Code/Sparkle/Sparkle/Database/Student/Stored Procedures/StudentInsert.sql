﻿CREATE PROCEDURE [Student].[StudentInsert]
(
	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@Address Varchar(256),
	@StateId Bigint,
	@City Varchar(50),
	@Pin Int,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Student(FirstName, MiddleName, LastName, Address, StateId, City, Pin)
	VALUES(@FirstName, @MiddleName, @LastName, @Address, @StateId, @City, @Pin)   
	SET @Id = @@IDENTITY
	
END