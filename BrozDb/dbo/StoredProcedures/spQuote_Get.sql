CREATE PROCEDURE [dbo].[spQuote_Get]
	@Id INT
AS
BEGIN
	SELECT [Id], [Date], [Names], [Quote], [Visibility]
	FROM dbo.Quote
	WHERE Id = @Id;
END
