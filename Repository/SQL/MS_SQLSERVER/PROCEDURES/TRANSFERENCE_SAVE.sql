﻿CREATE PROCEDURE TRANSFERENCE_SAVE
@ID SMALLINT,
@DATE DATE,
@AMOUNT DECIMAL(10,2),
@KIND SMALLINT,
@SOURCE VARCHAR(50),
@DETAILS VARCHAR(300),
@ACTION_MOMENT DATETIME,
@PROC_RESULT SMALLINT OUTPUT
AS
BEGIN TRY
	IF  @ID = 0
		BEGIN
			INSERT INTO TB_TRANSFERENCE (
			[DATE],
			AMOUNT,
			KIND,
			[SOURCE],
			DETAILS,
			CREATION_DATE
			) VALUES (
			@DATE,
			@AMOUNT,
			@KIND,
			@SOURCE,
			@DETAILS,
			@ACTION_MOMENT
			)
			SET @PROC_RESULT = 1;
		END
	ELSE
		BEGIN
			UPDATE TB_TRANSFERENCE SET
			[DATE] = @DATE,
			AMOUNT = @AMOUNT,
			KIND = @KIND,
			[SOURCE] = @SOURCE,
			DETAILS = @DETAILS,
			UPDATE_DATE = @ACTION_MOMENT
			WHERE ID = @ID;
			SET @PROC_RESULT = 2;
		END
END TRY
BEGIN CATCH
	SET @PROC_RESULT = 0;
END CATCH
GO