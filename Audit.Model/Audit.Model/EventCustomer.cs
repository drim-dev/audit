namespace Audit.Model;

/// <summary>
/// Событие клиента
/// </summary>
internal class EventCustomer
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Клиент
    /// </summary>
    public required Customer Customer { get; set; }

    /// <summary>
    /// Идентификатор события
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// Собятие
    /// </summary>
    public required Event Event { get; set; }
}
