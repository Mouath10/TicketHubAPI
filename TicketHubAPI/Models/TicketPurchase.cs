using System.ComponentModel.DataAnnotations;

public class TicketPurchase
{
    [Key]  // This marks the property as the primary key
    public int Id { get; set; }

    // Other properties of TicketPurchase model
    public int ConcertId { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public int Quantity { get; set; }
    public string CreditCard { get; set; }
    public string Expiration { get; set; }
    public string SecurityCode { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}
