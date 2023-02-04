CREATE PROCEDURE SOURCE_READ
@ID SMALLINT,
@DESCRIPTION VARCHAR(50)
AS 
BEGIN
	IF @ID > 0 
		SELECT * FROM TB_SOURCE SRC
		WHERE SRC.ID = @ID
	ELSE 
		IF @DESCRIPTION <> '' AND @DESCRIPTION IS NOT NULL
			SELECT * FROM TB_SOURCE SRC
			WHERE SRC.[DESCRIPTION] = @DESCRIPTION
		ELSE 
			SELECT SRC.[DESCRIPTION] FROM TB_SOURCE SRC
END;
GO


