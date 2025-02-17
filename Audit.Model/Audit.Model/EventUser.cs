namespace Audit.Model;

internal class EventUser
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// Пользователь
    /// </summary>
    public required User User { get; set; }

    /// <summary>
    /// Идентификатор события
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// Собятие
    /// </summary>
    public required Event Event { get; set; }
}
