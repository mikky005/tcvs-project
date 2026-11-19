using tcvs_core.Enums;

namespace tcvs_core.Entities;

public class Vendor
{
    public Guid Id { get; set; }
    public string BusinessName { get; set; } = string.Empty;
    public string ContactPhone { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Lga { get; set; } = string.Empty;

    public AccreditationStatus AccreditationStatus { get; set; }
    public string PasswordHash { get; set; } = string.Empty;
    public DateTime? AccreditedAt { get; set; }

    public ICollection<Redemption> Redemptions { get; set; } = new List<Redemption>();
}