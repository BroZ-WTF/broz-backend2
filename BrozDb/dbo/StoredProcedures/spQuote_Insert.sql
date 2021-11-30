CREATE PROCEDURE [dbo].[spQuote_Insert]
	@Date DATE,
	@Names NVARCHAR(100),
	@Quote NVARCHAR(1000),
	@Visibility INT
AS
BEGIN
	INSERT INTO dbo.Quote ([Date], [Names], [Quote], [Visibility])
	VALUES (@Date, @Names, @Quote, @Visibility);
END
