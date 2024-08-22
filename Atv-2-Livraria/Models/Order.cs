namespace Bookstore.Models;
public class Order{
    public int OrderId { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime EntryDate { get; set; }
    public string Responsible { get; set; } = string.Empty;
    public Client? Client { get; set; }
    public OrderedItem? Item { get; set; }
    public Supplier? Supplier { get; set; }
}