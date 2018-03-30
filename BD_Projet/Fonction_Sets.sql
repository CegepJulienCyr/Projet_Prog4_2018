

CREATE FUNCTION [dbo].[Verif_Sets] (@setid Varchar(50))
	RETURNS INT
AS
	BEGIN
		DECLARE @cpt INT
		SELECT @cpt = COUNT(*) FROM dbo.sets where set_id = @setid

		RETURN @cpt
	END

