namespace Bookstore.Models;
public class Supplier
{
    public string CompanyName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public decimal DiscountMargin { get; set; }
    public string TaxRegime { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;
}