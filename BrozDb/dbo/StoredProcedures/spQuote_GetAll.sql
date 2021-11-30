CREATE PROCEDURE [dbo].[spQuote_GetAll]
AS
BEGIN
	SELECT [Id], [Date], [Names], [Quote], [Visibility]
	FROM dbo.Quote;
END
