namespace tcvs_core.Entities;

public class ProgramBatch
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    public Guid IssuedByStaffUserId { get; set; }
    public StaffUser? IssuedByStaffUser { get; set; }

    public ICollection<ProgramBatchItem> Items { get; set; } = new List<ProgramBatchItem>();
    public ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
}