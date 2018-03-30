
USE [BD_LEGO_JulienCyr]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Donnees]    Script Date: 2018-03-12 09:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

			

CREATE TRIGGER Tester_Doublon ON dbo.set_pieces

INSTEAD OF INSERT

AS

	BEGIN

		DECLARE @piece INT

		DECLARE @message VARCHAR(100)

		DECLARE @setid VARCHAR(50)

		DECLARE @pieceid VARCHAR(50)

		DECLARE @num INT

		DECLARE @color INT

		DECLARE @type INT	

		

			SELECT @setid = set_id FROM inserted

			SELECT @pieceid = piece_id  FROM inserted

			SELECT @num = num  FROM inserted

			SELECT @color = color FROM inserted

			SELECT @type = type FROM inserted

		

			SELECT @piece = dbo.Verif_Piece(@setid, @pieceid, @color, @type)

			IF @piece = 0

				BEGIN

					INSERT INTO dbo.set_pieces

					VALUES(@setid, @pieceid, @num ,@color, @type)

					SELECT @message = 'Piece no ' + @pieceid + ' créée.'

					PRINT( @message)

				END			

			ELSE

				BEGIN

					SELECT @message = 'Cette piece existe déjà!!!'

					PRINT(@message)

				END

		END

GO
