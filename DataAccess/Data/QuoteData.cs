using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class QuoteData : IQuoteData {
    private readonly ISqlDataAccess db;

    public QuoteData(ISqlDataAccess db) {
        this.db = db;
    }

    public Task<IEnumerable<QuoteModel>> GetQuotesAsync() {
        return db.LoadDataAsync<QuoteModel, dynamic>("dbo.spQuote_GetAll", new { });
    }

    public async Task<QuoteModel?> GetQuoteAsync(int id) {
        return (await db.LoadDataAsync<QuoteModel, dynamic>("dbo.spQuote_Get", new { Id = id })).FirstOrDefault();
    }

    public Task InsertQuoteAsync(QuoteModel quote) {
        return db.SaveDataAsync("dbo.spQuote_Insert", new { quote.Date, quote.Names, quote.Quote, quote.Visibility });
    }

    public Task UpdateQuoteAsync(QuoteModel quote) {
        return db.SaveDataAsync("dbo.spQuote_Update", quote);
    }

    public Task DeleteQuoteAsync(int id) {
        return db.SaveDataAsync("dbo.spQuote_Delete", new { Id = id });
    }
}
