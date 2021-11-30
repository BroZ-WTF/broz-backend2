using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class QuoteData : IQuoteData {
    private readonly ISqlDataAccess db;

    public QuoteData(ISqlDataAccess db) {
        this.db = db;
    }

    public Task<IEnumerable<QuoteModel>> GetQuotesAsync() {
        return db.LoadDataAsync<QuoteModel, dynamic>("dbo.spQuotes_GetAll", new { });
    }

    public async Task<QuoteModel?> GetQuoteAsync(string id) {
        return (await db.LoadDataAsync<QuoteModel, dynamic>("dbo.spQuotes_Get", new { Id = id })).FirstOrDefault();
    }

    public Task InsertQuoteAsync(QuoteModel quote) {
        return db.SaveDataAsync("dbo.spQuotes_Insert", new { quote.Date, quote.Names, quote.Quote, quote.Visibility });
    }

    public Task UpdateQuoteAsync(QuoteModel quote) {
        return db.SaveDataAsync("dbo.spQuotes_Update", quote);
    }

    public Task DeleteQuoteAsync(string id) {
        return db.SaveDataAsync("dbo.spQuotes_Delete", new { Id = id });
    }
}
