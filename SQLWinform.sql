CREATE DATABASE WindowForm
Go

USE WindowForm;
GO

CREATE TABLE loginHistory(
	id int IDENTITY PRIMARY KEY, 
	userName NVARCHAR(100) UNIQUE NOT NULL,
	passWord NVARCHAR(100) NOT NULL,
	Time DATETIME not null,
	email NVARCHAR(100)
);
GO

CREATE PROCEDURE GetHistory
AS 
BEGIN
	SELECT * FROM loginHistory;
END;
GO

CREATE PROCEDURE GetById
	@id int
AS 
BEGIN
	SELECT * FROM loginHistory
	WHERE id=@id
END;
GO

CREATE PROCEDURE insertLogin
	@userName NVARCHAR(100),
	@passWord NVARCHAR(100),
	@Time DATETIME,
	@email NVARCHAR(100)
AS 
BEGIN
	INSERT INTO loginHistory(userName,passWord,Time, email)
	VALUES (@userName,@passWord,@Time,@email)
END;
GO

CREATE PROCEDURE updateLogin
	@id int,
	@userName NVARCHAR(100),
	@passWord NVARCHAR(100),
	@Time DATETIME
AS 
BEGIN
	UPDATE loginHistory
	SET @userName=userName,@passWord=passWord,@Time=Time
	WHERE id=@id;
END;
GO

CREATE PROCEDURE CHECKLOGIN
	@userName NVARCHAR(100),
	@passWord NVARCHAR(100),
	@IsValid BIT OUTPUT
AS
BEGIN
	IF EXISTS (
		SELECT * FROM loginHistory
		WHERE userName=@userName AND passWord=@passWord
	)
	BEGIN
		SET @IsValid=1
	END
	ELSE
	BEGIN
		SET @IsValid=0
	END
END;
GO

DECLARE @IsValid BIT;
EXEC CHECKLOGIN @Username = 'admin', @Password = '123', @IsValid = @IsValid OUTPUT;
SELECT @IsValid AS Result;
GO

CREATE PROCEDURE checkEmail
	@email NVARCHAR (100),
	@Result NVARCHAR(10) OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT @Result=passWord
	FROM loginHistory
	WHERE email=@email;

	IF @Result IS NULL
		SET @Result='NOT_FOUND';

END