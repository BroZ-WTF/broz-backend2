namespace DataAccess.Models;

public class QuoteModel {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string? Names { get; set; }
    public string? Quote { get; set; }
    public int Visibility { get; set; }
}

