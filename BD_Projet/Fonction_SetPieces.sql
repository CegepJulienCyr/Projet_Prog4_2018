USE [BD_LEGO_JulienCyr]
GO
/****** Object:  UserDefinedFunction [dbo].[Verif_Piece]    Script Date: 2018-03-12 09:23:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Verif_Piece] (@setid Varchar(50), @pieceid Varchar(50), @color int, @type int)
	RETURNS INT
AS
	BEGIN
		DECLARE @cpt INT
		SELECT @cpt = COUNT(*) FROM dbo.set_pieces where set_id = @setid AND piece_id = @pieceid AND color = @color AND type = @type

		RETURN @cpt
	END

