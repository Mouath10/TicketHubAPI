using System.ComponentModel.DataAnnotations;

public class TicketPurchase
{
    [Key]
    public int Id { get; set; }

    public int ConcertId { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    [StringLength(100)]
    public string Email { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    [Phone(ErrorMessage = "Invalid phone number.")]
    public string Phone { get; set; }

    [Range(1, 10, ErrorMessage = "You can purchase between 1 and 10 tickets.")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Credit card number is required.")]
    [CreditCard(ErrorMessage = "Invalid credit card number.")]
    public string CreditCard { get; set; }

    [Required(ErrorMessage = "Expiration date is required.")]
    [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$", ErrorMessage = "Expiration must be in MM/YY format.")]
    public string Expiration { get; set; }

    [Required(ErrorMessage = "Security code is required.")]
    [RegularExpression(@"^\d{3,4}$", ErrorMessage = "Security code must be 3 or 4 digits.")]
    public string SecurityCode { get; set; }

    [Required(ErrorMessage = "Address is required.")]
    [StringLength(150)]
    public string Address { get; set; }

    [Required(ErrorMessage = "City is required.")]
    [StringLength(50)]
    public string City { get; set; }

    [Required(ErrorMessage = "Province is required.")]
    [StringLength(50)]
    public string Province { get; set; }

    [Required(ErrorMessage = "Postal code is required.")]
    [RegularExpression(@"^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d$", ErrorMessage = "Invalid Canadian postal code.")]
    public string PostalCode { get; set; }

    [Required(ErrorMessage = "Country is required.")]
    [StringLength(50)]
    public string Country { get; set; }
}
