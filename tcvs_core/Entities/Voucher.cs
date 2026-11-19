using tcvs_core.Enums;

namespace tcvs_core.Entities;

public class Voucher
{
    public Guid Id { get; set; }

    /// <summary>Short, USSD-friendly unique code the beneficiary presents at a vendor.</summary>
    public string VoucherCode { get; set; } = string.Empty;

    public Guid BeneficiaryId { get; set; }
    public Beneficiary? Beneficiary { get; set; }

    public Guid ProgramBatchId { get; set; }
    public ProgramBatch? ProgramBatch { get; set; }

    public DateTime IssuedAt { get; set; }
    public DateTime ExpiresAt { get; set; }

    public VoucherStatus Status { get; set; }

    /// <summary>Null until redeemed — redemption is single, all-or-nothing.</summary>
    public Redemption? Redemption { get; set; }
}