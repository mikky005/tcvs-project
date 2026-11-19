using tcvs_core.Enums;

namespace tcvs_core.Entities;

public class Observer
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Organization { get; set; } = string.Empty;
    public ObserverType ObserverType { get; set; }
    public string Email { get; set; } = string.Empty;

    /// <summary>Drill-down permission level; kept as a plain string for now — refine once portal needs are clearer.</summary>
    public string AccessLevel { get; set; } = string.Empty;
}