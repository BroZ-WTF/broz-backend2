using DataAccess.Models;

namespace DataAccess.Data;

public interface IQuoteData {
    Task DeleteQuoteAsync(string id);
    Task<QuoteModel?> GetQuoteAsync(string id);
    Task<IEnumerable<QuoteModel>> GetQuotesAsync();
    Task InsertQuoteAsync(QuoteModel quote);
    Task UpdateQuoteAsync(QuoteModel quote);
}