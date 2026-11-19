using tcvs_core.Enums;

namespace tcvs_core.Entities;

/// <summary>
/// Append-only ledger record. The API's database role must be granted
/// INSERT and SELECT only on this table — no UPDATE or DELETE — so the
/// hash chain's tamper-evidence guarantee holds at the database level,
/// not just in application logic.
/// </summary>
public class LedgerEntry
{
    public Guid Id { get; set; }

    /// <summary>Monotonically increasing sequence — defines chain order (DB identity/serial column).</summary>
    public long SequenceNumber { get; set; }

    public string EntityType { get; set; } = string.Empty; // "Voucher" | "Redemption"
    public Guid EntityId { get; set; }

    public LedgerAction Action { get; set; }

    public ActorType ActorType { get; set; }
    public Guid ActorId { get; set; }

    /// <summary>SHA-256 hex digest of this entry's canonical payload.</summary>
    public string PayloadHash { get; set; } = string.Empty;

    /// <summary>Hash of the previous entry in the chain; null only for the genesis entry.</summary>
    public string? PreviousHash { get; set; }

    public DateTime Timestamp { get; set; }
}