using Domain.Interface;

namespace Domain.DomainEvents;

public sealed class DrugItemUpdateEvent : IDomainEvent
{
    /// <summary>
    /// Универсальный id
    /// </summary>
    public Guid DrugItemId { get; set; }
    
    /// <summary>
    /// Старое количество
    /// </summary>
    public double OldCount { get; set; }
    
    /// <summary>
    /// Новое количество
    /// </summary>
    public double NewCount { get; set; }
    
    /// <summary>
    /// Причина
    /// </summary>
    public string Reason { get; set; }
    
    internal DrugItemUpdateEvent(Guid drugItemId, double oldCount, double newCount, string reason)
    {
        DrugItemId = drugItemId;
        OldCount = oldCount;
        NewCount = newCount;
        Reason = reason;
    }
}