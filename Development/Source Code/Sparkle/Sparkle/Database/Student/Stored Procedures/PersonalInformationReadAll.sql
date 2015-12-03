﻿CREATE PROCEDURE Student.PersonalInformationReadAll
AS
BEGIN

	SELECT  Id, StudentId, DateOfBirth, BirthPlace, MothertongueId,
		ReligionId, CasteId, SubCasteId, GenderId, PresentAddressId, PermananentAddressId
	FROM Student.PersonalInformation WITH (NOLOCK)
	
END