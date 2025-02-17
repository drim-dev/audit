namespace Audit.Model;

/// <summary>
/// Изделие заказа
/// </summary>
internal class OrderInstance : BaseEntity
{
    /// <summary>
    /// Наименование изделие
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// Заказ
    /// </summary>
    public required Order Order { get; set; }

    /// <summary>
    /// Техническое описание изделия
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Идентификатор помещения
    /// </summary>
    public int RoomId { get; set; }

    /// <summary>
    /// Помещение
    /// </summary>
    public required Room Room { get; set; }

    /// <summary>
    /// Количество изделий
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Вес сортировки
    /// </summary>
    public short SortOrder { get; set; }

    public ICollection<Product> Products { get; set; }
    public ICollection<ProvideService> ProvideServices { get; set; }
}
