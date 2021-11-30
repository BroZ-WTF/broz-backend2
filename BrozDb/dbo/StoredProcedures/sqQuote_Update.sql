CREATE PROCEDURE [dbo].[sqQuote_Update]
	@Id INT,
	@Date DATE,
	@Names NVARCHAR(100),
	@Quote NVARCHAR(1000),
	@Visibility INT
AS
BEGIN
	UPDATE dbo.Quote
	SET [Date] = @Date, [Names] = @Names, [Quote] = @Quote, [Visibility] = @Visibility
	WHERE Id = @Id;
END
