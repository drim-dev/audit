namespace Audit.Model;

/// <summary>
/// Заказ
/// </summary>
internal class Order : BaseEntity
{
    /// <summary>
    /// Номер заказа
    /// </summary>
    public required string Number { get; set; }

    /// <summary>
    /// Дата оформления заказа
    /// </summary>
    public DateTime DateOfOrder { get; set; }

    /// <summary>
    /// Дата сдачи заказа
    /// </summary>
    public DateTime DateOfIssue { get; set; }

    /// <summary>
    /// Описание заказа
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Адрес заказа
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Клиент
    /// </summary>
    public required Customer Customer { get; set; }

    /// <summary>
    /// Идентификатор партнёра
    /// </summary>
    public int PertnerId { get; set; }

    /// <summary>
    /// Партнёр
    /// </summary>
    public required Customer Partner { get; set; }

    /// <summary>
    /// Идентификатор точки продаж
    /// </summary>
    public int PointOfSaleId { get; set; }

    /// <summary>
    /// Точка продаж
    /// </summary>
    public required PointOfSale PointOfSale { get; set; }

    /// <summary>
    /// Изделия заказа
    /// </summary>
    public ICollection<OrderInstance>? OrderInstances { get; set; }

    /// <summary>
    /// Оплаты по заказу
    /// </summary>
    public ICollection<Payment>? Payments { get; set; }

    /// <summary>
    /// События заказа
    /// </summary>
    //public ICollection<Event>? Events { get; set; }
}
