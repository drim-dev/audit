namespace Audit.Model;

/// <summary>
/// Событие
/// </summary>
internal abstract class Event : BaseEntity
{
    /// <summary>
    /// Тема события
    /// </summary>
    public required User Theme { get; set; }

    /// <summary>
    /// Дата и время начала
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Дата и время окончания
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// Описание события
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Идентификатор сущности, к которой относится событие
    /// </summary>
    public int? EntityId { get; set; }

    /// <summary>
    /// Тип сущности, к которой относится событие
    /// </summary>
    public EntityType EntityType { get; set; }

    /// <summary>
    /// Дата выполнения
    /// </summary>
    public DateTime? DateOfCompleted { get; set; }

    /// <summary>
    /// Клиенты, участвющие в событии
    /// </summary>
    public ICollection<EventCustomer>? EventCustomers { get; set; }

    /// <summary>
    /// Пользователи, учавствующие в событии
    /// </summary>
    public required ICollection<EventUser> EventUsers { get; set; }
}
