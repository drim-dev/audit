namespace Audit.Model;

/// <summary>
/// Платёж
/// </summary>
internal class Payment : BaseEntity
{
    /// <summary>
    /// Дата оплаты
    /// </summary>
    public DateTime DateOfPayment { get; set; }

    /// <summary>
    /// Сумма платежа
    /// </summary>
    public decimal Value { get; set; }

    /// <summary>
    /// Назначение платежа
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// Заказ
    /// </summary>
    public required Order Order { get; set; }

    /// <summary>
    /// Идентификатор способа платежа
    /// </summary>
    public int PaymentTypeId { get; set; }

    /// <summary>
    /// Способ платежа
    /// </summary>
    public required PaymentType PaymentType { get; set; }
}
