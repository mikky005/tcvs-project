using tcvs_core.Enums;

namespace tcvs_core.Entities;

public class StaffUser
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public StaffRole Role { get; set; }
    public DateTime CreatedAt { get; set; }

    public ICollection<ProgramBatch> IssuedBatches { get; set; } = new List<ProgramBatch>();
}