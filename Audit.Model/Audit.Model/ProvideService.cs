namespace Audit.Model;

/// <summary>
/// Услуга заказа
/// </summary>
internal class ProvideService : BaseEntity
{
    /// <summary>
    /// Наименование услуги
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Количество услуги
    /// </summary>
    public decimal Count { get; set; }

    /// <summary>
    /// Коэффициент сложности
    /// </summary>
    public decimal DifficultyFactor { get; set; }

    /// <summary>
    /// Цена оплаты исполнителю услуг
    /// </summary>
    public decimal? PurchasePrice { get; set; }

    /// <summary>
    /// Цена продажи
    /// </summary>
    public decimal SelePrice { get; set; }

    /// <summary>
    /// Идентификатор единицы измерения
    /// </summary>
    public int MeasureUnitId { get; set; }

    /// <summary>
    /// Единица измерения
    /// </summary>
    public required MeasureUnit MeasureUnit { get; set; }

    /// <summary>
    /// Идентификатор изделия
    /// </summary>
    public int OrderInstanceId { get; set; }

    /// <summary>
    /// Изделие
    /// </summary>
    public required OrderInstance OrderInstance { get; set; }
}
