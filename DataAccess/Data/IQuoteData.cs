using DataAccess.Models;

namespace DataAccess.Data;

public interface IQuoteData {
    Task DeleteQuoteAsync(int id);
    Task<QuoteModel?> GetQuoteAsync(int id);
    Task<IEnumerable<QuoteModel>> GetQuotesAsync();
    Task InsertQuoteAsync(QuoteModel quote);
    Task UpdateQuoteAsync(QuoteModel quote);
}