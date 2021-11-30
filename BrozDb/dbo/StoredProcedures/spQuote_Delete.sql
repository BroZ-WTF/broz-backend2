CREATE PROCEDURE [dbo].[spQuote_Delete]
	@Id INT
AS
BEGIN
	DELETE
	FROM dbo.Quote
	WHERE Id = @Id;
END
