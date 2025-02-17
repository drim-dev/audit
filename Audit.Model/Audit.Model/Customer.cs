namespace Audit.Model;

/// <summary>
/// Клиент
/// </summary>
internal class Customer : BaseEntity
{
    /// <summary>
    /// Имя клиента
    /// </summary>
    public required string FirstName { get; set; }

    /// <summary>
    /// Фамилия клиента
    /// </summary>
    public string? Surname { get; set; }

    /// <summary>
    /// Отчество клиента
    /// </summary>
    public string? Patronymic { get; set; }

    /// <summary>
    /// Пол клиента
    /// </summary>
    public GenderType Gender { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// Адрес местожительства
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Номер телефона
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Идентификатор источника клиента
    /// </summary>
    public int? CustomerSourceId { get; set; }

    /// <summary>
    /// Источник клиента
    /// </summary>
    public CustomerSource? CustomerSource { get; set; }

    /// <summary>
    /// События клиента
    /// </summary>
    //public ICollection<Event>? Events { get; set; }
}
