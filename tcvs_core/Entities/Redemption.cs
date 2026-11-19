namespace tcvs_core.Entities;

public class Redemption
{
    public Guid Id { get; set; }

    /// <summary>One redemption per voucher — enforce a unique constraint on this in EF config.</summary>
    public Guid VoucherId { get; set; }
    public Voucher? Voucher { get; set; }

    public Guid VendorId { get; set; }
    public Vendor? Vendor { get; set; }

    public DateTime RedeemedAt { get; set; }

    public Guid LedgerEntryId { get; set; }
    public LedgerEntry? LedgerEntry { get; set; }
}