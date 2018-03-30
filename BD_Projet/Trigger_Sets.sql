
CREATE TRIGGER Tester_Doublon_Set1 ON [dbo].[sets] INSTEAD OF INSERT

AS

	BEGIN

		DECLARE @years varchar(50)

		DECLARE @message VARCHAR(100)

		DECLARE @setid VARCHAR(50)

		DECLARE @pieces VARCHAR(50)

		DECLARE @t1 varchar(50)

		DECLARE @descr varchar(250)	

		DECLARE @Verif INT
		

			SELECT @setid = set_id FROM inserted

			SELECT @pieces = pieces FROM inserted
			
			SELECT @years = year FROM inserted

			SELECT @t1 = t1  FROM inserted

			SELECT @descr = descr FROM inserted

			SELECT @Verif = dbo.Verif_Sets(@setid)

			IF @Verif = 0

				BEGIN

					INSERT INTO dbo.sets

					VALUES(@setid, @years, @pieces, @t1, @descr)

					SELECT @message = 'Sets no ' + @setid + ' créée.'

					PRINT(@message)

				END			

			ELSE

				BEGIN

					SELECT @message = 'Cette piece existe déjà!!!'

					PRINT(@message)

				END
	END

GO

CREATE PROCEDURE [dbo].[Insert_Sets] (@setid varchar(50),@pieces varchar(50),@years varchar(50), @t1 varchar(50),@descr varchar(50))
AS
	DECLARE @Verif INT
	DECLARE @message VARCHAR(100)
		
		SELECT @Verif = dbo.Verif_Sets(@setid)
		IF @Verif = 0
			BEGIN
				INSERT INTO dbo.sets
				VALUES(@setid)
				SELECT @message = 'Piece no ' + @setid + ' créée.'
				PRINT( @message)
			END			
		ELSE
			BEGIN
				SELECT @message = 'Ce sets existe déjà!!!'
				PRINT(@message)
			END
			