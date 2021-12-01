namespace BrozBackend2;

public static class Api {
    public static void ConfigureApi(this WebApplication app) {
        app.MapGet("/Quotes", GetQuotesAsync);
        app.MapGet("/Quotes/{id}", GetQuoteAsync);
        app.MapPost("/Quotes", InsertQuoteAsync);
        app.MapPut("/Quotes", UpdateQuoteAsync);
        app.MapDelete("/Quotes", DeleteQuoteAsync);
    }

    private static async Task<IResult> GetQuotesAsync(IQuoteData data) {
        try {
            return Results.Ok(await data.GetQuotesAsync());
        } catch (Exception ex) {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetQuoteAsync(int id, IQuoteData data) {
        try {
            var quote = await data.GetQuoteAsync(id);
            return quote != null ? Results.Ok(quote) : Results.NotFound();
        } catch (Exception ex) {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertQuoteAsync(QuoteModel quote, IQuoteData data) {
        try {
            await data.InsertQuoteAsync(quote);
            return Results.Ok();
        } catch (Exception ex) {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateQuoteAsync(QuoteModel quote, IQuoteData data) {
        try {
            await data.UpdateQuoteAsync(quote);
            return Results.Ok();
        } catch (Exception ex) {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteQuoteAsync(int id, IQuoteData data) {
        try {
            await data.DeleteQuoteAsync(id);
            return Results.Ok();
        } catch (Exception ex) {
            return Results.Problem(ex.Message);
        }
    }
}
