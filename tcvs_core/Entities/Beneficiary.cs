using tcvs_core.Enums;

namespace tcvs_core.Entities;

public class Beneficiary
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public int HouseholdSize { get; set; }
    public string State { get; set; } = string.Empty;
    public string Lga { get; set; } = string.Empty;

    public VerificationStatus VerificationStatus { get; set; }

    /// <summary>
    /// Reference/token returned by the VerifyMe verification provider.
    /// The raw NIN is never stored — this is the only link back to it.
    /// </summary>
    public string? VerificationReference { get; set; }

    /// <summary>Hashed PIN used for USSD session authentication.</summary>
    public string? PinHash { get; set; }

    public DateTime RegisteredAt { get; set; }

    public ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
}