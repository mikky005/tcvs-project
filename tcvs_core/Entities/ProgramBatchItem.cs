namespace tcvs_core.Entities;

public class ProgramBatchItem
{
    public Guid Id { get; set; }

    public Guid ProgramBatchId { get; set; }
    public ProgramBatch? ProgramBatch { get; set; }

    public string ItemName { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public string Unit { get; set; } = string.Empty;
}